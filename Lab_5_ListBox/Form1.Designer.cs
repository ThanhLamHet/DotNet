namespace Lab_5_ListBox
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
			groupBox1 = new GroupBox();
			numericUpDownFilling = new NumericUpDown();
			btnThoat = new Button();
			btnThemDanhSach = new Button();
			btnTongTien = new Button();
			txtTongTien = new TextBox();
			label8 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			chkChupHinh = new CheckBox();
			chkTayTrang = new CheckBox();
			chkcaovoi = new CheckBox();
			txtTenKhachHang = new TextBox();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btnXoa = new Button();
			btnTaiFile = new Button();
			btnLuuFile = new Button();
			lbKhach = new ListBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownFilling).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(numericUpDownFilling);
			groupBox1.Controls.Add(btnThoat);
			groupBox1.Controls.Add(btnThemDanhSach);
			groupBox1.Controls.Add(btnTongTien);
			groupBox1.Controls.Add(txtTongTien);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(chkChupHinh);
			groupBox1.Controls.Add(chkTayTrang);
			groupBox1.Controls.Add(chkcaovoi);
			groupBox1.Controls.Add(txtTenKhachHang);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(534, 658);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Quản Lý Thanh Toán";
			// 
			// numericUpDownFilling
			// 
			numericUpDownFilling.Location = new Point(157, 300);
			numericUpDownFilling.Name = "numericUpDownFilling";
			numericUpDownFilling.Size = new Size(222, 27);
			numericUpDownFilling.TabIndex = 16;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(198, 583);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(140, 69);
			btnThoat.TabIndex = 15;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// btnThemDanhSach
			// 
			btnThemDanhSach.Location = new Point(367, 478);
			btnThemDanhSach.Name = "btnThemDanhSach";
			btnThemDanhSach.Size = new Size(126, 69);
			btnThemDanhSach.TabIndex = 14;
			btnThemDanhSach.Text = "Thêm Vào Danh Sách";
			btnThemDanhSach.UseVisualStyleBackColor = true;
			btnThemDanhSach.Click += btnThemDanhSach_Click;
			// 
			// btnTongTien
			// 
			btnTongTien.Location = new Point(35, 478);
			btnTongTien.Name = "btnTongTien";
			btnTongTien.Size = new Size(128, 69);
			btnTongTien.TabIndex = 13;
			btnTongTien.Text = "Tính Tổng Tiền";
			btnTongTien.UseVisualStyleBackColor = true;
			btnTongTien.Click += btnTongTien_Click;
			// 
			// txtTongTien
			// 
			txtTongTien.BackColor = Color.MintCream;
			txtTongTien.Font = new Font("Segoe UI", 15F);
			txtTongTien.Location = new Point(127, 388);
			txtTongTien.Name = "txtTongTien";
			txtTongTien.ReadOnly = true;
			txtTongTien.Size = new Size(334, 41);
			txtTongTien.TabIndex = 12;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(31, 403);
			label8.Name = "label8";
			label8.Size = new Size(75, 20);
			label8.TabIndex = 11;
			label8.Text = "Tổng Tiền";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(442, 302);
			label6.Name = "label6";
			label6.Size = new Size(65, 20);
			label6.TabIndex = 10;
			label6.Text = "80.000 đ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(434, 234);
			label5.Name = "label5";
			label5.Size = new Size(73, 20);
			label5.TabIndex = 9;
			label5.Text = "200.000 đ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(423, 189);
			label4.Name = "label4";
			label4.Size = new Size(84, 20);
			label4.TabIndex = 8;
			label4.Text = "1.200.000 đ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(434, 144);
			label3.Name = "label3";
			label3.Size = new Size(73, 20);
			label3.TabIndex = 6;
			label3.Text = "100.000 đ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(25, 302);
			label2.Name = "label2";
			label2.Size = new Size(80, 20);
			label2.TabIndex = 5;
			label2.Text = "Trám Răng";
			label2.Click += label2_Click;
			// 
			// chkChupHinh
			// 
			chkChupHinh.AutoSize = true;
			chkChupHinh.Location = new Point(25, 233);
			chkChupHinh.Name = "chkChupHinh";
			chkChupHinh.Size = new Size(138, 24);
			chkChupHinh.TabIndex = 4;
			chkChupHinh.Text = "Chụp Hình Răng";
			chkChupHinh.UseVisualStyleBackColor = true;
			// 
			// chkTayTrang
			// 
			chkTayTrang.AutoSize = true;
			chkTayTrang.Location = new Point(25, 188);
			chkTayTrang.Name = "chkTayTrang";
			chkTayTrang.Size = new Size(133, 24);
			chkTayTrang.TabIndex = 3;
			chkTayTrang.Text = "Tẩy Trắng Răng";
			chkTayTrang.UseVisualStyleBackColor = true;
			// 
			// chkcaovoi
			// 
			chkcaovoi.AutoSize = true;
			chkcaovoi.Location = new Point(25, 143);
			chkcaovoi.Name = "chkcaovoi";
			chkcaovoi.Size = new Size(81, 24);
			chkcaovoi.TabIndex = 2;
			chkcaovoi.Text = "Cạo vôi";
			chkcaovoi.UseVisualStyleBackColor = true;
			// 
			// txtTenKhachHang
			// 
			txtTenKhachHang.Location = new Point(157, 61);
			txtTenKhachHang.Name = "txtTenKhachHang";
			txtTenKhachHang.Size = new Size(360, 27);
			txtTenKhachHang.TabIndex = 1;
			txtTenKhachHang.TextChanged += textBox1_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(35, 64);
			label1.Name = "label1";
			label1.Size = new Size(116, 20);
			label1.TabIndex = 0;
			label1.Text = "Tên Khách Hàng";
			label1.Click += label1_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnXoa);
			groupBox2.Controls.Add(btnTaiFile);
			groupBox2.Controls.Add(btnLuuFile);
			groupBox2.Controls.Add(lbKhach);
			groupBox2.Location = new Point(552, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(527, 658);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Danh Sách";
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(193, 403);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(128, 49);
			btnXoa.TabIndex = 18;
			btnXoa.Text = "Xóa Khách Hàng";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnTaiFile
			// 
			btnTaiFile.Location = new Point(403, 502);
			btnTaiFile.Name = "btnTaiFile";
			btnTaiFile.Size = new Size(118, 54);
			btnTaiFile.TabIndex = 17;
			btnTaiFile.Text = "tải File";
			btnTaiFile.UseVisualStyleBackColor = true;
			btnTaiFile.Click += btnTaiFile_Click;
			// 
			// btnLuuFile
			// 
			btnLuuFile.Location = new Point(6, 502);
			btnLuuFile.Name = "btnLuuFile";
			btnLuuFile.Size = new Size(123, 54);
			btnLuuFile.TabIndex = 16;
			btnLuuFile.Text = "lưu File";
			btnLuuFile.UseVisualStyleBackColor = true;
			btnLuuFile.Click += btnLuuFile_Click;
			// 
			// lbKhach
			// 
			lbKhach.FormattingEnabled = true;
			lbKhach.Location = new Point(6, 37);
			lbKhach.Name = "lbKhach";
			lbKhach.Size = new Size(515, 344);
			lbKhach.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Snow;
			ClientSize = new Size(1093, 690);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownFilling).EndInit();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label3;
		private Label label2;
		private CheckBox chkChupHinh;
		private CheckBox chkTayTrang;
		private CheckBox chkcaovoi;
		private TextBox txtTenKhachHang;
		private Label label1;
		private Label label5;
		private Label label4;
		private Label label6;
		private TextBox txtTongTien;
		private Label label8;
		private Button btnThoat;
		private Button btnThemDanhSach;
		private Button btnTongTien;
		private Button btnTaiFile;
		private Button btnLuuFile;
		private ListBox lbKhach;
		private NumericUpDown numericUpDownFilling;
		private Button btnXoa;
	}
}
