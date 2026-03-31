using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Lab9_QuanLyThuVien.Models;

namespace Lab9_QuanLyThuVien
{
	public partial class frmNhanVien : Form
	{
		private QLThuVienContext _db = new QLThuVienContext();
		private BindingSource _bsNhanVien = new BindingSource();
		public frmNhanVien()
		{
			InitializeComponent();
		}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			LoadComboBoxBangCap();
			LoadDataNhanVien();
		}
		private void LoadComboBoxBangCap()
		{
			var dsBangCap = _db.Bangcaps.AsNoTracking().ToList();
			cbBangCap.DataSource = dsBangCap;
			cbBangCap.DisplayMember = "TenBangCap";
			cbBangCap.ValueMember = "MaBangCap";
		}

		// 2. Load danh sách nhân viên lên Grid (Sử dụng LINQ tối ưu)
		private void LoadDataNhanVien()
		{
			try
			{
				// Sử dụng AsNoTracking để tăng tốc độ và Include để lấy tên bằng cấp
				var dsNhanVien = _db.Nhanviens
					.AsNoTracking()
					.Include(nv => nv.MaBangCapNavigation)
					.Select(nv => new
					{
						nv.MaNhanVien,
						nv.HoTenNhanVien,
						nv.NgaySinh,
						nv.DiaChi,
						nv.DienThoai,
						TenBangCap = nv.MaBangCapNavigation.TenBangCap,
						nv.MaBangCap // Giữ ẩn để dùng khi click dòng
					})
					.ToList();

				dgvNhanVien.DataSource = dsNhanVien;
				ConfigDataGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		private void ConfigDataGridView()
		{
			if (dgvNhanVien.Columns.Count > 0)
			{
				dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã NV";
				dgvNhanVien.Columns["HoTenNhanVien"].HeaderText = "Họ Tên";
				dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
				dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
				dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
				dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện Thoại";
				dgvNhanVien.Columns["TenBangCap"].HeaderText = "Bằng Cấp";
				dgvNhanVien.Columns["MaBangCap"].Visible = false; // Ẩn mã bằng cấp
			}
		}
		private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
				txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
				txtHoTen.Text = row.Cells["HoTenNhanVien"].Value.ToString();
				dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
				txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
				txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
				cbBangCap.SelectedValue = row.Cells["MaBangCap"].Value;
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtHoTen.Text))
			{
				MessageBox.Show("Vui lòng nhập họ tên nhân viên!");
				return;
			}

			try
			{
				var nvMoi = new Nhanvien
				{
					HoTenNhanVien = txtHoTen.Text.Trim(),
					NgaySinh = dtpNgaySinh.Value,
					DiaChi = txtDiaChi.Text.Trim(),
					DienThoai = txtDienThoai.Text.Trim(),
					MaBangCap = (int)cbBangCap.SelectedValue
				};

				_db.Nhanviens.Add(nvMoi);
				_db.SaveChanges();

				LoadDataNhanVien();
				MessageBox.Show("Thêm nhân viên thành công!");
			}
			catch (Exception ex)
			{
				_db.ChangeTracker.Clear();
				MessageBox.Show("Lỗi khi thêm: " + ex.Message);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaNV.Text)) return;

			int maNV = int.Parse(txtMaNV.Text);

			// Kiểm tra ràng buộc: Nếu nhân viên đã lập phiếu thu tiền thì không được xóa
			bool daCoPhieuThu = _db.Phieuthutiens.Any(p => p.MaNhanVien == maNV);
			if (daCoPhieuThu)
			{
				MessageBox.Show("Không thể xóa nhân viên này vì đã có dữ liệu trong Phiếu Thu Tiền!", "Thông báo");
				return;
			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				var nvXoa = _db.Nhanviens.Find(maNV);
				if (nvXoa != null)
				{
					_db.Nhanviens.Remove(nvXoa);
					_db.SaveChanges();
					LoadDataNhanVien();
					btnLamMoi_Click(null, null);
				}
			}
		}
		

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaNV.Text)) return;

			try
			{
				int maNV = int.Parse(txtMaNV.Text);
				var nv = _db.Nhanviens.Find(maNV);

				if (nv != null)
				{
					nv.HoTenNhanVien = txtHoTen.Text.Trim();
					nv.NgaySinh = dtpNgaySinh.Value;
					nv.DiaChi = txtDiaChi.Text.Trim();
					nv.DienThoai = txtDienThoai.Text.Trim();
					nv.MaBangCap = (int)cbBangCap.SelectedValue;

					_db.SaveChanges();
					MessageBox.Show("Cập nhật thành công!");
					LoadDataNhanVien();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			// 1. Xóa nội dung trong các TextBox
			txtMaNV.Clear();
			txtHoTen.Clear();
			txtDiaChi.Clear();
			txtDienThoai.Clear();
			txtTimKiem.Clear();

			// 2. Đặt lại giá trị mặc định cho DateTimePicker và ComboBox
			dtpNgaySinh.Value = DateTime.Now.AddYears(-20); // Mặc định 20 tuổi
			if (cbBangCap.Items.Count > 0)
				cbBangCap.SelectedIndex = 0;

			// 3. Tải lại dữ liệu mới nhất từ Database bằng LINQ
			// Việc gọi lại LoadDataNhanVien() giúp cập nhật các thay đổi mới nhất
			LoadDataNhanVien();

			// 4. Đưa con trỏ chuột về ô Họ tên để người dùng nhập mới luôn
			txtHoTen.Focus();

			MessageBox.Show("Đã làm mới danh sách và các ô nhập liệu!", "Thông báo");
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string tuKhoa = txtTimKiem.Text.Trim().ToLower();

			var ketQua = _db.Nhanviens
				.AsNoTracking()
				.Include(nv => nv.MaBangCapNavigation)
				.Where(nv => nv.HoTenNhanVien.ToLower().Contains(tuKhoa) || nv.DiaChi.ToLower().Contains(tuKhoa))
				.Select(nv => new {
					nv.MaNhanVien,
					nv.HoTenNhanVien,
					nv.NgaySinh,
					nv.DiaChi,
					nv.DienThoai,
					TenBangCap = nv.MaBangCapNavigation.TenBangCap,
					nv.MaBangCap
				})
				.ToList();

			dgvNhanVien.DataSource = ketQua;
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
