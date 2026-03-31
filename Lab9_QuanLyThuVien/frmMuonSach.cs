using Lab9_QuanLyThuVien.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace Lab9_QuanLyThuVien
{
	public partial class frmMuonSach : Form
	{
		private QLThuVienContext _db = new QLThuVienContext();
		// Danh sách tạm để chứa sách khách chọn trước khi nhấn Lưu
		private List<Sach> _listSachChon = new List<Sach>();
		public frmMuonSach()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void frmMuonSach_Load(object sender, EventArgs e)
		{
			LoadCombos();
			LoadGridPhieuMuon();
		}
		private void LoadCombos()
		{

			// Yêu cầu: Hiển thị HoTenDocGia + Hạn thẻ (Dùng LINQ Select)
			cbDocGia.DataSource = _db.Docgia.AsNoTracking()
				.Select(d => new {
					d.MaDocGia,
					HienThi = d.HoTenDocGia + " (Hạn: " + (d.NgayHetHan.HasValue ? d.NgayHetHan.Value.ToString("dd/MM/yyyy") : "N/A") + ")"
				}).ToList();
			cbDocGia.DisplayMember = "HienThi";
			cbDocGia.ValueMember = "MaDocGia";

			// Yêu cầu: Hiển thị TenSach + Tác giả
			cbSach.DataSource = _db.Saches.AsNoTracking()
				.Select(s => new {
					s.MaSach,
					HienThi = s.TenSach + " - " + s.TacGia
				}).ToList();
			cbSach.DisplayMember = "HienThi";
			cbSach.ValueMember = "MaSach";
		}

		private void LoadGridPhieuMuon()
		{
			// Hiển thị tất cả phiếu mượn kèm tên độc giả, ngày mượn, số sách (Dùng Include để Join)
			var dsPhieu = _db.Phieumuonsaches.AsNoTracking()
				.Include(p => p.MaDocGiaNavigation)
				.Include(p => p.MaSaches)
				.Select(p => new {
					p.MaPhieuMuon,
					TenDocGia = p.MaDocGiaNavigation.HoTenDocGia,
					p.NgayMuon,
					SoLuongSach = p.MaSaches.Count
				}).ToList();
			dgvPhieuMuon.DataSource = dsPhieu;
		}

		private void btnThemSach_Click(object sender, EventArgs e)
		{
			if (cbSach.SelectedValue == null) return;
			int maS = (int)cbSach.SelectedValue;

			// Kiểm tra xem đã chọn cuốn này trong danh sách tạm chưa
			if (_listSachChon.Any(s => s.MaSach == maS))
			{
				MessageBox.Show("Sách này đã có trong danh sách chọn!");
				return;
			}

			var sach = _db.Saches.Find(maS);
			_listSachChon.Add(sach);

			// Cập nhật Grid tạm
			dgvDanhSachChon.DataSource = null;
			dgvDanhSachChon.DataSource = _listSachChon.Select(x => new { x.MaSach, x.TenSach }).ToList();
		}

		private void btnLuuPhieu_Click(object sender, EventArgs e)
		{
			try
			{
				if (_listSachChon.Count == 0) { MessageBox.Show("Chưa chọn sách!"); return; }

				int maDG = (int)cbDocGia.SelectedValue;
				var docGia = _db.Docgia.Find(maDG);

				// --- KIỂM TRA 1: HẠN THẺ ---
				if (docGia.NgayHetHan < DateTime.Today)
				{
					MessageBox.Show("Thẻ hết hạn, vui lòng gia hạn trước!", "Thông báo");
					return;
				}

				// --- KIỂM TRA 2: TIỀN NỢ ---
				if (docGia.TienNo > 0)
				{
					MessageBox.Show($"Độc giả đang nợ {docGia.TienNo:N0}đ, yêu cầu thanh toán trước!", "Thông báo");
					return;
				}

				// --- KIỂM TRA 3: SỐ SÁCH TỐI ĐA ---
				// Lấy tham số từ bảng THAMSO
				int maxSach = _db.Thamsos.FirstOrDefault(t => t.TenThamSo == "SoSachMuonToiDa")?.GiaTri ?? 3;
				// Đếm số sách đang mượn trong database (SelectMany để đếm chi tiết)
				int dangMuon = _db.Phieumuonsaches.Where(p => p.MaDocGia == maDG).SelectMany(p => p.MaSaches).Count();

				if (dangMuon + _listSachChon.Count > maxSach)
				{
					MessageBox.Show($"Vượt quá số sách tối đa ({maxSach}). Hiện đang mượn {dangMuon} cuốn.", "Từ chối");
					return;
				}

				// --- KIỂM TRA 4: SÁCH ĐÃ CÓ NGƯỜI MƯỢN CHƯA ---
				foreach (var s in _listSachChon)
				{
					bool isOut = _db.Phieumuonsaches.SelectMany(p => p.MaSaches).Any(x => x.MaSach == s.MaSach);
					if (isOut)
					{
						MessageBox.Show($"Cuốn '{s.TenSach}' hiện đang có người mượn!", "Lỗi");
						return;
					}
				}

				// --- LƯU PHIẾU (1 lần SaveChanges cho cả PHIEUMUONSACH + CHITIET) ---
				var phieu = new Phieumuonsach
				{
					MaDocGia = maDG,
					NgayMuon = DateTime.Now
				};

				foreach (var s in _listSachChon)
				{
					// Phải Find lại từ Context để EF theo dõi thực thể này
					var dbSach = _db.Saches.Find(s.MaSach);
					phieu.MaSaches.Add(dbSach);
				}

				_db.Phieumuonsaches.Add(phieu);
				_db.SaveChanges(); // Tự động chèn vào bảng trung gian CHITIETPHIEUMUON

				MessageBox.Show("Lập phiếu mượn thành công!");
				_listSachChon.Clear();
				dgvDanhSachChon.DataSource = null;
				LoadGridPhieuMuon();
			}
			catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
		}
		
		private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Xem chi tiết sách của phiếu được chọn
			if (e.RowIndex >= 0)
			{
				int maPhieu = (int)dgvPhieuMuon.Rows[e.RowIndex].Cells["MaPhieuMuon"].Value;

				var chiTietSachs = _db.Phieumuonsaches.AsNoTracking()
					.Where(p => p.MaPhieuMuon == maPhieu)
					.SelectMany(p => p.MaSaches)
					.Select(s => new { s.MaSach, s.TenSach, s.TacGia })
					.ToList();

				dgvChiTiet.DataSource = chiTietSachs;
			}
		}
	}
}
