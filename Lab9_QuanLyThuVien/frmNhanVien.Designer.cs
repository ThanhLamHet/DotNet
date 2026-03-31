namespace Lab9_QuanLyThuVien
{
	partial class frmNhanVien
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
			dgvNhanVien = new DataGridView();
			btnLamMoi = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnThem = new Button();
			txtTimKiem = new TextBox();
			groupBox1 = new GroupBox();
			cbBangCap = new ComboBox();
			label6 = new Label();
			dtpNgaySinh = new DateTimePicker();
			txtDienThoai = new TextBox();
			txtDiaChi = new TextBox();
			txtHoTen = new TextBox();
			txtMaNV = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnTim = new Button();
			label7 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvNhanVien
			// 
			dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvNhanVien.Location = new Point(12, 455);
			dgvNhanVien.Name = "dgvNhanVien";
			dgvNhanVien.RowHeadersWidth = 51;
			dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvNhanVien.Size = new Size(932, 272);
			dgvNhanVien.TabIndex = 39;
			dgvNhanVien.CellClick += dgvNhanVien_CellClick;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Times New Roman", 10.2F);
			btnLamMoi.Location = new Point(722, 401);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(106, 39);
			btnLamMoi.TabIndex = 38;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.2F);
			btnXoa.Location = new Point(722, 345);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(106, 39);
			btnXoa.TabIndex = 37;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Times New Roman", 10.2F);
			btnSua.Location = new Point(590, 401);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(106, 39);
			btnSua.TabIndex = 36;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.2F);
			btnThem.Location = new Point(591, 345);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(106, 39);
			btnThem.TabIndex = 35;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Font = new Font("Times New Roman", 10.2F);
			txtTimKiem.Location = new Point(93, 367);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(301, 27);
			txtTimKiem.TabIndex = 34;
			txtTimKiem.TextChanged += txtTimKiem_TextChanged;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(cbBangCap);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(dtpNgaySinh);
			groupBox1.Controls.Add(txtDienThoai);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(txtHoTen);
			groupBox1.Controls.Add(txtMaNV);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 107);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(932, 225);
			groupBox1.TabIndex = 33;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin nhân viên";
			// 
			// cbBangCap
			// 
			cbBangCap.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbBangCap.FormattingEnabled = true;
			cbBangCap.Location = new Point(578, 133);
			cbBangCap.Name = "cbBangCap";
			cbBangCap.Size = new Size(250, 27);
			cbBangCap.TabIndex = 25;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Times New Roman", 10.2F);
			label6.Location = new Point(76, 136);
			label6.Name = "label6";
			label6.Size = new Size(81, 19);
			label6.TabIndex = 24;
			label6.Text = "Ngày sinh:";
			// 
			// dtpNgaySinh
			// 
			dtpNgaySinh.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpNgaySinh.Location = new Point(163, 133);
			dtpNgaySinh.Name = "dtpNgaySinh";
			dtpNgaySinh.Size = new Size(250, 27);
			dtpNgaySinh.TabIndex = 23;
			// 
			// txtDienThoai
			// 
			txtDienThoai.Font = new Font("Times New Roman", 10.2F);
			txtDienThoai.Location = new Point(578, 97);
			txtDienThoai.Name = "txtDienThoai";
			txtDienThoai.Size = new Size(250, 27);
			txtDienThoai.TabIndex = 22;
			// 
			// txtDiaChi
			// 
			txtDiaChi.Font = new Font("Times New Roman", 10.2F);
			txtDiaChi.Location = new Point(578, 61);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(250, 27);
			txtDiaChi.TabIndex = 21;
			// 
			// txtHoTen
			// 
			txtHoTen.Font = new Font("Times New Roman", 10.2F);
			txtHoTen.Location = new Point(163, 97);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(250, 27);
			txtHoTen.TabIndex = 20;
			// 
			// txtMaNV
			// 
			txtMaNV.Enabled = false;
			txtMaNV.Font = new Font("Times New Roman", 10.2F);
			txtMaNV.Location = new Point(163, 61);
			txtMaNV.Name = "txtMaNV";
			txtMaNV.Size = new Size(250, 27);
			txtMaNV.TabIndex = 19;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Times New Roman", 10.2F);
			label5.Location = new Point(497, 136);
			label5.Name = "label5";
			label5.Size = new Size(75, 19);
			label5.TabIndex = 18;
			label5.Text = "Bằng cấp:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 10.2F);
			label4.Location = new Point(487, 100);
			label4.Name = "label4";
			label4.Size = new Size(85, 19);
			label4.TabIndex = 17;
			label4.Text = "Điện thoại:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.2F);
			label3.Location = new Point(509, 64);
			label3.Name = "label3";
			label3.Size = new Size(63, 19);
			label3.TabIndex = 16;
			label3.Text = "Địa chỉ:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.2F);
			label2.Location = new Point(97, 100);
			label2.Name = "label2";
			label2.Size = new Size(60, 19);
			label2.TabIndex = 15;
			label2.Text = "Họ tên:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.2F);
			label1.Location = new Point(56, 64);
			label1.Name = "label1";
			label1.Size = new Size(103, 19);
			label1.TabIndex = 14;
			label1.Text = "Mã nhân viên:";
			// 
			// btnTim
			// 
			btnTim.Font = new Font("Times New Roman", 10.2F);
			btnTim.Location = new Point(400, 367);
			btnTim.Name = "btnTim";
			btnTim.Size = new Size(94, 29);
			btnTim.TabIndex = 32;
			btnTim.Text = "Tìm Kiếm";
			btnTim.UseVisualStyleBackColor = true;
			btnTim.Click += btnTim_Click;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(12, 18);
			label7.Name = "label7";
			label7.Size = new Size(932, 51);
			label7.TabIndex = 43;
			label7.Text = "Quản Lý Nhân Viên";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			label7.Click += label7_Click;
			// 
			// frmNhanVien
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(956, 738);
			Controls.Add(label7);
			Controls.Add(dgvNhanVien);
			Controls.Add(btnLamMoi);
			Controls.Add(btnXoa);
			Controls.Add(btnSua);
			Controls.Add(btnThem);
			Controls.Add(txtTimKiem);
			Controls.Add(groupBox1);
			Controls.Add(btnTim);
			Name = "frmNhanVien";
			Text = "frmNhanVien";
			Load += frmNhanVien_Load;
			((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvNhanVien;
		private Button btnLamMoi;
		private Button btnXoa;
		private Button btnSua;
		private Button btnThem;
		private TextBox txtTimKiem;
		private GroupBox groupBox1;
		private ComboBox cbBangCap;
		private Label label6;
		private DateTimePicker dtpNgaySinh;
		private TextBox txtDienThoai;
		private TextBox txtDiaChi;
		private TextBox txtHoTen;
		private TextBox txtMaNV;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button btnTim;
		private Label label7;
	}
}