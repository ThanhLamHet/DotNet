using Microsoft.EntityFrameworkCore;
using Nhom10_QLKhachSan_CuoiKi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nhom10_QLKhachSan_CuoiKi
{
	public partial class frmPhong : Form
	{
		private QLKhachSanContext db = new QLKhachSanContext();
		public frmPhong()
		{
			InitializeComponent();
		}
		private void LamMoi()
		{
			LoadDSPhong();

			txtTenPhong.Clear();
			cboLoaiPhong.SelectedIndex = -1;
			cboTrangThai.SelectedIndex = 0;
			txtMoTa.Clear();
			txtGia.Clear();
			txtMaPhong.Text = "Tự động tạo";
		}
		private void LoadCBOLoaiPhong()
		{
			cboLoaiPhong.DataSource = db.Loaiphongs.ToList();
			cboLoaiPhong.DisplayMember = "TenLoai";
			cboLoaiPhong.ValueMember = "MaLoai";
		}
		private void SetupVisualStyles()
		{
			// Tông màu chủ đạo (Navy Blue)
			this.BackColor = Color.White;
			this.Font = new Font("Segoe UI", 10);

			// Style cho các nút bấm hành động
			StyleButton(btnThem, Color.FromArgb(34, 197, 94), Color.White);    // Xanh lá (Thêm)
			StyleButton(btnSua, Color.FromArgb(30, 58, 138), Color.White);     // Xanh Navy (Sửa)
			StyleButton(btnXoa, Color.FromArgb(239, 68, 68), Color.White);     // Đỏ (Xóa)
			StyleButton(btnLamMoi, Color.FromArgb(71, 85, 105), Color.White);  // Xám đá (Làm mới)

			// Cải thiện hiển thị ComboBox và TextBox
			foreach (Control c in this.Controls)
			{
				if (c is TextBox txt) txt.BorderStyle = BorderStyle.FixedSingle;
				if (c is ComboBox cbo) cbo.FlatStyle = FlatStyle.Flat;
			}
		}

		private void StyleButton(Button btn, Color backColor, Color foreColor)
		{
			btn.FlatStyle = FlatStyle.Flat;
			btn.BackColor = backColor;
			btn.ForeColor = foreColor;
			btn.FlatAppearance.BorderSize = 0;
			btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			btn.Cursor = Cursors.Hand;
			btn.Height = 35;
		}

		private void StyleDataGridView(DataGridView dgv)
		{
			dgv.BackgroundColor = Color.White;
			dgv.BorderStyle = BorderStyle.None;
			dgv.EnableHeadersVisualStyles = false;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.RowHeadersVisible = false;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Thiết kế Header
			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			dgv.ColumnHeadersHeight = 40;

			// Thiết kế các hàng dữ liệu (Bỏ Aqua/Yellow cũ)
			dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
			dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
			dgv.RowTemplate.Height = 35;
			dgv.GridColor = Color.FromArgb(241, 245, 249);

			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
			dgv.RowsDefaultCellStyle.BackColor = Color.White;
		}

		private void LoadDSPhong()
		{
			var ds = db.Phongs.AsNoTracking().Select(p => new
			{
				p.MaPhong,
				LoaiPhong = p.MaLoaiNavigation.TenLoai,
				p.TenPhong,
				p.TrangThai,
				Gia = p.MaLoaiNavigation.GiaMacDinh,
				p.MoTa
			}).ToList();

			dgvPhong.DataSource = ds;

			if (dgvPhong.Columns.Count > 0)
			{
				dgvPhong.Columns["MaPhong"].HeaderText = "Mã số";
				dgvPhong.Columns["LoaiPhong"].HeaderText = "Loại phòng";
				dgvPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
				dgvPhong.Columns["TrangThai"].HeaderText = "Trạng thái";
				dgvPhong.Columns["Gia"].HeaderText = "Đơn giá";
				dgvPhong.Columns["MoTa"].HeaderText = "Mô tả";

				// Định dạng cột Giá và căn lề
				dgvPhong.Columns["Gia"].DefaultCellStyle.Format = "#,##0";
				dgvPhong.Columns["Gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dgvPhong.Columns["Gia"].DefaultCellStyle.ForeColor = Color.DarkRed;

				// Điều chỉnh độ rộng cột
				dgvPhong.Columns["MaPhong"].FillWeight = 40;
				dgvPhong.Columns["Gia"].FillWeight = 80;
			}
		}
		private void frmPhong_Load(object sender, EventArgs e)
		{
			// 1. Cài đặt phong cách hiện đại
			SetupVisualStyles();

			// 2. Định dạng bảng dữ liệu
			StyleDataGridView(dgvPhong);

			LoadDSPhong();
			LoadCBOLoaiPhong();

			txtMaPhong.Text = "Tự động tạo";
			cboLoaiPhong.SelectedIndex = -1;
			cboTrangThai.SelectedIndex = -1;
		}

		private void dgvPhong_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvPhong.CurrentRow == null) return;
			DataGridViewRow row = dgvPhong.CurrentRow;

			txtMaPhong.Text = row.Cells["MaPhong"].Value?.ToString();
			cboLoaiPhong.Text = row.Cells["LoaiPhong"].Value?.ToString();
			txtTenPhong.Text = row.Cells["TenPhong"].Value?.ToString();
			cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
			txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
			txtGia.Text = row.Cells["Gia"].Value?.ToString();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTenPhong.Text) || string.IsNullOrEmpty(cboLoaiPhong.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtTenPhong.Focus();
				return;
			}
			int.TryParse(txtMaPhong.Text, out int MP);
			if (db.Phongs.Any(x => x.MaPhong == MP))
			{
				MessageBox.Show("Đã tồn tại phòng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtTenPhong.Focus();
				return;
			}
			Phong p = new Phong
			{
				MaPhong = MP,
				MaLoai = Convert.ToInt32(cboLoaiPhong.SelectedValue),
				TenPhong = txtTenPhong.Text.Trim(),
				TrangThai = cboTrangThai.Text,
				MoTa = txtMoTa.Text.Trim(),
			};
			db.Phongs.Add(p);
			db.SaveChanges();

			LamMoi();

			MessageBox.Show("Thêm thành công!", "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtMaPhong.Text == "Tự động tạo")
			{
				MessageBox.Show("Vui lòng chọn phòng muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			int.TryParse(txtMaPhong.Text, out int MP);
			Phong? p = db.Phongs.FirstOrDefault(lp => lp.MaPhong == MP);
			if (p == null)
			{
				MessageBox.Show("Không tìm thấy phòng",
					"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
			}

			p.TenPhong = txtTenPhong.Text.Trim();
			p.MaLoai = Convert.ToInt32(cboLoaiPhong.SelectedValue);
			p.TrangThai = cboTrangThai.Text;
			p.MoTa = txtMoTa.Text.Trim();

			db.SaveChanges();
			LamMoi();

			MessageBox.Show("Cập nhật thành công!",
				"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (txtMaPhong.Text == "Tự động tạo")
			{
				MessageBox.Show("Vui lòng chọn phòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			int.TryParse(txtMaPhong.Text, out int MP);
			Phong? p = db.Phongs.FirstOrDefault(lp => lp.MaPhong == MP);

			// Kiểm tra FK: Có phòng nào thuộc loại phòng này không
			if (p.TrangThai != "Trống")
			{
				MessageBox.Show($"Không thể xóa! Phòng '{txtTenPhong.Text}' vẫn còn người ở hoặc đang được đặt",
					"Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
			}
			if (db.ChitietDps.Any(ct => ct.MaDp == MP))
			{
				MessageBox.Show($"Không thể xóa! Phòng '{txtTenPhong.Text}' đã sinh đơn'",
					"Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
			}

			var cf = MessageBox.Show($"Xóa phòng '{txtTenPhong.Text}'?", "Xác nhận",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (cf != DialogResult.Yes) return;

			if (p != null) { db.Phongs.Remove(p); db.SaveChanges(); }

			LamMoi();

			MessageBox.Show("Xóa thành công!",
				"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LamMoi();
		}

		private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void locTrangThai(int tt)
		{
			switch (tt)
			{
				case 0: // Tất cả
					LoadDSPhong();
					return;
				case 1: // Trống
					var ds1 = db.Phongs.AsNoTracking().Where(p => p.TrangThai == "Trống").Select(p => new
					{
						p.MaPhong,
						LoaiPhong = p.MaLoaiNavigation.TenLoai,
						p.TenPhong,
						p.TrangThai,
						Gia = p.MaLoaiNavigation.GiaMacDinh,
						p.MoTa
					}).ToList();
					if (ds1.Count == 0)
					{
						MessageBox.Show("Không có phòng ở trạng thái Trống");
						LoadDSPhong();
						return;
					}

					dgvPhong.DataSource = ds1;
					return;
				case 2: // Đã đặt trước
					var ds2 = db.Phongs.AsNoTracking().Where(p => p.TrangThai == "Đã đặt trước").Select(p => new
					{
						p.MaPhong,
						LoaiPhong = p.MaLoaiNavigation.TenLoai,
						p.TenPhong,
						p.TrangThai,
						Gia = p.MaLoaiNavigation.GiaMacDinh,
						p.MoTa
					}).ToList();
					if (ds2.Count == 0)
					{
						MessageBox.Show("Không có phòng ở trạng thái Đã đặt trước");
						LoadDSPhong();
						return;
					}
					dgvPhong.DataSource = ds2;
					return;
				case 3: // Có khách
					var ds3 = db.Phongs.AsNoTracking().Where(p => p.TrangThai == "Có khách").Select(p => new
					{
						p.MaPhong,
						LoaiPhong = p.MaLoaiNavigation.TenLoai,
						p.TenPhong,
						p.TrangThai,
						Gia = p.MaLoaiNavigation.GiaMacDinh,
						p.MoTa
					}).ToList();

					if (ds3.Count == 0)
					{
						MessageBox.Show("Không có phòng ở trạng thái Có khách");
						LoadDSPhong();
						return;
					}
					dgvPhong.DataSource = ds3;
					return;
				default:
					MessageBox.Show("Vui lòng chọn 1 trạng thái phòng bạn muốn lọc");
					return;
			}
			;
		}
		private void btnLoc_Click(object sender, EventArgs e)
		{
			if (dgvPhong.CurrentRow == null) return;
			locTrangThai(cbLocTrangThai.SelectedIndex);

			if (dgvPhong.Columns.Count > 0)
			{
				dgvPhong.Columns["MaPhong"].HeaderText = "Mã phòng";
				dgvPhong.Columns["LoaiPhong"].HeaderText = "Loại phòng";
				dgvPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
				dgvPhong.Columns["TrangThai"].HeaderText = "Trạng thái";
				dgvPhong.Columns["Gia"].HeaderText = "Giá phòng";
				dgvPhong.Columns["MoTa"].HeaderText = "Mô tả";
			}
			else
			{
				dgvPhong.DataSource = null;
				return;
			}
		}
	}
}
