using Lab9_QuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Lab9_QuanLyThuVien
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
		private void MoFormCon(Form f)
		{
			// Tìm xem Form này đã mở chưa
			Form frm = Application.OpenForms[f.Name];

			if (frm == null)
			{
				// QUAN TRỌNG: Gán form cha là chính MainForm này
				f.MdiParent = this;
				f.Show();
			}
			else
			{
				frm.Activate();
			}
		}
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			MoFormCon(new frmNhanVien());
		}

		private void tsbBangCap_Click(object sender, EventArgs e)
		{
			MoFormCon(new frmBangCap());
		}

		private void tsbSach_Click(object sender, EventArgs e)
		{
			MoFormCon(new FrmSach());
		}

		private void tsbDocGia_Click(object sender, EventArgs e)
		{
			MoFormCon(new frmDocGia());
		}

		private void tsbMuonSach_Click(object sender, EventArgs e)
		{
			MoFormCon(new frmMuonSach());
		}

		private void tsbThuTien_Click(object sender, EventArgs e)
		{
			MoFormCon(new frmThuTien());
		}

		private void tsbBaoCao_Click(object sender, EventArgs e)
		{
			MoFormCon(new frmBaoCao());
		}
	}
}
