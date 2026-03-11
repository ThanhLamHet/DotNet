namespace Lab8_QuanLySV
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			btnSua = new Button();
			btnThem = new Button();
			groupBox1 = new GroupBox();
			txtMaSo = new TextBox();
			cbGioiTinh = new ComboBox();
			label8 = new Label();
			cbMaKhoa = new ComboBox();
			label6 = new Label();
			label7 = new Label();
			label3 = new Label();
			dtpNgaySinh = new DateTimePicker();
			label5 = new Label();
			label4 = new Label();
			txtDiaChi = new TextBox();
			txtSDT = new TextBox();
			label2 = new Label();
			txtHoTen = new TextBox();
			label1 = new Label();
			button1 = new Button();
			btn = new Button();
			button3 = new Button();
			dgvSinhVien = new DataGridView();
			txtTim = new TextBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
			SuspendLayout();
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnSua.ForeColor = Color.FromArgb(40, 39, 81);
			btnSua.Location = new Point(340, 328);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(114, 46);
			btnSua.TabIndex = 19;
			btnSua.Text = "Xóa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnXoa_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(40, 39, 81);
			btnThem.Location = new Point(205, 328);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(114, 46);
			btnThem.TabIndex = 18;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(txtMaSo);
			groupBox1.Controls.Add(cbGioiTinh);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(cbMaKhoa);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(dtpNgaySinh);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(txtSDT);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtHoTen);
			groupBox1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.ForeColor = Color.FromArgb(40, 39, 81);
			groupBox1.Location = new Point(6, 77);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(951, 223);
			groupBox1.TabIndex = 16;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin chi tiết";
			// 
			// txtMaSo
			// 
			txtMaSo.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtMaSo.ForeColor = Color.Red;
			txtMaSo.Location = new Point(119, 38);
			txtMaSo.Name = "txtMaSo";
			txtMaSo.ReadOnly = true;
			txtMaSo.Size = new Size(299, 28);
			txtMaSo.TabIndex = 17;
			// 
			// cbGioiTinh
			// 
			cbGioiTinh.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			cbGioiTinh.FormattingEnabled = true;
			cbGioiTinh.Location = new Point(119, 175);
			cbGioiTinh.Name = "cbGioiTinh";
			cbGioiTinh.Size = new Size(299, 28);
			cbGioiTinh.TabIndex = 15;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label8.ForeColor = Color.FromArgb(40, 39, 81);
			label8.Location = new Point(29, 178);
			label8.Name = "label8";
			label8.Size = new Size(84, 20);
			label8.TabIndex = 14;
			label8.Text = "Giới tính:";
			// 
			// cbMaKhoa
			// 
			cbMaKhoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cbMaKhoa.FormattingEnabled = true;
			cbMaKhoa.Location = new Point(583, 129);
			cbMaKhoa.Name = "cbMaKhoa";
			cbMaKhoa.Size = new Size(299, 27);
			cbMaKhoa.TabIndex = 12;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label6.ForeColor = Color.FromArgb(40, 39, 81);
			label6.Location = new Point(489, 132);
			label6.Name = "label6";
			label6.Size = new Size(88, 20);
			label6.TabIndex = 12;
			label6.Text = "Mã Khoa:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label7.ForeColor = Color.FromArgb(40, 39, 81);
			label7.Location = new Point(51, 41);
			label7.Name = "label7";
			label7.Size = new Size(65, 20);
			label7.TabIndex = 10;
			label7.Text = "Mã Số:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(40, 39, 81);
			label3.Location = new Point(25, 131);
			label3.Name = "label3";
			label3.Size = new Size(91, 20);
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
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label5.ForeColor = Color.FromArgb(40, 39, 81);
			label5.Location = new Point(508, 92);
			label5.Name = "label5";
			label5.Size = new Size(69, 20);
			label5.TabIndex = 8;
			label5.Text = "Địa chỉ:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label4.ForeColor = Color.FromArgb(40, 39, 81);
			label4.Location = new Point(460, 41);
			label4.Name = "label4";
			label4.Size = new Size(117, 20);
			label4.TabIndex = 7;
			label4.Text = "Số điện thoại:";
			// 
			// txtDiaChi
			// 
			txtDiaChi.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtDiaChi.Location = new Point(583, 84);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(299, 28);
			txtDiaChi.TabIndex = 6;
			// 
			// txtSDT
			// 
			txtSDT.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtSDT.Location = new Point(583, 38);
			txtSDT.Name = "txtSDT";
			txtSDT.Size = new Size(299, 28);
			txtSDT.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(40, 39, 81);
			label2.Location = new Point(49, 84);
			label2.Name = "label2";
			label2.Size = new Size(67, 20);
			label2.TabIndex = 2;
			label2.Text = "Họ tên:";
			// 
			// txtHoTen
			// 
			txtHoTen.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtHoTen.Location = new Point(119, 80);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(299, 28);
			txtHoTen.TabIndex = 0;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(40, 39, 81);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(945, 65);
			label1.TabIndex = 15;
			label1.Text = "Quản Lý Sinh Viên";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			button1.ForeColor = Color.FromArgb(40, 39, 81);
			button1.Location = new Point(603, 328);
			button1.Name = "button1";
			button1.Size = new Size(114, 46);
			button1.TabIndex = 21;
			button1.Text = "Làm Mới";
			button1.UseVisualStyleBackColor = true;
			button1.Click += btnLamMoi_Click;
			// 
			// btn
			// 
			btn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btn.ForeColor = Color.FromArgb(40, 39, 81);
			btn.Location = new Point(468, 328);
			btn.Name = "btn";
			btn.Size = new Size(114, 46);
			btn.TabIndex = 20;
			btn.Text = "Sửa";
			btn.UseVisualStyleBackColor = true;
			btn.Click += btnSua_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			button3.ForeColor = Color.FromArgb(40, 39, 81);
			button3.Location = new Point(713, 394);
			button3.Name = "button3";
			button3.Size = new Size(114, 46);
			button3.TabIndex = 22;
			button3.Text = "Tìm Kiếm";
			button3.UseVisualStyleBackColor = true;
			button3.Click += btnTim_Click;
			// 
			// dgvSinhVien
			// 
			dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSinhVien.Location = new Point(12, 463);
			dgvSinhVien.Name = "dgvSinhVien";
			dgvSinhVien.RowHeadersWidth = 51;
			dgvSinhVien.Size = new Size(945, 228);
			dgvSinhVien.TabIndex = 23;
			dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
			// 
			// txtTim
			// 
			txtTim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtTim.Location = new Point(205, 404);
			txtTim.Name = "txtTim";
			txtTim.Size = new Size(502, 28);
			txtTim.TabIndex = 17;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(969, 703);
			Controls.Add(txtTim);
			Controls.Add(dgvSinhVien);
			Controls.Add(button3);
			Controls.Add(button1);
			Controls.Add(btn);
			Controls.Add(btnSua);
			Controls.Add(btnThem);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form Sinh Viên";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSua;
		private Button btnThem;
		private GroupBox groupBox1;
		private ComboBox cbMaKhoa;
		private Label label6;
		private Label label7;
		private Label label3;
		private DateTimePicker dtpNgaySinh;
		private Label label5;
		private Label label4;
		private TextBox txtDiaChi;
		private TextBox txtSDT;
		private Label label2;
		private TextBox txtHoTen;
		private Label label1;
		private ComboBox cbGioiTinh;
		private Label label8;
		private Button button1;
		private Button btn;
		private Button button3;
		private DataGridView dgvSinhVien;
		private TextBox txtTim;
		private TextBox txtMaSo;
	}
}
