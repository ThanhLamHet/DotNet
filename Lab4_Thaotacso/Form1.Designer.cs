<<<<<<< HEAD
﻿namespace Lab4_Thaotacso
{
    partial class Form1
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			txtSonguyen = new TextBox();
			btCapnhat = new Button();
			lstKetQua = new ListBox();
			btKetthuc = new Button();
			errSonguyen = new ErrorProvider(components);
			btTang2 = new Button();
			btChonchandau = new Button();
			btLecuoi = new Button();
			btXoaphantudangchon = new Button();
			btXoaphantudau = new Button();
			btXoaphantucuoi = new Button();
			groupBox1 = new GroupBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)errSonguyen).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(250, 249, 199);
			label1.Location = new Point(12, 62);
			label1.Name = "label1";
			label1.Size = new Size(161, 25);
			label1.TabIndex = 0;
			label1.Text = "Nhập Số Nguyên:";
			// 
			// txtSonguyen
			// 
			txtSonguyen.BackColor = Color.FromArgb(229, 229, 241);
			txtSonguyen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			txtSonguyen.ForeColor = Color.FromArgb(40, 40, 76);
			txtSonguyen.Location = new Point(173, 58);
			txtSonguyen.Name = "txtSonguyen";
			txtSonguyen.Size = new Size(441, 31);
			txtSonguyen.TabIndex = 1;
			txtSonguyen.TextChanged += txtSonguyen_TextChanged;
			// 
			// btCapnhat
			// 
			btCapnhat.BackColor = Color.FromArgb(229, 229, 241);
			btCapnhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btCapnhat.ForeColor = Color.FromArgb(40, 40, 76);
			btCapnhat.Location = new Point(661, 55);
			btCapnhat.Name = "btCapnhat";
			btCapnhat.Size = new Size(106, 39);
			btCapnhat.TabIndex = 2;
			btCapnhat.Text = "Cập Nhật";
			btCapnhat.UseVisualStyleBackColor = false;
			btCapnhat.Click += btCapnhat_Click;
			// 
			// lstKetQua
			// 
			lstKetQua.BackColor = Color.FromArgb(229, 229, 241);
			lstKetQua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			lstKetQua.ForeColor = Color.FromArgb(40, 40, 76);
			lstKetQua.FormattingEnabled = true;
			lstKetQua.Location = new Point(12, 122);
			lstKetQua.Name = "lstKetQua";
			lstKetQua.Size = new Size(375, 454);
			lstKetQua.TabIndex = 3;
			// 
			// btKetthuc
			// 
			btKetthuc.BackColor = Color.FromArgb(229, 229, 241);
			btKetthuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btKetthuc.ForeColor = Color.FromArgb(40, 40, 76);
			btKetthuc.Location = new Point(221, 583);
			btKetthuc.Name = "btKetthuc";
			btKetthuc.Size = new Size(367, 42);
			btKetthuc.TabIndex = 12;
			btKetthuc.Text = "Kết thúc";
			btKetthuc.UseVisualStyleBackColor = false;
			btKetthuc.Click += btKetthuc_Click;
			// 
			// errSonguyen
			// 
			errSonguyen.ContainerControl = this;
			// 
			// btTang2
			// 
			btTang2.BackColor = Color.FromArgb(229, 229, 241);
			btTang2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btTang2.ForeColor = Color.FromArgb(40, 40, 76);
			btTang2.Location = new Point(6, 54);
			btTang2.Name = "btTang2";
			btTang2.Size = new Size(367, 42);
			btTang2.TabIndex = 6;
			btTang2.Text = "Tăng Mỗi Phần Tử Lên 2";
			btTang2.UseVisualStyleBackColor = false;
			btTang2.Click += btTang2_Click;
			// 
			// btChonchandau
			// 
			btChonchandau.BackColor = Color.FromArgb(229, 229, 241);
			btChonchandau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btChonchandau.ForeColor = Color.FromArgb(40, 40, 76);
			btChonchandau.Location = new Point(6, 121);
			btChonchandau.Name = "btChonchandau";
			btChonchandau.Size = new Size(367, 42);
			btChonchandau.TabIndex = 7;
			btChonchandau.Text = "Chọn Số Chẵn Đầu";
			btChonchandau.UseVisualStyleBackColor = false;
			btChonchandau.Click += btChonchandau_Click;
			// 
			// btLecuoi
			// 
			btLecuoi.BackColor = Color.FromArgb(229, 229, 241);
			btLecuoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btLecuoi.ForeColor = Color.FromArgb(40, 40, 76);
			btLecuoi.Location = new Point(6, 187);
			btLecuoi.Name = "btLecuoi";
			btLecuoi.Size = new Size(367, 42);
			btLecuoi.TabIndex = 8;
			btLecuoi.Text = "Chọn Số Lẻ Cuối";
			btLecuoi.UseVisualStyleBackColor = false;
			btLecuoi.Click += btLecuoi_Click;
			// 
			// btXoaphantudangchon
			// 
			btXoaphantudangchon.BackColor = Color.FromArgb(229, 229, 241);
			btXoaphantudangchon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btXoaphantudangchon.ForeColor = Color.FromArgb(40, 40, 76);
			btXoaphantudangchon.Location = new Point(6, 251);
			btXoaphantudangchon.Name = "btXoaphantudangchon";
			btXoaphantudangchon.Size = new Size(367, 42);
			btXoaphantudangchon.TabIndex = 9;
			btXoaphantudangchon.Text = "Xóa Phần Tử Đang Chọn";
			btXoaphantudangchon.UseVisualStyleBackColor = false;
			btXoaphantudangchon.Click += btXoaphantudangchon_Click;
			// 
			// btXoaphantudau
			// 
			btXoaphantudau.BackColor = Color.FromArgb(229, 229, 241);
			btXoaphantudau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btXoaphantudau.ForeColor = Color.FromArgb(40, 40, 76);
			btXoaphantudau.Location = new Point(6, 317);
			btXoaphantudau.Name = "btXoaphantudau";
			btXoaphantudau.Size = new Size(367, 42);
			btXoaphantudau.TabIndex = 10;
			btXoaphantudau.Text = "Xóa Phần Tử Đầu";
			btXoaphantudau.UseVisualStyleBackColor = false;
			btXoaphantudau.Click += btXoaphantudau_Click;
			// 
			// btXoaphantucuoi
			// 
			btXoaphantucuoi.BackColor = Color.FromArgb(229, 229, 241);
			btXoaphantucuoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btXoaphantucuoi.ForeColor = Color.FromArgb(40, 40, 76);
			btXoaphantucuoi.Location = new Point(6, 382);
			btXoaphantucuoi.Name = "btXoaphantucuoi";
			btXoaphantucuoi.Size = new Size(367, 42);
			btXoaphantucuoi.TabIndex = 11;
			btXoaphantucuoi.Text = "Xóa Phần Tử Cuối";
			btXoaphantucuoi.UseVisualStyleBackColor = false;
			btXoaphantucuoi.Click += btXoaphantucuoi_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(btXoaphantucuoi);
			groupBox1.Controls.Add(btXoaphantudau);
			groupBox1.Controls.Add(btXoaphantudangchon);
			groupBox1.Controls.Add(btLecuoi);
			groupBox1.Controls.Add(btChonchandau);
			groupBox1.Controls.Add(btTang2);
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.ForeColor = Color.FromArgb(255, 255, 192);
			groupBox1.Location = new Point(425, 115);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(379, 462);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Skill";
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.Location = new Point(-108, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(487, 520);
			pictureBox1.TabIndex = 13;
			pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(100, 120, 207);
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(816, 641);
			Controls.Add(btKetthuc);
			Controls.Add(groupBox1);
			Controls.Add(lstKetQua);
			Controls.Add(btCapnhat);
			Controls.Add(txtSonguyen);
			Controls.Add(label1);
			DoubleBuffered = true;
			Name = "Form1";
			Text = "frmThaotacso";
			((System.ComponentModel.ISupportInitialize)errSonguyen).EndInit();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtSonguyen;
		private Button btCapnhat;
		private ListBox lstKetQua;
		private Button btKetthuc;
		private ErrorProvider errSonguyen;
		private GroupBox groupBox1;
		private Button btXoaphantucuoi;
		private Button btXoaphantudau;
		private Button btXoaphantudangchon;
		private Button btLecuoi;
		private Button btChonchandau;
		private Button btTang2;
		private PictureBox pictureBox1;
	}
}
=======
﻿namespace Lab4_Thaotacso
{
    partial class Form1
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			txtSonguyen = new TextBox();
			btCapnhat = new Button();
			lstKetQua = new ListBox();
			btKetthuc = new Button();
			errSonguyen = new ErrorProvider(components);
			btTang2 = new Button();
			btChonchandau = new Button();
			btLecuoi = new Button();
			btXoaphantudangchon = new Button();
			btXoaphantudau = new Button();
			btXoaphantucuoi = new Button();
			groupBox1 = new GroupBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)errSonguyen).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(250, 249, 199);
			label1.Location = new Point(12, 62);
			label1.Name = "label1";
			label1.Size = new Size(161, 25);
			label1.TabIndex = 0;
			label1.Text = "Nhập Số Nguyên:";
			// 
			// txtSonguyen
			// 
			txtSonguyen.BackColor = Color.FromArgb(229, 229, 241);
			txtSonguyen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			txtSonguyen.ForeColor = Color.FromArgb(40, 40, 76);
			txtSonguyen.Location = new Point(173, 58);
			txtSonguyen.Name = "txtSonguyen";
			txtSonguyen.Size = new Size(441, 31);
			txtSonguyen.TabIndex = 1;
			txtSonguyen.TextChanged += txtSonguyen_TextChanged;
			// 
			// btCapnhat
			// 
			btCapnhat.BackColor = Color.FromArgb(229, 229, 241);
			btCapnhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btCapnhat.ForeColor = Color.FromArgb(40, 40, 76);
			btCapnhat.Location = new Point(661, 55);
			btCapnhat.Name = "btCapnhat";
			btCapnhat.Size = new Size(106, 39);
			btCapnhat.TabIndex = 2;
			btCapnhat.Text = "Cập Nhật";
			btCapnhat.UseVisualStyleBackColor = false;
			btCapnhat.Click += btCapnhat_Click;
			// 
			// lstKetQua
			// 
			lstKetQua.BackColor = Color.FromArgb(229, 229, 241);
			lstKetQua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			lstKetQua.ForeColor = Color.FromArgb(40, 40, 76);
			lstKetQua.FormattingEnabled = true;
			lstKetQua.Location = new Point(12, 122);
			lstKetQua.Name = "lstKetQua";
			lstKetQua.Size = new Size(375, 454);
			lstKetQua.TabIndex = 3;
			// 
			// btKetthuc
			// 
			btKetthuc.BackColor = Color.FromArgb(229, 229, 241);
			btKetthuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btKetthuc.ForeColor = Color.FromArgb(40, 40, 76);
			btKetthuc.Location = new Point(221, 583);
			btKetthuc.Name = "btKetthuc";
			btKetthuc.Size = new Size(367, 42);
			btKetthuc.TabIndex = 12;
			btKetthuc.Text = "Kết thúc";
			btKetthuc.UseVisualStyleBackColor = false;
			btKetthuc.Click += btKetthuc_Click;
			// 
			// errSonguyen
			// 
			errSonguyen.ContainerControl = this;
			// 
			// btTang2
			// 
			btTang2.BackColor = Color.FromArgb(229, 229, 241);
			btTang2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btTang2.ForeColor = Color.FromArgb(40, 40, 76);
			btTang2.Location = new Point(6, 54);
			btTang2.Name = "btTang2";
			btTang2.Size = new Size(367, 42);
			btTang2.TabIndex = 6;
			btTang2.Text = "Tăng Mỗi Phần Tử Lên 2";
			btTang2.UseVisualStyleBackColor = false;
			btTang2.Click += btTang2_Click;
			// 
			// btChonchandau
			// 
			btChonchandau.BackColor = Color.FromArgb(229, 229, 241);
			btChonchandau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btChonchandau.ForeColor = Color.FromArgb(40, 40, 76);
			btChonchandau.Location = new Point(6, 121);
			btChonchandau.Name = "btChonchandau";
			btChonchandau.Size = new Size(367, 42);
			btChonchandau.TabIndex = 7;
			btChonchandau.Text = "Chọn Số Chẵn Đầu";
			btChonchandau.UseVisualStyleBackColor = false;
			btChonchandau.Click += btChonchandau_Click;
			// 
			// btLecuoi
			// 
			btLecuoi.BackColor = Color.FromArgb(229, 229, 241);
			btLecuoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btLecuoi.ForeColor = Color.FromArgb(40, 40, 76);
			btLecuoi.Location = new Point(6, 187);
			btLecuoi.Name = "btLecuoi";
			btLecuoi.Size = new Size(367, 42);
			btLecuoi.TabIndex = 8;
			btLecuoi.Text = "Chọn Số Lẻ Cuối";
			btLecuoi.UseVisualStyleBackColor = false;
			btLecuoi.Click += btLecuoi_Click;
			// 
			// btXoaphantudangchon
			// 
			btXoaphantudangchon.BackColor = Color.FromArgb(229, 229, 241);
			btXoaphantudangchon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btXoaphantudangchon.ForeColor = Color.FromArgb(40, 40, 76);
			btXoaphantudangchon.Location = new Point(6, 251);
			btXoaphantudangchon.Name = "btXoaphantudangchon";
			btXoaphantudangchon.Size = new Size(367, 42);
			btXoaphantudangchon.TabIndex = 9;
			btXoaphantudangchon.Text = "Xóa Phần Tử Đang Chọn";
			btXoaphantudangchon.UseVisualStyleBackColor = false;
			btXoaphantudangchon.Click += btXoaphantudangchon_Click;
			// 
			// btXoaphantudau
			// 
			btXoaphantudau.BackColor = Color.FromArgb(229, 229, 241);
			btXoaphantudau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btXoaphantudau.ForeColor = Color.FromArgb(40, 40, 76);
			btXoaphantudau.Location = new Point(6, 317);
			btXoaphantudau.Name = "btXoaphantudau";
			btXoaphantudau.Size = new Size(367, 42);
			btXoaphantudau.TabIndex = 10;
			btXoaphantudau.Text = "Xóa Phần Tử Đầu";
			btXoaphantudau.UseVisualStyleBackColor = false;
			btXoaphantudau.Click += btXoaphantudau_Click;
			// 
			// btXoaphantucuoi
			// 
			btXoaphantucuoi.BackColor = Color.FromArgb(229, 229, 241);
			btXoaphantucuoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btXoaphantucuoi.ForeColor = Color.FromArgb(40, 40, 76);
			btXoaphantucuoi.Location = new Point(6, 382);
			btXoaphantucuoi.Name = "btXoaphantucuoi";
			btXoaphantucuoi.Size = new Size(367, 42);
			btXoaphantucuoi.TabIndex = 11;
			btXoaphantucuoi.Text = "Xóa Phần Tử Cuối";
			btXoaphantucuoi.UseVisualStyleBackColor = false;
			btXoaphantucuoi.Click += btXoaphantucuoi_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(btXoaphantucuoi);
			groupBox1.Controls.Add(btXoaphantudau);
			groupBox1.Controls.Add(btXoaphantudangchon);
			groupBox1.Controls.Add(btLecuoi);
			groupBox1.Controls.Add(btChonchandau);
			groupBox1.Controls.Add(btTang2);
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.ForeColor = Color.FromArgb(255, 255, 192);
			groupBox1.Location = new Point(425, 115);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(379, 462);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Skill";
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.Location = new Point(-108, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(487, 520);
			pictureBox1.TabIndex = 13;
			pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(100, 120, 207);
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(816, 641);
			Controls.Add(btKetthuc);
			Controls.Add(groupBox1);
			Controls.Add(lstKetQua);
			Controls.Add(btCapnhat);
			Controls.Add(txtSonguyen);
			Controls.Add(label1);
			DoubleBuffered = true;
			Name = "Form1";
			Text = "frmThaotacso";
			((System.ComponentModel.ISupportInitialize)errSonguyen).EndInit();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtSonguyen;
		private Button btCapnhat;
		private ListBox lstKetQua;
		private Button btKetthuc;
		private ErrorProvider errSonguyen;
		private GroupBox groupBox1;
		private Button btXoaphantucuoi;
		private Button btXoaphantudau;
		private Button btXoaphantudangchon;
		private Button btLecuoi;
		private Button btChonchandau;
		private Button btTang2;
		private PictureBox pictureBox1;
	}
}
>>>>>>> 2a18ad26c5e5ca62758f0f1000e1b8543bcff917
