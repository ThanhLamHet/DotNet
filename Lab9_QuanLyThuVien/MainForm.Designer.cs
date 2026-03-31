namespace Lab9_QuanLyThuVien
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			menuStrip1 = new MenuStrip();
			toolStrip1 = new ToolStrip();
			tsbQLNV = new ToolStripButton();
			tsbBangCap = new ToolStripButton();
			tsbSach = new ToolStripButton();
			tsbDocGia = new ToolStripButton();
			tsbMuonSach = new ToolStripButton();
			tsbThuTien = new ToolStripButton();
			tsbBaoCao = new ToolStripButton();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1107, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = SystemColors.Control;
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbQLNV, tsbBangCap, tsbSach, tsbDocGia, tsbMuonSach, tsbThuTien, tsbBaoCao });
			toolStrip1.Location = new Point(0, 24);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1107, 27);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbQLNV
			// 
			tsbQLNV.Image = (Image)resources.GetObject("tsbQLNV.Image");
			tsbQLNV.ImageTransparentColor = Color.Magenta;
			tsbQLNV.Name = "tsbQLNV";
			tsbQLNV.Size = new Size(157, 24);
			tsbQLNV.Text = "Quản Lý Nhân Viên";
			tsbQLNV.Click += toolStripButton1_Click;
			// 
			// tsbBangCap
			// 
			tsbBangCap.Image = (Image)resources.GetObject("tsbBangCap.Image");
			tsbBangCap.ImageTransparentColor = Color.Magenta;
			tsbBangCap.Name = "tsbBangCap";
			tsbBangCap.Size = new Size(97, 24);
			tsbBangCap.Text = "Bằng Cấp";
			tsbBangCap.Click += tsbBangCap_Click;
			// 
			// tsbSach
			// 
			tsbSach.Image = (Image)resources.GetObject("tsbSach.Image");
			tsbSach.ImageTransparentColor = Color.Magenta;
			tsbSach.Name = "tsbSach";
			tsbSach.Size = new Size(64, 24);
			tsbSach.Text = "Sách";
			tsbSach.Click += tsbSach_Click;
			// 
			// tsbDocGia
			// 
			tsbDocGia.Image = (Image)resources.GetObject("tsbDocGia.Image");
			tsbDocGia.ImageTransparentColor = Color.Magenta;
			tsbDocGia.Name = "tsbDocGia";
			tsbDocGia.Size = new Size(86, 24);
			tsbDocGia.Text = "Độc Giả";
			tsbDocGia.Click += tsbDocGia_Click;
			// 
			// tsbMuonSach
			// 
			tsbMuonSach.Image = (Image)resources.GetObject("tsbMuonSach.Image");
			tsbMuonSach.ImageTransparentColor = Color.Magenta;
			tsbMuonSach.Name = "tsbMuonSach";
			tsbMuonSach.Size = new Size(107, 24);
			tsbMuonSach.Text = "Mượn Sách";
			tsbMuonSach.Click += tsbMuonSach_Click;
			// 
			// tsbThuTien
			// 
			tsbThuTien.Image = (Image)resources.GetObject("tsbThuTien.Image");
			tsbThuTien.ImageTransparentColor = Color.Magenta;
			tsbThuTien.Name = "tsbThuTien";
			tsbThuTien.Size = new Size(89, 24);
			tsbThuTien.Text = "Thu Tiền";
			tsbThuTien.Click += tsbThuTien_Click;
			// 
			// tsbBaoCao
			// 
			tsbBaoCao.Image = (Image)resources.GetObject("tsbBaoCao.Image");
			tsbBaoCao.ImageTransparentColor = Color.Magenta;
			tsbBaoCao.Name = "tsbBaoCao";
			tsbBaoCao.Size = new Size(89, 24);
			tsbBaoCao.Text = "Báo Cáo";
			tsbBaoCao.Click += tsbBaoCao_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.wood_background;
			ClientSize = new Size(1107, 625);
			Controls.Add(toolStrip1);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			Text = "Main";
			Load += MainForm_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}



		#endregion

		private MenuStrip menuStrip1;
		private ToolStrip toolStrip1;
		private ToolStripButton tsbQLNV;
		private ToolStripButton tsbBangCap;
		private ToolStripButton tsbSach;
		private ToolStripButton tsbDocGia;
		private ToolStripButton tsbMuonSach;
		private ToolStripButton tsbThuTien;
		private ToolStripButton tsbBaoCao;
	}
}
