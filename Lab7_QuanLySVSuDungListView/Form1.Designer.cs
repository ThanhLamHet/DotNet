<<<<<<< HEAD
﻿namespace Lab7_QuanLySVSuDungListView
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
			ListViewItem listViewItem1 = new ListViewItem("");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			groupBox1 = new GroupBox();
			label5 = new Label();
			label4 = new Label();
			txtDiaChi = new TextBox();
			txtSDT = new TextBox();
			label3 = new Label();
			dtNgaySinh = new DateTimePicker();
			label2 = new Label();
			txtHoten = new TextBox();
			btnThoat = new Button();
			groupBox2 = new GroupBox();
			btnSua = new Button();
			btnThem = new Button();
			btnXoa = new Button();
			groupBox3 = new GroupBox();
			listDanhSach = new ListView();
			HoTen = new ColumnHeader();
			NgaySinh = new ColumnHeader();
			DiaChi = new ColumnHeader();
			SoDienThoai = new ColumnHeader();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(76, 54, 119);
			label1.Location = new Point(14, 9);
			label1.Name = "label1";
			label1.Size = new Size(919, 65);
			label1.TabIndex = 0;
			label1.Text = "Quản Lý Nhân Viên";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(txtSDT);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(dtNgaySinh);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtHoten);
			groupBox1.Font = new Font("Comic Sans MS", 10.8F);
			groupBox1.ForeColor = Color.FromArgb(76, 54, 119);
			groupBox1.Location = new Point(8, 77);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(919, 135);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin chi tiết";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label5.ForeColor = Color.FromArgb(76, 54, 119);
			label5.Location = new Point(486, 87);
			label5.Name = "label5";
			label5.Size = new Size(68, 21);
			label5.TabIndex = 8;
			label5.Text = "Địa chỉ:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label4.ForeColor = Color.FromArgb(76, 54, 119);
			label4.Location = new Point(440, 40);
			label4.Name = "label4";
			label4.Size = new Size(118, 21);
			label4.TabIndex = 7;
			label4.Text = "Số điện thoại:";
			// 
			// txtDiaChi
			// 
			txtDiaChi.Font = new Font("Comic Sans MS", 9F);
			txtDiaChi.Location = new Point(560, 83);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(299, 28);
			txtDiaChi.TabIndex = 6;
			// 
			// txtSDT
			// 
			txtSDT.Font = new Font("Comic Sans MS", 9F);
			txtSDT.Location = new Point(560, 37);
			txtSDT.Name = "txtSDT";
			txtSDT.Size = new Size(299, 28);
			txtSDT.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(76, 54, 119);
			label3.Location = new Point(25, 83);
			label3.Name = "label3";
			label3.Size = new Size(88, 21);
			label3.TabIndex = 4;
			label3.Text = "Ngày sinh:";
			// 
			// dtNgaySinh
			// 
			dtNgaySinh.Font = new Font("Comic Sans MS", 9F);
			dtNgaySinh.Location = new Point(121, 81);
			dtNgaySinh.Name = "dtNgaySinh";
			dtNgaySinh.Size = new Size(299, 28);
			dtNgaySinh.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(76, 54, 119);
			label2.Location = new Point(44, 40);
			label2.Name = "label2";
			label2.Size = new Size(69, 21);
			label2.TabIndex = 2;
			label2.Text = "Họ tên:";
			// 
			// txtHoten
			// 
			txtHoten.Font = new Font("Comic Sans MS", 9F);
			txtHoten.Location = new Point(121, 37);
			txtHoten.Name = "txtHoten";
			txtHoten.Size = new Size(299, 28);
			txtHoten.TabIndex = 0;
			// 
			// btnThoat
			// 
			btnThoat.ForeColor = Color.FromArgb(76, 54, 119);
			btnThoat.Location = new Point(115, 22);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(77, 54);
			btnThoat.TabIndex = 3;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.Transparent;
			groupBox2.Controls.Add(btnSua);
			groupBox2.Controls.Add(btnThem);
			groupBox2.Controls.Add(btnXoa);
			groupBox2.Controls.Add(btnThoat);
			groupBox2.Font = new Font("Comic Sans MS", 10.8F);
			groupBox2.Location = new Point(693, 237);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(201, 144);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			// 
			// btnSua
			// 
			btnSua.ForeColor = Color.FromArgb(76, 54, 119);
			btnSua.Location = new Point(7, 22);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(77, 54);
			btnSua.TabIndex = 6;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.ForeColor = Color.FromArgb(76, 54, 119);
			btnThem.Location = new Point(7, 82);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(77, 54);
			btnThem.TabIndex = 5;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.ForeColor = Color.FromArgb(76, 54, 119);
			btnXoa.Location = new Point(115, 82);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(77, 54);
			btnXoa.TabIndex = 4;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// groupBox3
			// 
			groupBox3.BackColor = Color.Transparent;
			groupBox3.Controls.Add(listDanhSach);
			groupBox3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox3.ForeColor = Color.FromArgb(76, 54, 119);
			groupBox3.Location = new Point(14, 387);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(919, 284);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "Thông tin chung";
			// 
			// listDanhSach
			// 
			listDanhSach.Columns.AddRange(new ColumnHeader[] { HoTen, NgaySinh, DiaChi, SoDienThoai });
			listDanhSach.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			listDanhSach.ForeColor = Color.FromArgb(76, 54, 119);
			listDanhSach.FullRowSelect = true;
			listDanhSach.GridLines = true;
			listDanhSach.Items.AddRange(new ListViewItem[] { listViewItem1 });
			listDanhSach.Location = new Point(6, 34);
			listDanhSach.Name = "listDanhSach";
			listDanhSach.Size = new Size(907, 241);
			listDanhSach.TabIndex = 0;
			listDanhSach.UseCompatibleStateImageBehavior = false;
			listDanhSach.View = View.Details;
			// 
			// HoTen
			// 
			HoTen.Text = "Họ Tên";
			HoTen.Width = 220;
			// 
			// NgaySinh
			// 
			NgaySinh.Text = "Ngày Sinh";
			NgaySinh.Width = 220;
			// 
			// DiaChi
			// 
			DiaChi.Text = "Địa chỉ";
			DiaChi.Width = 220;
			// 
			// SoDienThoai
			// 
			SoDienThoai.Text = "Số Điện Thoại";
			SoDienThoai.Width = 170;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 232, 208);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(945, 683);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(groupBox3);
			DoubleBuffered = true;
			Name = "Form1";
			Text = "Quản Lý Nhân Ziên";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Label label5;
		private Label label4;
		private TextBox txtDiaChi;
		private TextBox txtSDT;
		private Label label3;
		private DateTimePicker dtNgaySinh;
		private Label label2;
		private TextBox txtHoten;
		private Button btnThoat;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private Button btnSua;
		private Button btnThem;
		private Button btnXoa;
		private ListView listDanhSach;
		private ColumnHeader HoTen;
		private ColumnHeader NgaySinh;
		private ColumnHeader DiaChi;
		private ColumnHeader SoDienThoai;
	}
}
=======
﻿namespace Lab7_QuanLySVSuDungListView
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
			ListViewItem listViewItem1 = new ListViewItem("");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			groupBox1 = new GroupBox();
			label5 = new Label();
			label4 = new Label();
			txtDiaChi = new TextBox();
			txtSDT = new TextBox();
			label3 = new Label();
			dtNgaySinh = new DateTimePicker();
			label2 = new Label();
			txtHoten = new TextBox();
			btnThoat = new Button();
			groupBox2 = new GroupBox();
			btnSua = new Button();
			btnThem = new Button();
			btnXoa = new Button();
			groupBox3 = new GroupBox();
			listDanhSach = new ListView();
			HoTen = new ColumnHeader();
			NgaySinh = new ColumnHeader();
			DiaChi = new ColumnHeader();
			SoDienThoai = new ColumnHeader();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(76, 54, 119);
			label1.Location = new Point(14, 9);
			label1.Name = "label1";
			label1.Size = new Size(919, 65);
			label1.TabIndex = 0;
			label1.Text = "Quản Lý Nhân Viên";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(txtSDT);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(dtNgaySinh);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtHoten);
			groupBox1.Font = new Font("Comic Sans MS", 10.8F);
			groupBox1.ForeColor = Color.FromArgb(76, 54, 119);
			groupBox1.Location = new Point(8, 77);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(919, 135);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin chi tiết";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label5.ForeColor = Color.FromArgb(76, 54, 119);
			label5.Location = new Point(486, 87);
			label5.Name = "label5";
			label5.Size = new Size(68, 21);
			label5.TabIndex = 8;
			label5.Text = "Địa chỉ:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label4.ForeColor = Color.FromArgb(76, 54, 119);
			label4.Location = new Point(440, 40);
			label4.Name = "label4";
			label4.Size = new Size(118, 21);
			label4.TabIndex = 7;
			label4.Text = "Số điện thoại:";
			// 
			// txtDiaChi
			// 
			txtDiaChi.Font = new Font("Comic Sans MS", 9F);
			txtDiaChi.Location = new Point(560, 83);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(299, 28);
			txtDiaChi.TabIndex = 6;
			// 
			// txtSDT
			// 
			txtSDT.Font = new Font("Comic Sans MS", 9F);
			txtSDT.Location = new Point(560, 37);
			txtSDT.Name = "txtSDT";
			txtSDT.Size = new Size(299, 28);
			txtSDT.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(76, 54, 119);
			label3.Location = new Point(25, 83);
			label3.Name = "label3";
			label3.Size = new Size(88, 21);
			label3.TabIndex = 4;
			label3.Text = "Ngày sinh:";
			// 
			// dtNgaySinh
			// 
			dtNgaySinh.Font = new Font("Comic Sans MS", 9F);
			dtNgaySinh.Location = new Point(121, 81);
			dtNgaySinh.Name = "dtNgaySinh";
			dtNgaySinh.Size = new Size(299, 28);
			dtNgaySinh.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(76, 54, 119);
			label2.Location = new Point(44, 40);
			label2.Name = "label2";
			label2.Size = new Size(69, 21);
			label2.TabIndex = 2;
			label2.Text = "Họ tên:";
			// 
			// txtHoten
			// 
			txtHoten.Font = new Font("Comic Sans MS", 9F);
			txtHoten.Location = new Point(121, 37);
			txtHoten.Name = "txtHoten";
			txtHoten.Size = new Size(299, 28);
			txtHoten.TabIndex = 0;
			// 
			// btnThoat
			// 
			btnThoat.ForeColor = Color.FromArgb(76, 54, 119);
			btnThoat.Location = new Point(115, 22);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(77, 54);
			btnThoat.TabIndex = 3;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.Transparent;
			groupBox2.Controls.Add(btnSua);
			groupBox2.Controls.Add(btnThem);
			groupBox2.Controls.Add(btnXoa);
			groupBox2.Controls.Add(btnThoat);
			groupBox2.Font = new Font("Comic Sans MS", 10.8F);
			groupBox2.Location = new Point(693, 237);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(201, 144);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			// 
			// btnSua
			// 
			btnSua.ForeColor = Color.FromArgb(76, 54, 119);
			btnSua.Location = new Point(7, 22);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(77, 54);
			btnSua.TabIndex = 6;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.ForeColor = Color.FromArgb(76, 54, 119);
			btnThem.Location = new Point(7, 82);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(77, 54);
			btnThem.TabIndex = 5;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.ForeColor = Color.FromArgb(76, 54, 119);
			btnXoa.Location = new Point(115, 82);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(77, 54);
			btnXoa.TabIndex = 4;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// groupBox3
			// 
			groupBox3.BackColor = Color.Transparent;
			groupBox3.Controls.Add(listDanhSach);
			groupBox3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox3.ForeColor = Color.FromArgb(76, 54, 119);
			groupBox3.Location = new Point(14, 387);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(919, 284);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "Thông tin chung";
			// 
			// listDanhSach
			// 
			listDanhSach.Columns.AddRange(new ColumnHeader[] { HoTen, NgaySinh, DiaChi, SoDienThoai });
			listDanhSach.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			listDanhSach.ForeColor = Color.FromArgb(76, 54, 119);
			listDanhSach.FullRowSelect = true;
			listDanhSach.GridLines = true;
			listDanhSach.Items.AddRange(new ListViewItem[] { listViewItem1 });
			listDanhSach.Location = new Point(6, 34);
			listDanhSach.Name = "listDanhSach";
			listDanhSach.Size = new Size(907, 241);
			listDanhSach.TabIndex = 0;
			listDanhSach.UseCompatibleStateImageBehavior = false;
			listDanhSach.View = View.Details;
			// 
			// HoTen
			// 
			HoTen.Text = "Họ Tên";
			HoTen.Width = 220;
			// 
			// NgaySinh
			// 
			NgaySinh.Text = "Ngày Sinh";
			NgaySinh.Width = 220;
			// 
			// DiaChi
			// 
			DiaChi.Text = "Địa chỉ";
			DiaChi.Width = 220;
			// 
			// SoDienThoai
			// 
			SoDienThoai.Text = "Số Điện Thoại";
			SoDienThoai.Width = 170;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 232, 208);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(945, 683);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(groupBox3);
			DoubleBuffered = true;
			Name = "Form1";
			Text = "Quản Lý Nhân Ziên";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Label label5;
		private Label label4;
		private TextBox txtDiaChi;
		private TextBox txtSDT;
		private Label label3;
		private DateTimePicker dtNgaySinh;
		private Label label2;
		private TextBox txtHoten;
		private Button btnThoat;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private Button btnSua;
		private Button btnThem;
		private Button btnXoa;
		private ListView listDanhSach;
		private ColumnHeader HoTen;
		private ColumnHeader NgaySinh;
		private ColumnHeader DiaChi;
		private ColumnHeader SoDienThoai;
	}
}
>>>>>>> 2a18ad26c5e5ca62758f0f1000e1b8543bcff917
