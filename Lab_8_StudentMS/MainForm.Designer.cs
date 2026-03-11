namespace Lab_8_StudentMS
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
			menuStrip1 = new MenuStrip();
			sinhViênToolStripMenuItem = new ToolStripMenuItem();
			sinhViênToolStripMenuItem1 = new ToolStripMenuItem();
			khoaToolStripMenuItem = new ToolStripMenuItem();
			mônToolStripMenuItem = new ToolStripMenuItem();
			nhậpĐiểmToolStripMenuItem = new ToolStripMenuItem();
			xemĐiểmToolStripMenuItem = new ToolStripMenuItem();
			thốngKêKhoaToolStripMenuItem = new ToolStripMenuItem();
			chứcNăngToolStripMenuItem = new ToolStripMenuItem();
			hỗTrợToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { sinhViênToolStripMenuItem, chứcNăngToolStripMenuItem, hỗTrợToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// sinhViênToolStripMenuItem
			// 
			sinhViênToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhViênToolStripMenuItem1, khoaToolStripMenuItem, mônToolStripMenuItem, nhậpĐiểmToolStripMenuItem, xemĐiểmToolStripMenuItem, thốngKêKhoaToolStripMenuItem });
			sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
			sinhViênToolStripMenuItem.Size = new Size(84, 24);
			sinhViênToolStripMenuItem.Text = "Sinh Viên";
			sinhViênToolStripMenuItem.Click += sinhViênToolStripMenuItem_Click;
			// 
			// sinhViênToolStripMenuItem1
			// 
			sinhViênToolStripMenuItem1.Name = "sinhViênToolStripMenuItem1";
			sinhViênToolStripMenuItem1.Size = new Size(224, 26);
			sinhViênToolStripMenuItem1.Text = "Sinh Viên";
			sinhViênToolStripMenuItem1.Click += sinhViênToolStripMenuItem1_Click;
			// 
			// khoaToolStripMenuItem
			// 
			khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
			khoaToolStripMenuItem.Size = new Size(224, 26);
			khoaToolStripMenuItem.Text = "Khoa";
			khoaToolStripMenuItem.Click += khoaToolStripMenuItem_Click_1;
			// 
			// mônToolStripMenuItem
			// 
			mônToolStripMenuItem.Name = "mônToolStripMenuItem";
			mônToolStripMenuItem.Size = new Size(224, 26);
			mônToolStripMenuItem.Text = "Môn Học";
			mônToolStripMenuItem.Click += mônToolStripMenuItem_Click_1;
			// 
			// nhậpĐiểmToolStripMenuItem
			// 
			nhậpĐiểmToolStripMenuItem.Name = "nhậpĐiểmToolStripMenuItem";
			nhậpĐiểmToolStripMenuItem.Size = new Size(224, 26);
			nhậpĐiểmToolStripMenuItem.Text = "Nhập Điểm";
			nhậpĐiểmToolStripMenuItem.Click += nhậpĐiểmToolStripMenuItem_Click;
			// 
			// xemĐiểmToolStripMenuItem
			// 
			xemĐiểmToolStripMenuItem.Name = "xemĐiểmToolStripMenuItem";
			xemĐiểmToolStripMenuItem.Size = new Size(224, 26);
			xemĐiểmToolStripMenuItem.Text = "Xem Điểm";
			// 
			// thốngKêKhoaToolStripMenuItem
			// 
			thốngKêKhoaToolStripMenuItem.Name = "thốngKêKhoaToolStripMenuItem";
			thốngKêKhoaToolStripMenuItem.Size = new Size(224, 26);
			thốngKêKhoaToolStripMenuItem.Text = "Thống Kê Khoa";
			// 
			// chứcNăngToolStripMenuItem
			// 
			chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			chứcNăngToolStripMenuItem.Size = new Size(96, 24);
			chứcNăngToolStripMenuItem.Text = "Chức Năng";
			// 
			// hỗTrợToolStripMenuItem
			// 
			hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
			hỗTrợToolStripMenuItem.Size = new Size(68, 24);
			hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			Text = "MainForm";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem sinhViênToolStripMenuItem;
		private ToolStripMenuItem sinhViênToolStripMenuItem1;
		private ToolStripMenuItem khoaToolStripMenuItem;
		private ToolStripMenuItem mônToolStripMenuItem;
		private ToolStripMenuItem nhậpĐiểmToolStripMenuItem;
		private ToolStripMenuItem xemĐiểmToolStripMenuItem;
		private ToolStripMenuItem thốngKêKhoaToolStripMenuItem;
		private ToolStripMenuItem chứcNăngToolStripMenuItem;
		private ToolStripMenuItem hỗTrợToolStripMenuItem;
	}
}