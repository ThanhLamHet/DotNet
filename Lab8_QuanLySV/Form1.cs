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
	public partial class Form1 : Form
	{
		private QuanLySvContext db = new QuanLySvContext();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadcbGioiTinh();
			LoadcbMaKhoa();
			LoadDSSV();
		}
		private void LoadDSSV()
		{
			var ds = db.SinhViens.Include(sv => sv.MaKhoaNavigation).Select(sv => new
			{
				sv.MaSo,
				sv.HoTen,
				NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
				GioiTinh = sv.GioiTinh == true ? "Nam" : "Nu",
				sv.DiaChi,
				sv.DienThoai,
				TenKhoa = sv.MaKhoaNavigation != null ? sv.MaKhoaNavigation.TenKhoa.Trim() : ""
			}).ToList();

			dgvSinhVien.DataSource = ds;
			if (dgvSinhVien.Columns.Count > 0)
			{
				dgvSinhVien.Columns["MaSo"].HeaderText = "Ma so";
				dgvSinhVien.Columns["HoTen"].HeaderText = "Ho ten";
				dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngay sinh";
				dgvSinhVien.Columns["GioiTinh"].HeaderText = "Gioi tinh";
				dgvSinhVien.Columns["DiaChi"].HeaderText = "Dia chi";
				dgvSinhVien.Columns["DienThoai"].HeaderText = "SDT";
				dgvSinhVien.Columns["TenKhoa"].HeaderText = "Khoa";
			}
		}

		private void LoadcbMaKhoa()
		{
			cbMaKhoa.DataSource = db.Khoas.ToList();
			cbMaKhoa.DisplayMember = "TenKhoa";
			cbMaKhoa.ValueMember = "MaKhoa";
		}

		private void LoadcbGioiTinh()
		{
			cbGioiTinh.Items.Clear();
			cbGioiTinh.Items.Add("Nam");
			cbGioiTinh.Items.Add("Nu");
			cbGioiTinh.SelectedIndex = 0;
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtHoTen.Text))
			{
				MessageBox.Show("Vui long nhap ho ten!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtHoTen.Focus();
				return;
			}
			SinhVien newSV = new SinhVien
			{
				HoTen = txtHoTen.Text.Trim(),
				NgaySinh = dtpNgaySinh.Value,
				GioiTinh = cbGioiTinh.SelectedItem.ToString() == "Nam",
				DiaChi = txtDiaChi.Text.Trim(),
				DienThoai = int.TryParse(txtSDT.Text, out int sdt) ? sdt : null,
				MaKhoa = cbMaKhoa.SelectedValue?.ToString()
			};
			db.SinhViens.Add(newSV);
			db.SaveChanges();

			LoadDSSV();
			MessageBox.Show("Them sinh vien thanh cong!");
		}

		private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvSinhVien.CurrentRow == null) return;
			DataGridViewRow row = dgvSinhVien.CurrentRow;

			txtMaSo.Text = row.Cells["MaSo"].Value?.ToString();
			txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
			txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
			txtSDT.Text = row.Cells["DienThoai"].Value?.ToString();

			string? ns = row.Cells["NgaySinh"].Value?.ToString();
			if (DateTime.TryParseExact(ns, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngay))
				dtpNgaySinh.Value = ngay;

			cbGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString() == "Nam" ? "Nam" : "Nu";

			string tenKhoa = row.Cells["TenKhoa"].Value?.ToString().Trim();
			foreach (Khoa k in cbMaKhoa.Items)
			{
				if (k.TenKhoa.Trim() == tenKhoa)
				{
					cbMaKhoa.SelectedItem = k;
					break;
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtMaSo.Text, out int MaSo))
			{
				MessageBox.Show("Vui long chon sinh vien can sua!");
				return;
			}

			SinhVien? sv = db.SinhViens.Find(MaSo);

			if (sv == null)
			{
				MessageBox.Show("Khong tim thay!");
				return;
			}

			sv.HoTen = txtHoTen.Text.Trim();
			sv.NgaySinh = dtpNgaySinh.Value;
			sv.GioiTinh = cbGioiTinh.SelectedItem.ToString() == "Nam";
			sv.DiaChi = txtDiaChi.Text.Trim();
			sv.DienThoai = int.TryParse(txtSDT.Text, out int sdt) ? sdt : null;
			sv.MaKhoa = cbMaKhoa.SelectedValue?.ToString();

			db.SaveChanges();
			LoadDSSV();
			MessageBox.Show("Cap nhat thanh cong!");
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtMaSo.Text, out int MaSo))
			{
				MessageBox.Show("Vui long chon sinh vien can xoa!");
				return;
			}
			var cf = MessageBox.Show($"Xoa sinh vien: {txtHoTen.Text}?\nLuu y: Diem cua SV nay cung se bi xoa", "Xac nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (cf != DialogResult.Yes) return;

			//Xoa ket qua
			var kqs = db.KetQuas.Where(kq => kq.MaSo == MaSo).ToList();
			db.KetQuas.RemoveRange(kqs);

			SinhVien sv = db.SinhViens.Find(MaSo);
			if (sv != null) db.SinhViens.Remove(sv);

			db.SaveChanges();
			LoadDSSV();
			MessageBox.Show("Xoa sinh vien thanh cong!");
		}

		private void LamMoiForm()
		{
			txtMaSo.Clear();
			txtHoTen.Clear();
			txtHoTen.Focus();
			dtpNgaySinh.Value = DateTime.Now;
			cbGioiTinh.SelectedIndex = 0;
			txtDiaChi.Clear();
			txtSDT.Clear();
			if (cbMaKhoa.Items.Count > 0) cbMaKhoa.SelectedIndex = 0;
			txtTim.Clear();
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LamMoiForm();
			LoadDSSV();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string kw = txtTim.Text.Trim().ToLower();
			var kq = db.SinhViens.Where(sv => sv.HoTen.ToLower().Contains(kw) || (sv.DiaChi != null && sv.DiaChi.ToLower().Contains(kw))).Include(sv => sv.MaKhoaNavigation).Select(sv => new
			{
				sv.MaSo,
				sv.HoTen,
				NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
				GioiTinh = sv.GioiTinh == true ? "Nam" : "Nu",
				sv.DiaChi,
				sv.DienThoai,
				TenKhoa = sv.MaKhoaNavigation != null ? sv.MaKhoaNavigation.TenKhoa.Trim() : ""
			}).ToList();

			dgvSinhVien.DataSource = kq;
		}

	}
}
