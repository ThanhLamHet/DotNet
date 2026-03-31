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
	public partial class FrmSach : Form
	{
		private QLThuVienContext _db = new QLThuVienContext();
		private BindingSource _bsSach = new BindingSource();
		public FrmSach()
		{
			InitializeComponent();
		}

		private void FrmSach_Load(object sender, EventArgs e)
		{
			LoadData();
			SetupBindings();

			// Để không tự động chọn dòng đầu tiên khi mới mở
			dgvSach.ClearSelection();
		}
		private void LoadData()
		{
			try
			{

				var ds = _db.Saches.AsNoTracking().ToList();
				_bsSach.DataSource = ds;
				dgvSach.DataSource = _bsSach;

				// Định dạng tiền tệ cho cột TriGia trên Grid
				if (dgvSach.Columns.Contains("TriGia"))
					dgvSach.Columns["TriGia"].DefaultCellStyle.Format = "N0";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		private void SetupBindings()
		{
			// Xóa sạch binding cũ
			txtMaSach.DataBindings.Clear();
			txtTenSach.DataBindings.Clear();
			txtTacGia.DataBindings.Clear();
			txtNamXB.DataBindings.Clear();
			txtNhaXB.DataBindings.Clear();
			txtTriGia.DataBindings.Clear();

			// Binding các trường dữ liệu (Lưu ý: dùng tên TextBox khớp với thiết kế của bạn)
			txtMaSach.DataBindings.Add("Text", _bsSach, "MaSach", true, DataSourceUpdateMode.Never);
			txtTenSach.DataBindings.Add("Text", _bsSach, "TenSach", true, DataSourceUpdateMode.OnValidation);
			txtTacGia.DataBindings.Add("Text", _bsSach, "TacGia", true, DataSourceUpdateMode.OnValidation);
			txtNamXB.DataBindings.Add("Text", _bsSach, "NamXuatBan", true, DataSourceUpdateMode.OnValidation);
			txtNhaXB.DataBindings.Add("Text", _bsSach, "NhaXuatBan", true, DataSourceUpdateMode.OnValidation);

			// Định dạng số cho Trị giá (N0)
			txtTriGia.DataBindings.Add("Text", _bsSach, "TriGia", true, DataSourceUpdateMode.OnValidation, 0, "N0");
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				var sachMoi = new Sach
				{
					TenSach = "Tên sách mới",
					TacGia = "Tác giả mới",
					NamXuatBan = DateTime.Now.Year,
					NgayNhap = DateTime.Now, // Tự động lấy ngày hiện tại
					TriGia = 0
				};
				_db.Saches.Add(sachMoi);
				_db.SaveChanges();

				LoadData();
				_bsSach.MoveLast();
				txtTenSach.Focus();
			}
			catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (_bsSach.Current is Sach s)
			{
				// Kiểm tra ràng buộc khóa ngoại (Nhiều - Nhiều ẩn)
				var sachVoiPhieuMuon = _db.Saches
					.Include(x => x.MaPhieuMuons)
					.FirstOrDefault(x => x.MaSach == s.MaSach);

				if (sachVoiPhieuMuon != null && sachVoiPhieuMuon.MaPhieuMuons.Any())
				{
					MessageBox.Show("Sách này đã có trong lịch sử mượn, không thể xóa!", "Thông báo");
					return;
				}

				if (MessageBox.Show($"Xác nhận xóa cuốn '{s.TenSach}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					_db.Saches.Remove(sachVoiPhieuMuon);
					_db.SaveChanges();
					LoadData();
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				_bsSach.EndEdit();

				if (_bsSach.Current is Sach s)
				{
					var item = _db.Saches.Find(s.MaSach);
					if (item != null)
					{
						item.TenSach = txtTenSach.Text;
						item.TacGia = txtTacGia.Text;
						item.NhaXuatBan = txtNhaXB.Text;

						// Sửa lỗi tại đây
						if (int.TryParse(txtNamXB.Text, out int nam)) item.NamXuatBan = nam;

						// Dùng double.TryParse để khớp với kiểu dữ liệu của bảng SACH
						if (double.TryParse(txtTriGia.Text, out double gia)) item.TriGia = gia;

						_db.SaveChanges();
						MessageBox.Show("Cập nhật thành công!");
						LoadData();
					}
				}
			}
			catch (Exception ex) { MessageBox.Show("Lỗi cập nhật: " + ex.Message); }
		}


		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtTimKiem.Clear();
			txtTenSach.Clear();
			txtTacGia.Clear();
			txtNamXB.Clear();
			txtNhaXB.Clear();
			txtTriGia.Clear();

			LoadData();
			dgvSach.ClearSelection();
			txtTenSach.Focus();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string search = txtTimKiem.Text.ToLower().Trim();
			if (string.IsNullOrEmpty(search))
			{
				LoadData();
				return;
			}

			var kq = _db.Saches
				.Where(s => s.TenSach.Contains(search) || s.TacGia.Contains(search))
				.ToList();
			_bsSach.DataSource = kq;
		}
	}
}
