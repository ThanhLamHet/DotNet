using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab8_QuanLySV
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}


		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void tsbTTSinhVien_Click(object sender, EventArgs e)
		{
			Form1 fsv = new Form1();
			fsv.Show();
		}

		private void tsbKhoa_Click(object sender, EventArgs e)
		{
			FormKhoa fk = new FormKhoa();
			fk.Show();

		}

		private void tsbMon_Click(object sender, EventArgs e)
		{
			FormMon fm = new FormMon();
			fm.Show();
		}
		

		private void tsbKetQua_Click(object sender, EventArgs e)
		{
			FormKetQua fkq = new FormKetQua();
			fkq.Show();
		}
	}
}
