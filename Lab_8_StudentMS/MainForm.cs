using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_8_StudentMS
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void mônToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			// 1. Khởi tạo đối tượng của lớp formSinhVien
			frmSinhVien fSV = new frmSinhVien();

			// 2. Hiển thị form sinh viên
			fSV.Show();
		}

		private void khoaToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			// 1. Khởi tạo đối tượng của lớp formSinhVien
			frmKhoa fk = new frmKhoa();

			// 2. Hiển thị form sinh viên
			fk.Show();
		}

		private void mônToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			// 1. Khởi tạo đối tượng của lớp formSinhVien
			FormMonHoc fmh = new FormMonHoc();

			// 2. Hiển thị form sinh viên
			fmh.Show();
		}

		private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// 1. Khởi tạo đối tượng của lớp formSinhVien
			FrmKetQua fkq = new FrmKetQua();

			// 2. Hiển thị form sinh viên
			fkq.Show();
		}
	}
}
