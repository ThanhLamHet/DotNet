using Lab9_QuanLyThuVien.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Lab9_QuanLyThuVien
{
	public partial class frmThuTien : Form
	{
		private QLThuVienContext _db = new QLThuVienContext();
		public frmThuTien()
		{
			InitializeComponent();
		}

		private void frmThuTien_Load(object sender, EventArgs e)
		{
			nudSoTienThu.Minimum = 0;

			LoadData();
		}
		private void LoadData(string keyword = "")
		{
			// 1. Chọn nhân viên thu (ComboBox NhanVien)
			cbNhanVien.DataSource = _db.Nhanviens
				.Select(n => new { n.MaNhanVien, n.HoTenNhanVien })
				.ToList();
			cbNhanVien.DisplayMember = "HoTenNhanVien";
			cbNhanVien.ValueMember = "MaNhanVien";
			cbNhanVien.SelectedIndex = -1;

			// 2. Chọn độc giả (Chỉ hiển thị độc giả có TienNo > 0)
			var dsDocGiaNo = _db.Docgia
				.Where(d => d.TienNo > 0)
				.ToList() // Kéo dữ liệu về RAM để tránh lỗi định dạng của EF Core
				.Select(d => new
				{
					d.MaDocGia,
					// FIX LỖI: Ép kiểu về double trước khi gọi ToString("N0")
					HienThi = d.HoTenDocGia
				}).ToList();

			cbDocGia.DataSource = dsDocGiaNo;
			cbDocGia.DisplayMember = "HienThi"; // Đã khớp với tên thuộc tính ở trên
			cbDocGia.ValueMember = "MaDocGia";
			cbDocGia.SelectedIndex = -1;

			// 3. Hiển thị danh sách Lịch sử Phiếu thu lên Grid (dgvPhieuThu)
			var query = _db.Phieuthutiens.AsNoTracking().AsQueryable();

			// Lọc theo từ khóa tìm kiếm (Tên độc giả hoặc tên nhân viên)
			if (!string.IsNullOrEmpty(keyword))
			{
				query = query.Where(p => p.MaDocGiaNavigation.HoTenDocGia.Contains(keyword)
									  || p.MaNhanVienNavigation.HoTenNhanVien.Contains(keyword));
			}

			dgvPhieuThu.DataSource = query.Select(p => new
			{
				p.MaPhieuThuTien,
				TenDocGia = p.MaDocGiaNavigation.HoTenDocGia,
				// FIX LỖI: Ép kiểu double cho các cột hiển thị trên Grid
				SoTienNo = Convert.ToDouble(p.SoTienNo).ToString("N0") + " VNĐ",
				SoTienThu = Convert.ToDouble(p.SoTienThu).ToString("N0") + " VNĐ",
				NguoiThu = p.MaNhanVienNavigation.HoTenNhanVien,
				// Cột ẩn để lấy dữ liệu gốc khi thực hiện chức năng Xóa
				OriginalMaDG = p.MaDocGia,
				OriginalAmount = p.SoTienThu
			}).OrderByDescending(x => x.MaPhieuThuTien).ToList();

			// Ẩn các cột bổ trợ kỹ thuật
			if (dgvPhieuThu.Columns["OriginalMaDG"] != null) dgvPhieuThu.Columns["OriginalMaDG"].Visible = false;
			if (dgvPhieuThu.Columns["OriginalAmount"] != null) dgvPhieuThu.Columns["OriginalAmount"].Visible = false;

			// 4. Reset các ô nhập liệu
			lblSoTienNo.Text = "0 VNĐ";
			nudSoTienThu.Value = 0;
		}

		private void cbDocGia_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Kiểm tra SelectedValue có tồn tại và có phải là kiểu số không
			if (cbDocGia.SelectedValue != null && int.TryParse(cbDocGia.SelectedValue.ToString(), out int maDG))
			{
				var dg = _db.Docgia.Find(maDG);
				if (dg != null)
				{
					// Lấy giá trị tiền nợ (đảm bảo ép kiểu double nếu cần)
					double tienNo = Convert.ToDouble(dg.TienNo);

					// 1. Hiển thị lên Label số tiền nợ
					lblSoTienNo.Text = tienNo.ToString("N0") + " VNĐ";

					// 2. Cấu hình ô nhập số tiền thu (NumericUpDown)
					nudSoTienThu.Maximum = (decimal)tienNo; // Không cho phép thu quá số nợ
					nudSoTienThu.Value = (decimal)tienNo;   // Gợi ý thu hết toàn bộ nợ
				}
			}
			else
			{
				// Nếu chưa chọn ai thì reset về 0
				lblSoTienNo.Text = "0 VNĐ";
				nudSoTienThu.Value = 0;
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (cbDocGia.SelectedValue == null || cbNhanVien.SelectedValue == null)
			{
				MessageBox.Show("Vui lòng chọn đầy đủ Nhân viên và Độc giả!");
				return;
			}

			int maDG = (int)cbDocGia.SelectedValue;
			var dg = _db.Docgia.Find(maDG);
			double soTienThu = (double)nudSoTienThu.Value;

			if (dg != null)
			{
				double tienNoHienTai = dg.TienNo;

				// Kiểm tra logic thu tiền
				if (soTienThu > tienNoHienTai)
				{
					MessageBox.Show("Số tiền thu không được lớn hơn số tiền nợ!");
					return;
				}

				// Tạo mới Phiếu thu tiền
				var phieuThu = new Phieuthutien
				{
					MaDocGia = maDG,
					MaNhanVien = (int)cbNhanVien.SelectedValue,
					SoTienNo = tienNoHienTai,
					SoTienThu = soTienThu
				};
				_db.Phieuthutiens.Add(phieuThu);

				// Cập nhật lại tiền nợ của độc giả
				dg.TienNo = tienNoHienTai - soTienThu;

				_db.SaveChanges();
				MessageBox.Show("Lập phiếu thu thành công!");
				LoadData(); // Làm mới dữ liệu
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (dgvPhieuThu.CurrentRow == null) return;

			int maPhieu = (int)dgvPhieuThu.CurrentRow.Cells["MaPhieuThuTien"].Value;
			int maDG = (int)dgvPhieuThu.CurrentRow.Cells["OriginalMaDG"].Value;
			double soTienTraLai = (double)dgvPhieuThu.CurrentRow.Cells["OriginalAmount"].Value;

			if (MessageBox.Show("Xác nhận xóa phiếu thu và hoàn trả tiền nợ cho độc giả?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				var pt = _db.Phieuthutiens.Find(maPhieu);
				var dg = _db.Docgia.Find(maDG);

				if (pt != null && dg != null)
				{
					dg.TienNo += soTienTraLai; // Hoàn nợ
					_db.Phieuthutiens.Remove(pt);
					_db.SaveChanges();
					LoadData();
				}
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			LoadData(txtTimKiem.Text.Trim());
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtTimKiem.Clear();
			LoadData();
		}
	}
}
