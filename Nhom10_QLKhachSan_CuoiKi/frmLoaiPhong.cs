using Nhom10_QLKhachSan_CuoiKi.Models;
using Microsoft.EntityFrameworkCore;

namespace Nhom10_QLKhachSan_CuoiKi
{
    public partial class frmLoaiPhong : Form
    {
        private QLKhachSanContext db = new QLKhachSanContext();
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        private void LamMoi()
        {

            LoadDSLoaiPhong();

            txtTenLP.Clear();
            numSoNguoi.Value = numSoNguoi.Minimum;
            txtGia.Clear();
            txtMaLP.Text = "Tự động tạo";
        }
        private void LoadDSLoaiPhong()
        {
            var ds = db.Loaiphongs.AsNoTracking().Select(lp => new
            {
                lp.MaLoai,
                lp.TenLoai,
                lp.SoNguoiToiDa,
                lp.GiaMacDinh,
            }).ToList();

            dgvLoaiPhong.DataSource = ds;
            if (dgvLoaiPhong.Columns.Count > 0)
            {
                dgvLoaiPhong.Columns["MaLoai"].HeaderText = "Mã loại";
                dgvLoaiPhong.Columns["TenLoai"].HeaderText = "Loại phòng";
                dgvLoaiPhong.Columns["SoNguoiToiDa"].HeaderText = "Số người";
                dgvLoaiPhong.Columns["GiaMacDinh"].HeaderText = "Giá phòng";
            }
            dgvLoaiPhong.RowsDefaultCellStyle.BackColor = Color.Aqua;
            dgvLoaiPhong.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow;

            dgvLoaiPhong.Columns["MaLoai"].Width = dgvLoaiPhong.Width / 100 * 10;
            dgvLoaiPhong.Columns["TenLoai"].Width = dgvLoaiPhong.Width / 100 * 50;
            dgvLoaiPhong.Columns["SoNguoiToiDa"].Width = dgvLoaiPhong.Width / 100 * 15;
            dgvLoaiPhong.Columns["GiaMacDinh"].Width = dgvLoaiPhong.Width / 100 * 25;

            dgvLoaiPhong.Columns["GiaMacDinh"].DefaultCellStyle.Format = "#,##0 'VND'";
        }
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
			// 1. Cài đặt phong cách trực quan
			SetupVisualStyles();

			// 2. Định dạng bảng dữ liệu
			StyleDataGridView(dgvLoaiPhong);

			LoadDSLoaiPhong();
            txtMaLP.Text = "Tự động tạo";
        }
		private void SetupVisualStyles()
		{
			// Tông màu chủ đạo
			Color primaryBlue = Color.FromArgb(30, 58, 138);
			this.BackColor = Color.White;
			this.Font = new Font("Segoe UI", 10);

			// Tiêu đề Form (Nếu bạn dùng Label làm tiêu đề)
			// lblTitle.ForeColor = primaryBlue;
			// lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);

			// Style cho các nút bấm
			StyleButton(btnThem, Color.FromArgb(34, 197, 94), Color.White);    // Xanh lá
			StyleButton(btnSua, Color.FromArgb(30, 58, 138), Color.White);     // Xanh Navy
			StyleButton(btnXoa, Color.FromArgb(239, 68, 68), Color.White);     // Đỏ
			StyleButton(btnLamMoi, Color.FromArgb(71, 85, 105), Color.White);  // Xám đá

			// Bo góc và làm đẹp các ô nhập liệu (WinForms thuần hạn chế bo góc, nhưng ta chỉnh Border)
			foreach (Control c in this.Controls)
			{
				if (c is TextBox txt) { txt.BorderStyle = BorderStyle.FixedSingle; }
				if (c is NumericUpDown num) { num.BorderStyle = BorderStyle.FixedSingle; }
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

			// Thay thế màu Aqua/Vàng cũ bằng màu xám nhạt hiện đại
			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
			dgv.RowsDefaultCellStyle.BackColor = Color.White;
		}





		private void dgvLoaiPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow == null) return;
            DataGridViewRow row = dgvLoaiPhong.CurrentRow;

            txtMaLP.Text = row.Cells["MaLoai"].Value?.ToString();
            txtTenLP.Text = row.Cells["TenLoai"].Value?.ToString();
            numSoNguoi.Value = Convert.ToInt32(row.Cells["SoNguoiToiDa"].Value?.ToString());
            txtGia.Text = row.Cells["GiaMacDinh"].Value?.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLP.Text) || string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Không được bỏ trống thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                txtTenLP.Focus();
                return;
            }
            int.TryParse(txtMaLP.Text, out int MLP);
            if (db.Loaiphongs.Any(x => x.MaLoai == MLP))
            {
                MessageBox.Show("Đã tồn tại loại phòng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLP.Focus();
                return;
            }

            Loaiphong b = new Loaiphong
            {
                TenLoai = txtTenLP.Text.Trim(),
                SoNguoiToiDa = Convert.ToInt32(numSoNguoi.Value),
                GiaMacDinh = Convert.ToInt32(txtGia.Text.Trim())
            };

            db.Loaiphongs.Add(b);
            db.SaveChanges();

            LamMoi();

            MessageBox.Show("Thêm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLP.Text == "Tự động tạo")
            {
                MessageBox.Show("Vui lòng chọn loại phòng muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int.TryParse(txtMaLP.Text, out int MLP);
            Loaiphong? lp = db.Loaiphongs.FirstOrDefault(lp => lp.MaLoai == MLP);
            if (lp == null)
            {
                MessageBox.Show("Không tìm thấy loại phòng",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            lp.TenLoai = txtTenLP.Text.Trim();
            lp.SoNguoiToiDa = Convert.ToInt32(numSoNguoi.Value);
            lp.GiaMacDinh = Convert.ToDecimal(txtGia.Text.Trim());

            db.SaveChanges();
            LamMoi();

            MessageBox.Show("Cập nhật thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLP.Text == "Tự động tạo")
            {
                MessageBox.Show("Vui lòng chọn loại phòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int.TryParse(txtMaLP.Text, out int MLP);

            // Kiểm tra FK: Có phòng nào thuộc loại phòng này không
            if (db.Phongs.Any(p => p.MaLoai == MLP))
            {
                MessageBox.Show($"Không thể xóa! Vẫn còn phòng thuộc loại phòng '{txtTenLP.Text}'",
                    "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            var cf = MessageBox.Show($"Xóa loại phòng '{txtTenLP.Text}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf != DialogResult.Yes) return;

            Loaiphong? lp = db.Loaiphongs.FirstOrDefault(lp => lp.MaLoai == MLP);
            if (lp != null) { db.Loaiphongs.Remove(lp); db.SaveChanges(); }

            LamMoi();

            MessageBox.Show("Xóa thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
