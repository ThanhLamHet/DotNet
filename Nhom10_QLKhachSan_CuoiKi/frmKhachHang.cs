using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using Nhom10_QLKhachSan_CuoiKi.Models;

namespace Nhom10_QLKhachSan_CuoiKi
{
    public partial class frmKhachHang : Form
    {
        private QLKhachSanContext _db = new QLKhachSanContext();
        private int selectedMaKH = 0;

        public frmKhachHang()
        {
            InitializeComponent();
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
			// 1. Cài đặt phong cách hiện đại
			SetupVisualStyles();

			// 2. Định dạng bảng dữ liệu
			StyleDataGridView(dgvKhachHang);

			LoadDataKhachHang();
        }


		private void SetupVisualStyles()
		{
			// Tông màu chủ đạo
			this.BackColor = Color.White;
			this.Font = new Font("Segoe UI", 10);

			// Style cho các nút bấm hành động
			StyleButton(bttThem, Color.FromArgb(34, 197, 94), Color.White);    // Xanh lá
			StyleButton(bttSua, Color.FromArgb(30, 58, 138), Color.White);     // Xanh Navy
			StyleButton(bttXoa, Color.FromArgb(239, 68, 68), Color.White);     // Đỏ
			StyleButton(bttLamMoi, Color.FromArgb(71, 85, 105), Color.White);  // Xám đá
			StyleButton(bttTimKiem, Color.FromArgb(30, 58, 138), Color.White); // Xanh Navy

			// Chỉnh các ô nhập liệu
			foreach (Control c in this.Controls)
			{
				if (c is TextBox txt) txt.BorderStyle = BorderStyle.FixedSingle;
				if (c is GroupBox gb)
				{
					gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
					gb.ForeColor = Color.FromArgb(30, 58, 138);
				}
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

			// Header
			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			dgv.ColumnHeadersHeight = 40;

			// Rows
			dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
			dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
			dgv.RowTemplate.Height = 35;
			dgv.GridColor = Color.FromArgb(241, 245, 249);

			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
		}

		private void LoadDataKhachHang()
		{
			try
			{
				// Chỉ lấy các cột cần thiết để hiển thị, tránh lỗi vòng lặp dữ liệu (Navigation Properties)
				var data = _db.Khachhangs.Select(kh => new
				{
					kh.MaKh,
					kh.HoTen,
					kh.SoDienThoai,
					kh.Cccd,
					kh.Email
				}).AsNoTracking().ToList();

				dgvKhachHang.DataSource = data;

				if (dgvKhachHang.Columns.Count > 0)
				{
					dgvKhachHang.Columns["MaKh"].HeaderText = "Mã KH";
					dgvKhachHang.Columns["HoTen"].HeaderText = "Họ và Tên";
					dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
					dgvKhachHang.Columns["Cccd"].HeaderText = "Số CCCD";
					dgvKhachHang.Columns["Email"].HeaderText = "Địa chỉ Email";

					// Tinh chỉnh độ rộng
					dgvKhachHang.Columns["MaKh"].FillWeight = 50;
					dgvKhachHang.Columns["HoTen"].FillWeight = 150;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
			}
		}

		private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var row = dgvKhachHang.Rows[e.RowIndex];
                    selectedMaKH = (int)row.Cells[0].Value;

                    // Query lai de lay du lieu day du
                    var khachHang = _db.Khachhangs
                        .FirstOrDefault(x => x.MaKh == selectedMaKH);

                    if (khachHang != null)
                    {
                        txtMaKH.Text = khachHang.MaKh.ToString();
                        txtCCCD.Text = khachHang.Cccd.ToString();
                        txtHoTen.Text = khachHang.HoTen;
                        txtEmail.Text = khachHang.Email ?? "";
                        txtSDT.Text = khachHang.SoDienThoai ?? "";
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation: Ho ten khong trong
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Họ tên không được trống!", "Lỗi");
                    return;
                }

                // Validation: Email dung dinh dang (co @ va .)
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                    {
                        MessageBox.Show("Email không đúng định dạng!", "Lỗi");
                        return;
                    }
                }

                var khachHang = new Khachhang
                {
                    HoTen = txtHoTen.Text.Trim(),
                    SoDienThoai = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim(),
                    Cccd = string.IsNullOrWhiteSpace(txtCCCD.Text) ? null : txtCCCD.Text.Trim(),
                    Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                };

                _db.Khachhangs.Add(khachHang);
                _db.SaveChanges();

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                LoadDataKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMaKH == 0)
                {
                    MessageBox.Show("Chọn khách hàng cần sửa!", "Thông báo");
                    return;
                }

                // Validation: Họ tên không trống
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Họ tên không được trống!", "Lỗi");
                    return;
                }

                // Validation: Email dung dinh dang (co @ va .)
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                    {
                        MessageBox.Show("Email không đúng định dạng!", "Lỗi");
                        return;
                    }
                }

                var khachHang = _db.Khachhangs.FirstOrDefault(x => x.MaKh == selectedMaKH);
                if (khachHang != null)
                {
                    khachHang.HoTen = txtHoTen.Text.Trim();
                    khachHang.SoDienThoai = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim();
                    khachHang.Cccd = string.IsNullOrWhiteSpace(txtCCCD.Text) ? null : txtCCCD.Text.Trim();
                    khachHang.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();

                    _db.SaveChanges();
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo");
                    LoadDataKhachHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMaKH == 0)
                {
                    MessageBox.Show("Chọn khách hàng cần xóa!", "Thông báo");
                    return;
                }

                // Kiểm tra khách hàng có đơn hàng không - dùng Any() để kiểm tra FK
                bool hasDonHang = _db.Datphongs
                    .AsNoTracking()
                    .Any(x => x.MaKh == selectedMaKH);

                if (hasDonHang)
                {
                    MessageBox.Show("Không thể xóa khách hàng này vì khách có đặt phòng!", "Thông báo");
                    return;
                }

                // Hỏi xác nhận
                var result = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var khachHang = _db.Khachhangs.FirstOrDefault(x => x.MaKh == selectedMaKH);
                    if (khachHang != null)
                    {
                        _db.Khachhangs.Remove(khachHang);
                        _db.SaveChanges();
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                        LoadDataKhachHang();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void ResetForm()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            txtEmail.Clear();
        }
        private void bttLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadDataKhachHang();
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.ToLower().Trim();

            var query = _db.Khachhangs
                .AsNoTracking() // 
                .Where(kh => kh.HoTen.ToLower().Contains(tuKhoa) ||
                             kh.SoDienThoai.Contains(tuKhoa) ||
                             kh.Email.ToLower().Contains(tuKhoa)) // 
                .Select(kh => new
                {
                    kh.MaKh,
                    kh.HoTen,
                    kh.SoDienThoai,
                    kh.Cccd,
                    kh.Email,
                    TongSoDon = kh.Datphongs.Count
                });

            dgvKhachHang.DataSource = query.ToList();
        }
    }
}
