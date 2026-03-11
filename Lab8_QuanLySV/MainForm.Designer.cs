namespace Lab8_QuanLySV
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			menuStrip1 = new MenuStrip();
			hệThốngToolStripMenuItem = new ToolStripMenuItem();
			chứcNăngToolStripMenuItem = new ToolStripMenuItem();
			hỗTrợToolStripMenuItem = new ToolStripMenuItem();
			toolStrip1 = new ToolStrip();
			tsbTTSinhVien = new ToolStripButton();
			tsbKhoa = new ToolStripButton();
			tsbMon = new ToolStripButton();
			tsbKetQua = new ToolStripButton();
			menuStrip1.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.Transparent;
			menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, chứcNăngToolStripMenuItem, hỗTrợToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 31);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			hệThốngToolStripMenuItem.Size = new Size(101, 27);
			hệThốngToolStripMenuItem.Text = "Hệ thống";
			// 
			// chứcNăngToolStripMenuItem
			// 
			chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			chứcNăngToolStripMenuItem.Size = new Size(114, 27);
			chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// hỗTrợToolStripMenuItem
			// 
			hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
			hỗTrợToolStripMenuItem.Size = new Size(80, 27);
			hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = Color.Transparent;
			toolStrip1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbTTSinhVien, tsbKhoa, tsbMon, tsbKetQua });
			toolStrip1.Location = new Point(0, 31);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 26);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbTTSinhVien
			// 
			tsbTTSinhVien.DisplayStyle = ToolStripItemDisplayStyle.Text;
			tsbTTSinhVien.Image = (Image)resources.GetObject("tsbTTSinhVien.Image");
			tsbTTSinhVien.ImageTransparentColor = Color.Magenta;
			tsbTTSinhVien.Name = "tsbTTSinhVien";
			tsbTTSinhVien.Size = new Size(162, 23);
			tsbTTSinhVien.Text = "Thông Tin Sinh Viên";
			tsbTTSinhVien.Click += tsbTTSinhVien_Click;
			// 
			// tsbKhoa
			// 
			tsbKhoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
			tsbKhoa.Image = (Image)resources.GetObject("tsbKhoa.Image");
			tsbKhoa.ImageTransparentColor = Color.Magenta;
			tsbKhoa.Name = "tsbKhoa";
			tsbKhoa.Size = new Size(51, 23);
			tsbKhoa.Text = "Khoa";
			tsbKhoa.Click += tsbKhoa_Click;
			// 
			// tsbMon
			// 
			tsbMon.DisplayStyle = ToolStripItemDisplayStyle.Text;
			tsbMon.Image = (Image)resources.GetObject("tsbMon.Image");
			tsbMon.ImageTransparentColor = Color.Magenta;
			tsbMon.Name = "tsbMon";
			tsbMon.Size = new Size(47, 23);
			tsbMon.Text = "Môn";
			tsbMon.Click += tsbMon_Click;
			// 
			// tsbKetQua
			// 
			tsbKetQua.DisplayStyle = ToolStripItemDisplayStyle.Text;
			tsbKetQua.Image = (Image)resources.GetObject("tsbKetQua.Image");
			tsbKetQua.ImageTransparentColor = Color.Magenta;
			tsbKetQua.Name = "tsbKetQua";
			tsbKetQua.Size = new Size(69, 23);
			tsbKetQua.Text = "Kết quả";
			tsbKetQua.Click += tsbKetQua_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 192, 192);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(800, 450);
			Controls.Add(toolStrip1);
			Controls.Add(menuStrip1);
			DoubleBuffered = true;
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem hệThốngToolStripMenuItem;
		private ToolStripMenuItem chứcNăngToolStripMenuItem;
		private ToolStripMenuItem hỗTrợToolStripMenuItem;
		private ToolStrip toolStrip1;
		private ToolStripButton tsbTTSinhVien;
		private ToolStripButton tsbKhoa;
		private ToolStripButton tsbMon;
		private ToolStripButton tsbKetQua;
	}
}