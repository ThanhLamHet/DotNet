using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Nhom10_QLKhachSan_CuoiKi.Models;

namespace Nhom10_QLKhachSan_CuoiKi
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		private void OpenChildForm(Form childForm)
		{
			// 1. Tìm xem form này đã mở chưa
			Form existingForm = this.MdiChildren.FirstOrDefault(f => f.GetType() == childForm.GetType());

			if (existingForm != null)
			{
				// Nếu đã mở và đang bị thu nhỏ (icon), hãy đưa nó về trạng thái bình thường
				if (existingForm.WindowState == FormWindowState.Minimized)
				{
					existingForm.WindowState = FormWindowState.Normal;
				}

				existingForm.Activate(); // Đưa lên trên cùng
			}
			else
			{
				// 2. Nếu chưa mở, thiết lập thuộc tính để nó nằm trong form cha
				childForm.MdiParent = this;

				// Đặt trạng thái Normal để người dùng có thể kéo, thu nhỏ/phóng to tùy ý
				childForm.WindowState = FormWindowState.Normal;

				// Đặt vị trí xuất hiện ở giữa vùng làm việc của form cha
				childForm.StartPosition = FormStartPosition.CenterScreen;

				childForm.Show();
			}
		}
		private void tsbKhachHang_Click(object sender, EventArgs e) => OpenChildForm(new frmKhachHang());
		private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmKhachHang());

		private void tsbNhanVien_Click(object sender, EventArgs e) => OpenChildForm(new frmNhanVien());
		private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmNhanVien());

		private void tsbKhuyenMai_Click(object sender, EventArgs e) => OpenChildForm(new frmKhuyenMai());
		private void khuyếnMãiToolStripMenuItem1_Click(object sender, EventArgs e) => OpenChildForm(new frmKhuyenMai());

		private void tsbLoaiPhong_Click(object sender, EventArgs e) => OpenChildForm(new frmLoaiPhong());
		private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmLoaiPhong());

		private void tsbPhong_Click(object sender, EventArgs e) => OpenChildForm(new frmPhong());
		private void phòngToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmPhong());

		private void tsbTaoDon_Click(object sender, EventArgs e) => OpenChildForm(new frmTaoDon());
		private void tạoĐơnToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmTaoDon());

		private void tsbXemDon_Click(object sender, EventArgs e) => OpenChildForm(new frmXemDon());
		private void xemĐơnToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmXemDon());

		private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmDichVu());
		private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmThemHuyDichVu());

		private void ThanhToanToolStripMenuItem1_Click(object sender, EventArgs e) => OpenChildForm(new frmThanhToan());
		private void báoCáoToolStripMenuItem2_Click(object sender, EventArgs e) => OpenChildForm(new frmBaoCao());

		// Khi bấm nút thoát trên thanh Menu / Toolstrip -> Gọi lệnh đóng form cha
		private void tsbThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Hiển thị hộp thoại hỏi người dùng
			DialogResult result = MessageBox.Show(
				"Bạn có chắc chắn muốn thoát chương trình không?",
				"Xác nhận thoát",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			// Nếu người dùng chọn No (Không), thì hủy lệnh đóng form
			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
	


		}

		private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Bắt sự kiện form cha đang đóng (Bấm nút X màu đỏ hoặc gọi this.Close())




		private void menuCascade_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.Cascade);
		private void menuHorizontal_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileHorizontal);
		private void menuVertical_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileVertical);

		// Các sự kiện trống chưa dùng tới
		private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e) { }
		private void GiaoDichToolStripMenuItem_Click(object sender, EventArgs e) { }

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
