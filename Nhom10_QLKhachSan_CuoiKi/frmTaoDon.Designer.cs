namespace Nhom10_QLKhachSan_CuoiKi
{
	partial class frmTaoDon
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
			label1 = new Label();
			label2 = new Label();
			groupBox1 = new GroupBox();
			txtTienCoc = new TextBox();
			label8 = new Label();
			cbKhachHang = new ComboBox();
			dgvDanhSachTam = new DataGridView();
			cbNhanVien = new ComboBox();
			label6 = new Label();
			lblTongTien = new Label();
			btnDatPhong = new Button();
			groupBox2 = new GroupBox();
			dtpNgayTra = new DateTimePicker();
			btnThem = new Button();
			dtpNgayNhan = new DateTimePicker();
			label5 = new Label();
			btnXoa = new Button();
			label4 = new Label();
			label3 = new Label();
			lblGiaTien = new Label();
			cbPhong = new ComboBox();
			label10 = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDanhSachTam).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(33, 44);
			label1.Name = "label1";
			label1.Size = new Size(87, 20);
			label1.TabIndex = 0;
			label1.Text = "Nhân viên:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(8, 64);
			label2.Name = "label2";
			label2.Size = new Size(99, 20);
			label2.TabIndex = 1;
			label2.Text = "Khách hàng:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtTienCoc);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(cbKhachHang);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(12, 90);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(393, 198);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin";
			// 
			// txtTienCoc
			// 
			txtTienCoc.Font = new Font("Times New Roman", 10.8F);
			txtTienCoc.Location = new Point(114, 95);
			txtTienCoc.Name = "txtTienCoc";
			txtTienCoc.Size = new Size(259, 28);
			txtTienCoc.TabIndex = 13;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.Location = new Point(32, 98);
			label8.Name = "label8";
			label8.Size = new Size(75, 20);
			label8.TabIndex = 12;
			label8.Text = "Tiền cọc:";
			// 
			// cbKhachHang
			// 
			cbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
			cbKhachHang.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbKhachHang.FormattingEnabled = true;
			cbKhachHang.Location = new Point(114, 61);
			cbKhachHang.Name = "cbKhachHang";
			cbKhachHang.Size = new Size(259, 28);
			cbKhachHang.TabIndex = 8;
			// 
			// dgvDanhSachTam
			// 
			dgvDanhSachTam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDanhSachTam.Location = new Point(12, 307);
			dgvDanhSachTam.Name = "dgvDanhSachTam";
			dgvDanhSachTam.ReadOnly = true;
			dgvDanhSachTam.RowHeadersWidth = 51;
			dgvDanhSachTam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDanhSachTam.Size = new Size(959, 158);
			dgvDanhSachTam.TabIndex = 4;
			// 
			// cbNhanVien
			// 
			cbNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
			cbNhanVien.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbNhanVien.FormattingEnabled = true;
			cbNhanVien.Location = new Point(126, 41);
			cbNhanVien.Name = "cbNhanVien";
			cbNhanVien.Size = new Size(259, 28);
			cbNhanVien.TabIndex = 5;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
			label6.Location = new Point(41, 485);
			label6.Name = "label6";
			label6.Size = new Size(122, 25);
			label6.TabIndex = 5;
			label6.Text = "Tổng Tiền:";
			// 
			// lblTongTien
			// 
			lblTongTien.AutoSize = true;
			lblTongTien.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
			lblTongTien.ForeColor = Color.Red;
			lblTongTien.Location = new Point(169, 485);
			lblTongTien.Name = "lblTongTien";
			lblTongTien.Size = new Size(80, 25);
			lblTongTien.TabIndex = 6;
			lblTongTien.Text = "0 VND";
			// 
			// btnDatPhong
			// 
			btnDatPhong.Font = new Font("Times New Roman", 10.8F);
			btnDatPhong.Location = new Point(743, 479);
			btnDatPhong.Name = "btnDatPhong";
			btnDatPhong.Size = new Size(173, 40);
			btnDatPhong.TabIndex = 7;
			btnDatPhong.Text = "Đặt Phòng";
			btnDatPhong.UseVisualStyleBackColor = true;
			btnDatPhong.Click += btnDatPhong_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dtpNgayTra);
			groupBox2.Controls.Add(btnThem);
			groupBox2.Controls.Add(dtpNgayNhan);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(btnXoa);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(lblGiaTien);
			groupBox2.Controls.Add(cbPhong);
			groupBox2.Controls.Add(label10);
			groupBox2.Location = new Point(428, 41);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(543, 247);
			groupBox2.TabIndex = 12;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chọn Phòng";
			// 
			// dtpNgayTra
			// 
			dtpNgayTra.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpNgayTra.Location = new Point(172, 104);
			dtpNgayTra.Name = "dtpNgayTra";
			dtpNgayTra.Size = new Size(304, 28);
			dtpNgayTra.TabIndex = 16;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.8F);
			btnThem.Location = new Point(85, 179);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(106, 48);
			btnThem.TabIndex = 13;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// dtpNgayNhan
			// 
			dtpNgayNhan.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpNgayNhan.Location = new Point(172, 70);
			dtpNgayNhan.Name = "dtpNgayNhan";
			dtpNgayNhan.Size = new Size(304, 28);
			dtpNgayNhan.TabIndex = 15;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(31, 110);
			label5.Name = "label5";
			label5.Size = new Size(134, 20);
			label5.TabIndex = 14;
			label5.Text = "Ngày trả dự kiến:";
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.8F);
			btnXoa.Location = new Point(343, 179);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(106, 48);
			btnXoa.TabIndex = 12;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(15, 76);
			label4.Name = "label4";
			label4.Size = new Size(150, 20);
			label4.TabIndex = 13;
			label4.Text = "Ngày nhận dự kiến:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(64, 39);
			label3.Name = "label3";
			label3.Size = new Size(101, 20);
			label3.TabIndex = 2;
			label3.Text = "Chọn phòng:";
			// 
			// lblGiaTien
			// 
			lblGiaTien.AutoSize = true;
			lblGiaTien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblGiaTien.ForeColor = Color.Red;
			lblGiaTien.Location = new Point(172, 144);
			lblGiaTien.Name = "lblGiaTien";
			lblGiaTien.Size = new Size(66, 22);
			lblGiaTien.TabIndex = 11;
			lblGiaTien.Text = "0 VND";
			// 
			// cbPhong
			// 
			cbPhong.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPhong.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbPhong.FormattingEnabled = true;
			cbPhong.Location = new Point(172, 36);
			cbPhong.Name = "cbPhong";
			cbPhong.Size = new Size(304, 28);
			cbPhong.TabIndex = 9;
			cbPhong.SelectedIndexChanged += cbPhong_SelectedIndexChanged;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label10.Location = new Point(90, 144);
			label10.Name = "label10";
			label10.Size = new Size(75, 20);
			label10.TabIndex = 10;
			label10.Text = "Giá Tiền:";
			// 
			// frmTaoDon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(985, 535);
			Controls.Add(groupBox2);
			Controls.Add(btnDatPhong);
			Controls.Add(lblTongTien);
			Controls.Add(label6);
			Controls.Add(cbNhanVien);
			Controls.Add(dgvDanhSachTam);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Name = "frmTaoDon";
			Text = "Tạo Đơn Đặt Phòng";
			Load += frmTaoDon_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvDanhSachTam).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private GroupBox groupBox1;
		private DataGridView dgvDanhSachTam;
		private ComboBox cbNhanVien;
		private Label label6;
		private Label lblTongTien;
		private Button btnDatPhong;
		private DateTimePicker dtoNgay;
		private ComboBox cbKhachHang;
		private TextBox txtTienCoc;
		private Label label8;
		private GroupBox groupBox2;
		private Button btnThem;
		private Button btnXoa;
		private Label label3;
		private Label lblGiaTien;
		private ComboBox cbPhong;
		private Label label10;
		private DateTimePicker dtpNgayTra;
		private DateTimePicker dtpNgayNhan;
		private Label label5;
		private Label label4;
	}
}