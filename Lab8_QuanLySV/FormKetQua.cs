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
	public partial class FormKetQua : Form
	{
		private QuanLySvContext db = new QuanLySvContext();
		public FormKetQua()
		{
			InitializeComponent();
		}

		private void FormKetQua_Load(object sender, EventArgs e)
		{
			LoadcbSinhVien();
			LoadcbMon();
			LoadDSKetQua();
		}
		private void LoadcbSinhVien()
		{
			cbSinhVien.DataSource = db.SinhViens.ToList();
			cbSinhVien.DisplayMember = "HoTen";
			cbSinhVien.ValueMember = "MaSo";
		}

		private void LoadcbMon()
		{
			cbMon.DataSource = db.Mons.ToList();
			cbMon.DisplayMember = "TenMh";
			cbMon.ValueMember = "MaMh";
		}

		private void LoadDSKetQua()
		{
			var ds = db.KetQuas
				.Include(kq => kq.MaSoNavigation)
				.Include(kq => kq.MaMhNavigation)
				.Select(kq => new
				{
					kq.MaSo,
					HoTen = kq.MaSoNavigation.HoTen,
					kq.MaMh,
					TenMon = kq.MaMhNavigation.TenMh.Trim(),
					kq.Diem
				})
				.ToList();

			dgvKetQua.DataSource = ds;

			if (dgvKetQua.Columns.Count > 0)
			{
				dgvKetQua.Columns["MaSo"].HeaderText = "Ma SV";
				dgvKetQua.Columns["HoTen"].HeaderText = "Ho Ten";
				dgvKetQua.Columns["MaMh"].HeaderText = "Ma Mon";
				dgvKetQua.Columns["TenMon"].HeaderText = "Ten Mon";
				dgvKetQua.Columns["Diem"].HeaderText = "Diem";
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtDiem.Text, out int diem))
			{
				MessageBox.Show("Diem phai la so!");
				return;
			}

			int maSo = (int)cbSinhVien.SelectedValue;
			string maMh = cbMon.SelectedValue.ToString();

			var check = db.KetQuas.Find(maSo, maMh);

			if (check != null)
			{
				MessageBox.Show("Sinh vien da co diem mon nay!");
				return;
			}

			KetQua kq = new KetQua
			{
				MaSo = maSo,
				MaMh = maMh,
				Diem = diem
			};

			db.KetQuas.Add(kq);
			db.SaveChanges();

			LoadDSKetQua();
			MessageBox.Show("Them diem thanh cong!");
		}

		private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvKetQua.CurrentRow == null) return;

			DataGridViewRow row = dgvKetQua.CurrentRow;

			cbSinhVien.SelectedValue = row.Cells["MaSo"].Value;
			cbMon.SelectedValue = row.Cells["MaMh"].Value;
			txtDiem.Text = row.Cells["Diem"].Value.ToString();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtDiem.Text, out int diem))
			{
				MessageBox.Show("Diem phai la so!");
				return;
			}

			int maSo = (int)cbSinhVien.SelectedValue;
			string maMh = cbMon.SelectedValue.ToString();

			KetQua kq = db.KetQuas.Find(maSo, maMh);

			if (kq == null)
			{
				MessageBox.Show("Khong tim thay!");
				return;
			}

			kq.Diem = diem;

			db.SaveChanges();
			LoadDSKetQua();

			MessageBox.Show("Cap nhat diem thanh cong!");
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int maSo = (int)cbSinhVien.SelectedValue;
			string maMh = cbMon.SelectedValue.ToString();

			var cf = MessageBox.Show(
				"Xoa ket qua nay?",
				"Xac nhan",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (cf != DialogResult.Yes) return;

			KetQua kq = db.KetQuas.Find(maSo, maMh);

			if (kq != null)
				db.KetQuas.Remove(kq);

			db.SaveChanges();
			LoadDSKetQua();

			MessageBox.Show("Xoa thanh cong!");
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LamMoiForm();
			LoadDSKetQua();
		}

		private void LamMoiForm()
		{
			txtDiem.Clear();
			txtTim.Clear();

			if (cbSinhVien.Items.Count > 0)
				cbSinhVien.SelectedIndex = 0;

			if (cbMon.Items.Count > 0)
				cbMon.SelectedIndex = 0;
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string kw = txtTim.Text.Trim().ToLower();

			var kq = db.KetQuas
				.Include(k => k.MaSoNavigation)
				.Include(k => k.MaMhNavigation)
				.Where(k =>
					k.MaSoNavigation.HoTen.ToLower().Contains(kw) ||
					k.MaMhNavigation.TenMh.ToLower().Contains(kw))
				.Select(k => new
				{
					k.MaSo,
					HoTen = k.MaSoNavigation.HoTen,
					k.MaMh,
					TenMon = k.MaMhNavigation.TenMh.Trim(),
					k.Diem
				})
				.ToList();

			dgvKetQua.DataSource = kq;
		}
	}
}
