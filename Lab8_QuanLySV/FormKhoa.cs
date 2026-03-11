using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab8_QuanLySV.Models;
using Microsoft.EntityFrameworkCore;


namespace Lab8_QuanLySV
{
	public partial class FormKhoa : Form
	{
		private QuanLySvContext db = new QuanLySvContext();
		public FormKhoa()
		{
			InitializeComponent();
		}
		private void FormKhoa_Load(object sender, EventArgs e)
		{
			LoadDSKhoa();
		}

		private void LoadDSKhoa()
		{
			var ds = db.Khoas
				.Select(k => new
				{
					k.MaKhoa,
					TenKhoa = k.TenKhoa.Trim()
				})
				.ToList();

			dgvKhoa.DataSource = ds;

			if (dgvKhoa.Columns.Count > 0)
			{
				dgvKhoa.Columns["MaKhoa"].HeaderText = "Ma Khoa";
				dgvKhoa.Columns["TenKhoa"].HeaderText = "Ten Khoa";
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaKhoa.Text) || string.IsNullOrEmpty(txtTenKhoa.Text))
			{
				MessageBox.Show("Vui long nhap day du thong tin!");
				return;
			}

			if (db.Khoas.Find(txtMaKhoa.Text.Trim()) != null)
			{
				MessageBox.Show("Ma khoa da ton tai!");
				return;
			}

			Khoa k = new Khoa
			{
				MaKhoa = txtMaKhoa.Text.Trim(),
				TenKhoa = txtTenKhoa.Text.Trim()
			};

			db.Khoas.Add(k);
			db.SaveChanges();

			LoadDSKhoa();
			MessageBox.Show("Them khoa thanh cong!");
		}

		private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvKhoa.CurrentRow == null) return;

			DataGridViewRow row = dgvKhoa.CurrentRow;

			txtMaKhoa.Text = row.Cells["MaKhoa"].Value?.ToString();
			txtTenKhoa.Text = row.Cells["TenKhoa"].Value?.ToString();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string ma = txtMaKhoa.Text.Trim();

			if (string.IsNullOrEmpty(ma))
			{
				MessageBox.Show("Vui long chon khoa can sua!");
				return;
			}

			Khoa k = db.Khoas.Find(ma);

			if (k == null)
			{
				MessageBox.Show("Khong tim thay khoa!");
				return;
			}

			k.TenKhoa = txtTenKhoa.Text.Trim();

			db.SaveChanges();
			LoadDSKhoa();

			MessageBox.Show("Cap nhat thanh cong!");
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string ma = txtMaKhoa.Text.Trim();

			if (string.IsNullOrEmpty(ma))
			{
				MessageBox.Show("Vui long chon khoa can xoa!");
				return;
			}

			var cf = MessageBox.Show(
				$"Xoa khoa: {txtTenKhoa.Text} ?",
				"Xac nhan xoa",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (cf != DialogResult.Yes) return;

			Khoa k = db.Khoas.Find(ma);

			if (k != null)
				db.Khoas.Remove(k);

			db.SaveChanges();
			LoadDSKhoa();

			MessageBox.Show("Xoa thanh cong!");
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LamMoiForm();
			LoadDSKhoa();
		}

		private void LamMoiForm()
		{
			txtMaKhoa.Clear();
			txtTenKhoa.Clear();
			txtTim.Clear();
			txtMaKhoa.Focus();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string kw = txtTim.Text.Trim().ToLower();

			var kq = db.Khoas
				.Where(k => k.MaKhoa.ToLower().Contains(kw) ||
							k.TenKhoa.ToLower().Contains(kw))
				.Select(k => new
				{
					k.MaKhoa,
					TenKhoa = k.TenKhoa.Trim()
				})
				.ToList();

			dgvKhoa.DataSource = kq;
		}
	}
}
