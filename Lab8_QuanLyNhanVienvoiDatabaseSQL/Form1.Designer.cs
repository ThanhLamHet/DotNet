namespace Lab8_QuanLyNhanVienvoiDatabaseSQL
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
			dgvSinhVien = new DataGridView();
			groupBox1 = new GroupBox();
			label6 = new Label();
			txtMaKhoa = new TextBox();
			label7 = new Label();
			label3 = new Label();
			dtpNgaySinh = new DateTimePicker();
			txtMSSV = new TextBox();
			label5 = new Label();
			label4 = new Label();
			txtDiaChi = new TextBox();
			txtSDT = new TextBox();
			label2 = new Label();
			txtTen = new TextBox();
			label1 = new Label();
			checkBox1 = new CheckBox();
			checkBox2 = new CheckBox();
			groupBox2 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvSinhVien
			// 
			dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSinhVien.Location = new Point(6, 408);
			dgvSinhVien.Name = "dgvSinhVien";
			dgvSinhVien.RowHeadersWidth = 51;
			dgvSinhVien.Size = new Size(1077, 297);
			dgvSinhVien.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(txtMaKhoa);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(dtpNgaySinh);
			groupBox1.Controls.Add(txtMSSV);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(txtSDT);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtTen);
			groupBox1.Font = new Font("Comic Sans MS", 10.8F);
			groupBox1.ForeColor = Color.FromArgb(76, 54, 119);
			groupBox1.Location = new Point(6, 77);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(919, 176);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin chi tiết";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label6.ForeColor = Color.FromArgb(76, 54, 119);
			label6.Location = new Point(475, 135);
			label6.Name = "label6";
			label6.Size = new Size(79, 21);
			label6.TabIndex = 12;
			label6.Text = "Mã Khoa:";
			// 
			// txtMaKhoa
			// 
			txtMaKhoa.Font = new Font("Comic Sans MS", 9F);
			txtMaKhoa.Location = new Point(560, 130);
			txtMaKhoa.Name = "txtMaKhoa";
			txtMaKhoa.Size = new Size(299, 28);
			txtMaKhoa.TabIndex = 11;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label7.ForeColor = Color.FromArgb(76, 54, 119);
			label7.Location = new Point(48, 40);
			label7.Name = "label7";
			label7.Size = new Size(65, 21);
			label7.TabIndex = 10;
			label7.Text = "Mã Số:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(76, 54, 119);
			label3.Location = new Point(25, 132);
			label3.Name = "label3";
			label3.Size = new Size(88, 21);
			label3.TabIndex = 4;
			label3.Text = "Ngày sinh:";
			// 
			// dtpNgaySinh
			// 
			dtpNgaySinh.Font = new Font("Comic Sans MS", 9F);
			dtpNgaySinh.Location = new Point(119, 130);
			dtpNgaySinh.Name = "dtpNgaySinh";
			dtpNgaySinh.Size = new Size(299, 28);
			dtpNgaySinh.TabIndex = 3;
			// 
			// txtMSSV
			// 
			txtMSSV.Font = new Font("Comic Sans MS", 9F);
			txtMSSV.Location = new Point(119, 38);
			txtMSSV.Name = "txtMSSV";
			txtMSSV.Size = new Size(299, 28);
			txtMSSV.TabIndex = 9;
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
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(76, 54, 119);
			label2.Location = new Point(44, 87);
			label2.Name = "label2";
			label2.Size = new Size(69, 21);
			label2.TabIndex = 2;
			label2.Text = "Họ tên:";
			// 
			// txtTen
			// 
			txtTen.Font = new Font("Comic Sans MS", 9F);
			txtTen.Location = new Point(119, 80);
			txtTen.Name = "txtTen";
			txtTen.Size = new Size(299, 28);
			txtTen.TabIndex = 0;
			txtTen.TextChanged += txtHoten_TextChanged;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(76, 54, 119);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(919, 65);
			label1.TabIndex = 3;
			label1.Text = "Quản Lý Nhân Viên";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(6, 26);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(63, 24);
			checkBox1.TabIndex = 5;
			checkBox1.Text = "Nam";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(112, 26);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(51, 24);
			checkBox2.TabIndex = 6;
			checkBox2.Text = "Nữ";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(checkBox1);
			groupBox2.Controls.Add(checkBox2);
			groupBox2.Location = new Point(54, 274);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(169, 73);
			groupBox2.TabIndex = 7;
			groupBox2.TabStop = false;
			groupBox2.Text = "Giới tính";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1095, 717);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(dgvSinhVien);
			Name = "Form1";
			Text = "frmSinhVien";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvSinhVien;
		private GroupBox groupBox1;
		private Label label5;
		private Label label4;
		private TextBox txtDiaChi;
		private TextBox txtSDT;
		private Label label3;
		private DateTimePicker dtpNgaySinh;
		private Label label2;
		private TextBox txtTen;
		private Label label1;
		private Label label6;
		private TextBox txtMaKhoa;
		private Label label7;
		private TextBox txtMSSV;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private GroupBox groupBox2;
	}
}
