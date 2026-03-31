using Lab9_QuanLyThuVien.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; 
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab9_QuanLyThuVien
{
	public partial class frmDocGia : Form
	{
		private QLThuVienContext _db = new QLThuVienContext();
		public frmDocGia()
		{
			InitializeComponent();
		}

		private void frmDocGia_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void LoadData(string keyword = "")
		{
			var query = _db.Docgia.AsNoTracking().AsQueryable();

			if (!string.IsNullOrEmpty(keyword))
			{
				query = query.Where(d => d.HoTenDocGia.Contains(keyword)
									  || d.Email.Contains(keyword)
									  || d.DiaChi.Contains(keyword));
			}

			// Lấy dữ liệu về bộ nhớ (Client-side) để ToString định dạng VNĐ
			var data = query.ToList();

			dgvDocGia.DataSource = data.Select(d => new
			{
				d.MaDocGia,
				d.HoTenDocGia,
				d.NgaySinh,
				d.DiaChi,
				d.Email,
				d.NgayLapThe,
				d.NgayHetHan,
				// Bỏ ?? 0d vì TienNo không bao giờ null
				TienNoHienThi = d.TienNo.ToString("N0") + " VNĐ"
			}).ToList();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtHoTen.Text))
			{
				MessageBox.Show("Họ tên không được để trống!");
				return;
			}

			if (dtpNgayHetHan.Value <= dtpNgayLapThe.Value)
			{
				MessageBox.Show("Ngày hết hạn phải lớn hơn ngày lập thẻ!");
				return;
			}

			var dg = new Docgium
			{
				HoTenDocGia = txtHoTen.Text,
				NgaySinh = dtpNgaySinh.Value,
				DiaChi = txtDiaChi.Text,
				Email = txtEmail.Text,
				NgayLapThe = dtpNgayLapThe.Value,
				NgayHetHan = dtpNgayHetHan.Value,
				TienNo = 0 // Tiền nợ mặc định = 0
			};

			_db.Docgia.Add(dg);
			_db.SaveChanges();
			MessageBox.Show("Thêm độc giả thành công!");
			LoadData();
			btnLamMoi_Click(null, null);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (dgvDocGia.CurrentRow == null) return;
			int id = (int)dgvDocGia.CurrentRow.Cells["MaDocGia"].Value;

			var dg = _db.Docgia.Find(id);
			if (dg == null) return;

			// Kiểm tra phiếu mượn
			bool coPhieuMuon = _db.Phieumuonsaches.Any(p => p.MaDocGia == id);
			if (coPhieuMuon)
			{
				MessageBox.Show("Độc giả đang có phiếu mượn, không được xóa!");
				return;
			}

			// Kiểm tra tiền nợ: So sánh trực tiếp d.TienNo > 0
			if (dg.TienNo > 0)
			{
				MessageBox.Show("Độc giả đang nợ tiền, không được xóa!");
				return;
			}

			if (MessageBox.Show("Xác nhận xóa độc giả?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				_db.Docgia.Remove(dg);
				_db.SaveChanges();
				LoadData();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (dgvDocGia.CurrentRow == null) return;
			int id = (int)dgvDocGia.CurrentRow.Cells["MaDocGia"].Value;

			var dg = _db.Docgia.Find(id);
			if (dg != null)
			{
				dg.HoTenDocGia = txtHoTen.Text;
				dg.NgaySinh = dtpNgaySinh.Value;
				dg.DiaChi = txtDiaChi.Text;
				dg.Email = txtEmail.Text;
				dg.NgayLapThe = dtpNgayLapThe.Value;
				dg.NgayHetHan = dtpNgayHetHan.Value;
				// Lưu ý: Không cập nhật TienNo ở đây theo yêu cầu

				_db.SaveChanges();
				MessageBox.Show("Cập nhật thông tin thành công!");
				LoadData();
			}
		}

		private void btnGiaHan_Click(object sender, EventArgs e)
		{
			if (dgvDocGia.CurrentRow == null) return;
			int id = (int)dgvDocGia.CurrentRow.Cells["MaDocGia"].Value;

			var dg = _db.Docgia.Find(id);
			if (dg != null)
			{
				// Cộng thêm 1 năm vào NgayHetHan
				dg.NgayHetHan = dg.NgayHetHan.Value.AddYears(1);
				_db.SaveChanges();
				MessageBox.Show("Đã gia hạn thẻ thêm 1 năm!");
				LoadData();
			}
		}
		private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
		{
if (e.RowIndex >= 0)
			{
				var row = dgvDocGia.Rows[e.RowIndex];

				// Gán các trường Text cơ bản
				txtMaDG.Text = row.Cells["MaDocGia"].Value?.ToString();
				txtHoTen.Text = row.Cells["HoTenDocGia"].Value?.ToString();

				// ĐÂY LÀ 2 DÒNG BẠN ĐANG THIẾU:
				txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
				txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

				// Gán các trường Ngày tháng (Dùng ?? để chống crash nếu DB null)
				dtpNgaySinh.Value = (row.Cells["NgaySinh"].Value as DateTime?) ?? DateTime.Now;
				dtpNgayLapThe.Value = (row.Cells["NgayLapThe"].Value as DateTime?) ?? DateTime.Now;
				dtpNgayHetHan.Value = (row.Cells["NgayHetHan"].Value as DateTime?) ?? DateTime.Now;

				// Gán tiền nợ (Lưu ý tên cột phải khớp với lúc bạn Select trong LoadData)
				txtTienNo.Text = row.Cells["TienNoHienThi"].Value?.ToString() ?? "0 VNĐ";
			}
		}
		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtMaDG.Clear();
			txtHoTen.Clear();
			txtDiaChi.Clear();
			txtEmail.Clear();
			txtTienNo.Text = "0 VNĐ";
			dtpNgaySinh.Value = DateTime.Now.AddYears(-20);
			dtpNgayLapThe.Value = DateTime.Now;
			dtpNgayHetHan.Value = DateTime.Now.AddMonths(6);
			LoadData();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			// Gọi hàm LoadData và truyền giá trị trong TextBox vào
			LoadData(txtTimKiem.Text.Trim());
		}
	}
}
