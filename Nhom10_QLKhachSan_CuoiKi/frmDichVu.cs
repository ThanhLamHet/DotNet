using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nhom10_QLKhachSan_CuoiKi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;


namespace Nhom10_QLKhachSan_CuoiKi
{
	public partial class frmDichVu : Form
	{
		private QLKhachSanContext db = new QLKhachSanContext();
		public frmDichVu()
		{
			InitializeComponent();
		}
		private void frmDichVu_Load(object sender, EventArgs e)
		{
			ApplyModernUI();

			// Khóa ô Mã DV không cho nhập tay (thường là mã tự tăng)
			txtMaDV.ReadOnly = true;
			txtMaDV.BackColor = Color.WhiteSmoke;

			LoadDichVu();
		}
		private void ApplyModernUI()
		{
			this.BackColor = Color.White;
			this.Font = new Font("Segoe UI", 10);

			// Tùy chỉnh màu sắc các nút bấm
			if (this.Controls.Find("btnThem", true).FirstOrDefault() is Button btnThem)
				StyleButton(btnThem, Color.FromArgb(34, 197, 94), Color.White); // Xanh lá

			if (this.Controls.Find("btnSua", true).FirstOrDefault() is Button btnSua)
				StyleButton(btnSua, Color.FromArgb(245, 158, 11), Color.White); // Cam

			if (this.Controls.Find("btnXoa", true).FirstOrDefault() is Button btnXoa)
				StyleButton(btnXoa, Color.FromArgb(239, 68, 68), Color.White);  // Đỏ

			if (this.Controls.Find("btnLamMoi", true).FirstOrDefault() is Button btnLamMoi)
				StyleButton(btnLamMoi, Color.FromArgb(71, 85, 105), Color.White); // Xám

			if (this.Controls.Find("btnTim", true).FirstOrDefault() is Button btnTim)
				StyleButton(btnTim, Color.FromArgb(30, 58, 138), Color.White); // Xanh navy

			SetupVisualStyles(this);

			if (this.Controls.Find("dgvDichVu", true).FirstOrDefault() is DataGridView dgv)
				StyleDataGridView(dgv);
		}

		private void SetupVisualStyles(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is TextBox txt) txt.BorderStyle = BorderStyle.FixedSingle;
				if (c is ComboBox cbo) cbo.FlatStyle = FlatStyle.Flat;
				if (c is GroupBox gb)
				{
					gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
					gb.ForeColor = Color.FromArgb(30, 58, 138);
				}

				if (c.HasChildren)
				{
					SetupVisualStyles(c);
				}
			}
		}

		private void StyleButton(Button btn, Color backColor, Color foreColor)
		{
			btn.FlatStyle = FlatStyle.Flat;
			btn.BackColor = backColor;
			btn.ForeColor = foreColor;
			btn.FlatAppearance.BorderSize = 0;
			btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
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

			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			dgv.ColumnHeadersHeight = 40;

			dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
			dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
			dgv.RowTemplate.Height = 35;
			dgv.GridColor = Color.FromArgb(241, 245, 249);
			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
		}
		private void LoadDichVu()
		{
			var ds = db.Dichvus
				.Select(dv => new
				{
					dv.MaDv,
					dv.TenDv,
					dv.GiaDv,
					dv.DonViTinh
				})
				.ToList();

			dgvDichVu.DataSource = ds;
		}

		private void ClearInput()
		{
			txtMaDV.Clear();
			txtTenDV.Clear();
			txtGiaDV.Clear();
			txtDonViTinh.Clear();
			txtTimKiem.Clear();
			txtTenDV.Focus();
		}

		private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				txtMaDV.Text = dgvDichVu.Rows[e.RowIndex].Cells["MaDv"].Value?.ToString();
				txtTenDV.Text = dgvDichVu.Rows[e.RowIndex].Cells["TenDv"].Value?.ToString();
				txtGiaDV.Text = dgvDichVu.Rows[e.RowIndex].Cells["GiaDv"].Value?.ToString();
				txtDonViTinh.Text = dgvDichVu.Rows[e.RowIndex].Cells["DonViTinh"].Value?.ToString();
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTenDV.Text))
			{
				MessageBox.Show("Vui lòng nhập tên dịch vụ.");
				txtTenDV.Focus();
				return;
			}

			if (!decimal.TryParse(txtGiaDV.Text, out decimal gia) || gia < 0)
			{
				MessageBox.Show("Giá dịch vụ không hợp lệ.");
				txtGiaDV.Focus();
				return;
			}

			var dv = new Dichvu
			{
				TenDv = txtTenDV.Text.Trim(),
				GiaDv = gia,
				DonViTinh = txtDonViTinh.Text.Trim()
			};

			db.Dichvus.Add(dv);
			db.SaveChanges();

			MessageBox.Show("Thêm dịch vụ thành công.");
			LoadDichVu();
			ClearInput();

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaDV.Text))
			{
				MessageBox.Show("Vui lòng chọn dịch vụ cần sửa.");
				return;
			}

			if (!int.TryParse(txtMaDV.Text, out int maDV))
			{
				MessageBox.Show("Mã dịch vụ không hợp lệ.");
				return;
			}

			var dv = db.Dichvus.FirstOrDefault(x => x.MaDv == maDV);
			if (dv == null)
			{
				MessageBox.Show("Không tìm thấy dịch vụ.");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtTenDV.Text))
			{
				MessageBox.Show("Vui lòng nhập tên dịch vụ.");
				txtTenDV.Focus();
				return;
			}

			if (!decimal.TryParse(txtGiaDV.Text, out decimal gia) || gia < 0)
			{
				MessageBox.Show("Giá dịch vụ không hợp lệ.");
				txtGiaDV.Focus();
				return;
			}

			dv.TenDv = txtTenDV.Text.Trim();
			dv.GiaDv = gia;
			dv.DonViTinh = txtDonViTinh.Text.Trim();

			db.SaveChanges();

			MessageBox.Show("Sửa dịch vụ thành công.");
			LoadDichVu();
			ClearInput();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaDV.Text))
			{
				MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.");
				return;
			}

			if (!int.TryParse(txtMaDV.Text, out int maDV))
			{
				MessageBox.Show("Mã dịch vụ không hợp lệ.");
				return;
			}

			var dv = db.Dichvus.FirstOrDefault(x => x.MaDv == maDV);
			if (dv == null)
			{
				MessageBox.Show("Không tìm thấy dịch vụ.");
				return;
			}

			bool daSuDung = db.SudungDvs.Any(x => x.MaDv == maDV);
			if (daSuDung)
			{
				MessageBox.Show("Dịch vụ này đã phát sinh trong đơn, không thể xóa.");
				return;
			}

			var hoi = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (hoi == DialogResult.Yes)
			{
				db.Dichvus.Remove(dv);
				db.SaveChanges();

				MessageBox.Show("Xóa thành công.");
				LoadDichVu();
				ClearInput();
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string tuKhoa = txtTimKiem.Text.Trim().ToLower();

			var ds = db.Dichvus
				.Where(x => x.TenDv.ToLower().Contains(tuKhoa))
				.Select(dv => new
				{
					dv.MaDv,
					dv.TenDv,
					dv.GiaDv,
					dv.DonViTinh
				})
				.ToList();

			dgvDichVu.DataSource = ds;
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			ClearInput();
			LoadDichVu();
		}


	}
}
