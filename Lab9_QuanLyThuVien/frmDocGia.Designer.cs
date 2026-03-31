namespace Lab9_QuanLyThuVien
{
	partial class frmDocGia
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
			dgvDocGia = new DataGridView();
			btnLamMoi = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnThem = new Button();
			txtTimKiem = new TextBox();
			groupBox1 = new GroupBox();
			txtTienNo = new TextBox();
			label5 = new Label();
			btnGiaHan = new Button();
			label8 = new Label();
			dtpNgayHetHan = new DateTimePicker();
			label7 = new Label();
			dtpNgayLapThe = new DateTimePicker();
			label6 = new Label();
			dtpNgaySinh = new DateTimePicker();
			txtEmail = new TextBox();
			txtDiaChi = new TextBox();
			txtHoTen = new TextBox();
			txtMaDG = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnTim = new Button();
			((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvDocGia
			// 
			dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDocGia.Location = new Point(12, 418);
			dgvDocGia.Name = "dgvDocGia";
			dgvDocGia.RowHeadersWidth = 51;
			dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDocGia.Size = new Size(932, 226);
			dgvDocGia.TabIndex = 47;
			dgvDocGia.CellClick += dgvDocGia_CellClick;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Times New Roman", 10.2F);
			btnLamMoi.Location = new Point(642, 233);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(106, 39);
			btnLamMoi.TabIndex = 46;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.2F);
			btnXoa.Location = new Point(399, 233);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(106, 39);
			btnXoa.TabIndex = 45;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Times New Roman", 10.2F);
			btnSua.Location = new Point(274, 233);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(106, 39);
			btnSua.TabIndex = 44;
			btnSua.Text = "Lưu";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.2F);
			btnThem.Location = new Point(150, 233);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(106, 39);
			btnThem.TabIndex = 43;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Font = new Font("Times New Roman", 10.2F);
			txtTimKiem.Location = new Point(99, 354);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(318, 27);
			txtTimKiem.TabIndex = 42;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtTienNo);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(btnGiaHan);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(btnLamMoi);
			groupBox1.Controls.Add(dtpNgayHetHan);
			groupBox1.Controls.Add(btnSua);
			groupBox1.Controls.Add(btnXoa);
			groupBox1.Controls.Add(btnThem);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(dtpNgayLapThe);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(dtpNgaySinh);
			groupBox1.Controls.Add(txtEmail);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(txtHoTen);
			groupBox1.Controls.Add(txtMaDG);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 24);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(932, 290);
			groupBox1.TabIndex = 41;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin độc giả";
			// 
			// txtTienNo
			// 
			txtTienNo.Enabled = false;
			txtTienNo.Font = new Font("Times New Roman", 10.2F);
			txtTienNo.Location = new Point(157, 185);
			txtTienNo.Name = "txtTienNo";
			txtTienNo.Size = new Size(250, 27);
			txtTienNo.TabIndex = 49;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Times New Roman", 10.2F);
			label5.Location = new Point(87, 188);
			label5.Name = "label5";
			label5.Size = new Size(64, 19);
			label5.TabIndex = 48;
			label5.Text = "Tiền nợ:";
			// 
			// btnGiaHan
			// 
			btnGiaHan.Font = new Font("Times New Roman", 10.2F);
			btnGiaHan.Location = new Point(521, 233);
			btnGiaHan.Name = "btnGiaHan";
			btnGiaHan.Size = new Size(106, 39);
			btnGiaHan.TabIndex = 47;
			btnGiaHan.Text = "Gia Hạn";
			btnGiaHan.UseVisualStyleBackColor = true;
			btnGiaHan.Click += btnGiaHan_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Times New Roman", 10.2F);
			label8.Location = new Point(472, 150);
			label8.Name = "label8";
			label8.Size = new Size(101, 19);
			label8.TabIndex = 29;
			label8.Text = "Ngày hết hạn:";
			// 
			// dtpNgayHetHan
			// 
			dtpNgayHetHan.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpNgayHetHan.Location = new Point(579, 144);
			dtpNgayHetHan.Name = "dtpNgayHetHan";
			dtpNgayHetHan.Size = new Size(250, 27);
			dtpNgayHetHan.TabIndex = 28;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Times New Roman", 10.2F);
			label7.Location = new Point(475, 108);
			label7.Name = "label7";
			label7.Size = new Size(98, 19);
			label7.TabIndex = 27;
			label7.Text = "Ngày lập thẻ:";
			// 
			// dtpNgayLapThe
			// 
			dtpNgayLapThe.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpNgayLapThe.Location = new Point(579, 102);
			dtpNgayLapThe.Name = "dtpNgayLapThe";
			dtpNgayLapThe.Size = new Size(250, 27);
			dtpNgayLapThe.TabIndex = 26;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Times New Roman", 10.2F);
			label6.Location = new Point(492, 67);
			label6.Name = "label6";
			label6.Size = new Size(81, 19);
			label6.TabIndex = 24;
			label6.Text = "Ngày sinh:";
			// 
			// dtpNgaySinh
			// 
			dtpNgaySinh.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpNgaySinh.Location = new Point(579, 64);
			dtpNgaySinh.Name = "dtpNgaySinh";
			dtpNgaySinh.Size = new Size(250, 27);
			dtpNgaySinh.TabIndex = 23;
			// 
			// txtEmail
			// 
			txtEmail.Font = new Font("Times New Roman", 10.2F);
			txtEmail.Location = new Point(157, 143);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(250, 27);
			txtEmail.TabIndex = 22;
			// 
			// txtDiaChi
			// 
			txtDiaChi.Font = new Font("Times New Roman", 10.2F);
			txtDiaChi.Location = new Point(157, 105);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(250, 27);
			txtDiaChi.TabIndex = 21;
			// 
			// txtHoTen
			// 
			txtHoTen.Font = new Font("Times New Roman", 10.2F);
			txtHoTen.Location = new Point(157, 71);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(250, 27);
			txtHoTen.TabIndex = 20;
			// 
			// txtMaDG
			// 
			txtMaDG.Enabled = false;
			txtMaDG.Font = new Font("Times New Roman", 10.2F);
			txtMaDG.Location = new Point(157, 35);
			txtMaDG.Name = "txtMaDG";
			txtMaDG.Size = new Size(250, 27);
			txtMaDG.TabIndex = 19;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 10.2F);
			label4.Location = new Point(97, 146);
			label4.Name = "label4";
			label4.Size = new Size(54, 19);
			label4.TabIndex = 17;
			label4.Text = "Email:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.2F);
			label3.Location = new Point(91, 108);
			label3.Name = "label3";
			label3.Size = new Size(63, 19);
			label3.TabIndex = 16;
			label3.Text = "Địa chỉ:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.2F);
			label2.Location = new Point(91, 74);
			label2.Name = "label2";
			label2.Size = new Size(60, 19);
			label2.TabIndex = 15;
			label2.Text = "Họ tên:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.2F);
			label1.Location = new Point(61, 38);
			label1.Name = "label1";
			label1.Size = new Size(90, 19);
			label1.TabIndex = 14;
			label1.Text = "Mã độc giả:";
			// 
			// btnTim
			// 
			btnTim.Font = new Font("Times New Roman", 10.2F);
			btnTim.Location = new Point(425, 345);
			btnTim.Name = "btnTim";
			btnTim.Size = new Size(111, 43);
			btnTim.TabIndex = 40;
			btnTim.Text = "Tìm Kiếm";
			btnTim.UseVisualStyleBackColor = true;
			btnTim.Click += btnTim_Click;
			// 
			// frmDocGia
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(955, 657);
			Controls.Add(dgvDocGia);
			Controls.Add(groupBox1);
			Controls.Add(btnTim);
			Controls.Add(txtTimKiem);
			Name = "frmDocGia";
			Text = "frmDocGia";
			Load += frmDocGia_Load;
			((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvDocGia;
		private Button btnLamMoi;
		private Button btnXoa;
		private Button btnSua;
		private Button btnThem;
		private TextBox txtTimKiem;
		private GroupBox groupBox1;
		private Label label6;
		private DateTimePicker dtpNgaySinh;
		private TextBox txtEmail;
		private TextBox txtDiaChi;
		private TextBox txtHoTen;
		private TextBox txtMaDG;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button btnTim;
		private Button btnGiaHan;
		private Label label8;
		private DateTimePicker dtpNgayHetHan;
		private Label label7;
		private DateTimePicker dtpNgayLapThe;
		private TextBox txtTienNo;
		private Label label5;
	}
}