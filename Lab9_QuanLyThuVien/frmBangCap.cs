using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Lab9_QuanLyThuVien.Models;
using System.Linq;

namespace Lab9_QuanLyThuVien
{
	public partial class frmBangCap : Form
	{
		private QLThuVienContext _db = new QLThuVienContext();
		private BindingSource _bsBangCap = new BindingSource();

		public frmBangCap()
		{
			InitializeComponent();
		}

		private void frmBangCap_Load(object sender, EventArgs e)
		{
			LoadData();
			SetupBindings();
		}

		private void LoadData()
		{
			try
			{
				// Yêu cầu kỹ thuật: Truy vấn chỉ đọc dùng AsNoTracking() 
				var dsBangCap = _db.Bangcaps.AsNoTracking().ToList();

				_bsBangCap.DataSource = dsBangCap;
				dgvBangCap.DataSource = _bsBangCap;

				// Tùy chỉnh tiêu đề cột cho đẹp
				dgvBangCap.Columns["MaBangCap"].HeaderText = "Mã Bằng Cấp";
				dgvBangCap.Columns["TenBangCap"].HeaderText = "Tên Bằng Cấp";

				// Ẩn cột Navigation Property (nếu có) để tránh lỗi hiển thị
				if (dgvBangCap.Columns.Contains("Nhanviens"))
					dgvBangCap.Columns["Nhanviens"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		private void SetupBindings()
		{
			txtMaBangCap.DataBindings.Clear();
			txtTenBangCap.DataBindings.Clear();

			// Bind Mã bằng cấp (Chỉ đọc)
			txtMaBangCap.DataBindings.Add("Text", _bsBangCap, "MaBangCap", true);
			// Bind Tên bằng cấp
			txtTenBangCap.DataBindings.Add("Text", _bsBangCap, "TenBangCap", true, DataSourceUpdateMode.OnValidation);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtTenBangCap.Text))
				{
					MessageBox.Show("Vui lòng nhập tên bằng cấp trước khi thêm!");
					txtTenBangCap.Focus();
					return;
				}

				var bcMoi = new Bangcap { TenBangCap = txtTenBangCap.Text };

				_db.Bangcaps.Add(bcMoi);
				_db.SaveChanges();

				MessageBox.Show("Thêm bằng cấp thành công!");
				LoadData();
				_bsBangCap.MoveLast();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thêm: " + ex.Message);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (_bsBangCap.Current is Bangcap bcHienTai)
			{
				// Kiểm tra xem có nhân viên nào đang dùng bằng cấp này không 
				bool dangDung = _db.Nhanviens.Any(nv => nv.MaBangCap == bcHienTai.MaBangCap);

				if (dangDung)
				{
					MessageBox.Show("Không thể xóa bằng cấp này vì đang có nhân viên sử dụng!", "Thông báo lỗi");
					return;
				}

				var xacNhan = MessageBox.Show($"Bạn có chắc muốn xóa bằng cấp: {bcHienTai.TenBangCap}?",
											 "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (xacNhan == DialogResult.Yes)
				{
					var bcXoa = _db.Bangcaps.Find(bcHienTai.MaBangCap);
					if (bcXoa != null)
					{
						_db.Bangcaps.Remove(bcXoa);
						_db.SaveChanges();
						LoadData();
						MessageBox.Show("Đã xóa thành công!");
					}
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (_bsBangCap.Current is Bangcap bcHienTai)
				{
					var bcDb = _db.Bangcaps.Find(bcHienTai.MaBangCap);
					if (bcDb != null)
					{
						bcDb.TenBangCap = txtTenBangCap.Text;
						_db.SaveChanges();
						MessageBox.Show("Cập nhật thành công!");
						LoadData();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi sửa: " + ex.Message);
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtTenBangCap.Clear();
			txtMaBangCap.Clear();
			LoadData();
		}
	}
}