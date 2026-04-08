using Nhom10_QLKhachSan_CuoiKi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Utilities;

namespace Nhom10_QLKhachSan_CuoiKi
{
    public partial class frmKhuyenMai : Form
    {
        private QLKhachSanContext _db = new QLKhachSanContext();
        private int selectedMaKM = 0;
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            SetupVisualStyles();

			LoadKhuyenMai();
        }
		private void SetupVisualStyles()
		{
			// 1. Cấu hình màu sắc chủ đạo (Tone xanh của form Hóa đơn)
			Color primaryBlue = Color.FromArgb(30, 58, 138);   // Xanh đậm
			Color successGreen = Color.FromArgb(34, 197, 94);  // Xanh lá (Thêm)
			Color dangerRed = Color.FromArgb(239, 68, 68);    // Đỏ (Xóa)
			Color secondarySlate = Color.FromArgb(71, 85, 105); // Xám (Làm mới)

			// 2. Cấu hình Form chung
			this.BackColor = Color.White;
			this.Font = new Font("Segoe UI", 10);

			// 3. Làm đẹp GroupBox và các Label bên trong (Duyệt đệ quy)
			ApplyStyleToAllControls(this);

			// 4. Định dạng lại các nút bấm (Chỉ đổi màu, giữ nguyên vị trí/kích thước)
			StyleButton(bttThem, successGreen, Color.White);
			StyleButton(bttSua, primaryBlue, Color.White);
			StyleButton(bttXoa, dangerRed, Color.White);
			StyleButton(bttLamMoi, secondarySlate, Color.White);
			StyleButton(bttTimKiem, primaryBlue, Color.White);

			// 5. Làm đẹp DataGridView
			StyleDataGridView(dgvKhuyenMai);

			// 6. Tùy chỉnh các ô nhập liệu
			txtMaKM.ReadOnly = true;
			txtMaKM.BackColor = Color.FromArgb(241, 245, 249); // Màu xám nhạt cho ô không được sửa
		}

		// Hàm bổ trợ: Làm đẹp nút bấm
		private void StyleButton(Button btn, Color backColor, Color foreColor)
		{
			btn.FlatStyle = FlatStyle.Flat;
			btn.BackColor = backColor;
			btn.ForeColor = foreColor;
			btn.FlatAppearance.BorderSize = 0;
			btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			btn.Cursor = Cursors.Hand;
			// Không set Height ở đây để giữ nguyên kích thước bạn đã vẽ trong Design
		}

		// Hàm bổ trợ: Làm đẹp Grid
		private void StyleDataGridView(DataGridView dgv)
		{
			dgv.BackgroundColor = Color.White;
			dgv.BorderStyle = BorderStyle.None;
			dgv.EnableHeadersVisualStyles = false;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.RowHeadersVisible = false;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Header (Tiêu đề cột)
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			dgv.ColumnHeadersHeight = 35;

			// Cells (Ô dữ liệu)
			dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
			dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
			dgv.RowTemplate.Height = 30;
		}

		// Hàm bổ trợ: Duyệt tất cả control để đổi font/màu label và groupbox
		private void ApplyStyleToAllControls(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is GroupBox gb)
				{
					gb.ForeColor = Color.FromArgb(30, 58, 138);
					gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
				}
				else if (c is Label)
				{
					c.Font = new Font("Segoe UI", 9, FontStyle.Regular);
					c.ForeColor = Color.FromArgb(51, 65, 85);
				}

				if (c.HasChildren) ApplyStyleToAllControls(c);
			}
		}
		private void LoadKhuyenMai(string search = "")
        {
            try
            {
                var query = _db.Khuyenmais.AsNoTracking().AsQueryable();

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(x => x.TenKm.Contains(search) || x.MaKm.ToString().Contains(search));
                }

                dgvKhuyenMai.DataSource = query.Select(x => new
                {
                    x.MaKm,
                    x.TenKm,
                    x.PhanTramGiam,
                    NgayBatDau = x.NgayBatDau.HasValue ? x.NgayBatDau.Value.ToString("dd/MM/yyyy") : "",
                    NgayKetThuc = x.NgayKetThuc.HasValue ? x.NgayKetThuc.Value.ToString("dd/MM/yyyy") : ""
                }).ToList();

                // Đặt tên cột tiếng Việt
                dgvKhuyenMai.Columns[0].HeaderText = "Mã KM";
                dgvKhuyenMai.Columns[1].HeaderText = "Tên Khuyến Mãi";
                dgvKhuyenMai.Columns[2].HeaderText = "Phần Trăm (%)";
                dgvKhuyenMai.Columns[3].HeaderText = "Ngày Bắt Đầu";
                dgvKhuyenMai.Columns[4].HeaderText = "Ngày Kết Thúc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvKhuyenMai.Rows[e.RowIndex];
                    selectedMaKM = Convert.ToInt32(row.Cells[0].Value);

                    // Tìm đối tượng trong DB để lấy dữ liệu gốc (tránh lỗi định dạng ngày tháng từ Grid)
                    var km = _db.Khuyenmais.Find(selectedMaKM);
                    if (km != null)
                    {
                        txtMaKM.Text = km.MaKm.ToString();
                        txtTenKM.Text = km.TenKm;
                        nudPhanTramKM.Value = (decimal)(km.PhanTramGiam ?? 0);
                        dtpNgayBatDau.Value = km.NgayBatDau ?? DateTime.Now;
                        dtpNgayKetThuc.Value = km.NgayKetThuc ?? DateTime.Now;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiển thị chi tiết: " + ex.Message);
                }
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                var km = new Khuyenmai
                {
                    TenKm = txtTenKM.Text,
                    PhanTramGiam = (int)nudPhanTramKM.Value,
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayKetThuc = dtpNgayKetThuc.Value
                };
                _db.Khuyenmais.Add(km);
                _db.SaveChanges();
                LoadKhuyenMai();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void bttSua_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    var km = _db.Khuyenmais.Find(selectedMaKM);
                    if (km != null)
                    {
                        km.TenKm = txtTenKM.Text;
                        km.PhanTramGiam = (int)nudPhanTramKM.Value;
                        km.NgayBatDau = dtpNgayBatDau.Value;
                        km.NgayKetThuc = dtpNgayKetThuc.Value;
                        _db.SaveChanges();
                        LoadKhuyenMai();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }
        private void ResetForm()
        {
            txtMaKM.Clear();
            txtTenKM.Clear();
            nudPhanTramKM.Value = 0;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            selectedMaKM = 0;
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var km = _db.Khuyenmais.Find(selectedMaKM);
                    if (km != null)
                    {
                        _db.Khuyenmais.Remove(km);
                        _db.SaveChanges();
                        LoadKhuyenMai();
                        ResetForm();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }

        private void bttLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadKhuyenMai();
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            LoadKhuyenMai(txtTimKiem.Text);
        }
    }
}
