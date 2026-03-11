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
	public partial class FormMon : Form
	{
		private QuanLySvContext db = new QuanLySvContext();
		public FormMon()
		{
			InitializeComponent();
		}

		private void FormMon_Load(object sender, EventArgs e)
		{
			LoadDSMon();
		}
		private void LoadDSMon()
		{
			var ds = db.Mons
				.Select(m => new
				{
					MaMon = m.MaMh,
					TenMon = m.TenMh.Trim(),
					m.SoTiet
				})
				.ToList();

			dgvMon.DataSource = ds;

			if (dgvMon.Columns.Count > 0)
			{
				dgvMon.Columns["MaMon"].HeaderText = "Ma Mon";
				dgvMon.Columns["TenMon"].HeaderText = "Ten Mon";
				dgvMon.Columns["SoTiet"].HeaderText = "So Tiet";
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaMon.Text) || string.IsNullOrEmpty(txtTenMon.Text))
			{
				MessageBox.Show("Vui long nhap day du thong tin!");
				return;
			}

			if (!int.TryParse(txtSoTiet.Text, out int soTiet))
			{
				MessageBox.Show("So tiet phai la so!");
				return;
			}

			if (db.Mons.Find(txtMaMon.Text.Trim()) != null)
			{
				MessageBox.Show("Ma mon da ton tai!");
				return;
			}

			Mon m = new Mon
			{
				MaMh = txtMaMon.Text.Trim(),
				TenMh = txtTenMon.Text.Trim(),
				SoTiet = soTiet
			};

			db.Mons.Add(m);
			db.SaveChanges();

			LoadDSMon();
			MessageBox.Show("Them mon thanh cong!");
		}

		private void dgvMon_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvMon.CurrentRow == null) return;

			DataGridViewRow row = dgvMon.CurrentRow;

			txtMaMon.Text = row.Cells["MaMon"].Value?.ToString();
			txtTenMon.Text = row.Cells["TenMon"].Value?.ToString();
			txtSoTiet.Text = row.Cells["SoTiet"].Value?.ToString();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string ma = txtMaMon.Text.Trim();

			if (string.IsNullOrEmpty(ma))
			{
				MessageBox.Show("Vui long chon mon can sua!");
				return;
			}

			if (!int.TryParse(txtSoTiet.Text, out int soTiet))
			{
				MessageBox.Show("So tiet phai la so!");
				return;
			}

			Mon m = db.Mons.Find(ma);

			if (m == null)
			{
				MessageBox.Show("Khong tim thay mon!");
				return;
			}

			m.TenMh = txtTenMon.Text.Trim();
			m.SoTiet = soTiet;

			db.SaveChanges();
			LoadDSMon();

			MessageBox.Show("Cap nhat thanh cong!");
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string ma = txtMaMon.Text.Trim();

			if (string.IsNullOrEmpty(ma))
			{
				MessageBox.Show("Vui long chon mon can xoa!");
				return;
			}

			var cf = MessageBox.Show(
				$"Xoa mon: {txtTenMon.Text} ?",
				"Xac nhan xoa",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (cf != DialogResult.Yes) return;

			var kqs = db.KetQuas.Where(kq => kq.MaMh == ma).ToList();
			db.KetQuas.RemoveRange(kqs);

			Mon m = db.Mons.Find(ma);

			if (m != null)
				db.Mons.Remove(m);

			db.SaveChanges();
			LoadDSMon();

			MessageBox.Show("Xoa mon thanh cong!");
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LamMoiForm();
			LoadDSMon();
		}

		private void LamMoiForm()
		{
			txtMaMon.Clear();
			txtTenMon.Clear();
			txtSoTiet.Clear();
			txtTim.Clear();
			txtMaMon.Focus();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string kw = txtTim.Text.Trim().ToLower();

			var kq = db.Mons
				.Where(m => m.MaMh.ToLower().Contains(kw) ||
							m.TenMh.ToLower().Contains(kw))
				.Select(m => new
				{
					MaMon = m.MaMh,
					TenMon = m.TenMh.Trim(),
					m.SoTiet
				})
				.ToList();

			dgvMon.DataSource = kq;
		}
	}
}
