namespace Lab9_QuanLyThuVien
{
	partial class frmMuonSach
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
			cbDocGia = new ComboBox();
			label1 = new Label();
			cbSach = new ComboBox();
			label3 = new Label();
			dgvPhieuMuon = new DataGridView();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			dgvChiTiet = new DataGridView();
			btnThem = new Button();
			btnLuuPhieu = new Button();
			dgvDanhSachChon = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvDanhSachChon).BeginInit();
			SuspendLayout();
			// 
			// cbDocGia
			// 
			cbDocGia.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbDocGia.FormattingEnabled = true;
			cbDocGia.Location = new Point(128, 27);
			cbDocGia.Name = "cbDocGia";
			cbDocGia.Size = new Size(250, 27);
			cbDocGia.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(55, 30);
			label1.Name = "label1";
			label1.Size = new Size(67, 19);
			label1.TabIndex = 38;
			label1.Text = "Độc giả:";
			// 
			// cbSach
			// 
			cbSach.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbSach.FormattingEnabled = true;
			cbSach.Location = new Point(532, 27);
			cbSach.Name = "cbSach";
			cbSach.Size = new Size(271, 27);
			cbSach.TabIndex = 41;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(480, 30);
			label3.Name = "label3";
			label3.Size = new Size(46, 19);
			label3.TabIndex = 42;
			label3.Text = "Sách:";
			label3.Click += label3_Click;
			// 
			// dgvPhieuMuon
			// 
			dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPhieuMuon.Location = new Point(6, 36);
			dgvPhieuMuon.Name = "dgvPhieuMuon";
			dgvPhieuMuon.RowHeadersWidth = 51;
			dgvPhieuMuon.Size = new Size(271, 362);
			dgvPhieuMuon.TabIndex = 43;
			dgvPhieuMuon.CellClick += dgvPhieuMuon_CellClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dgvPhieuMuon);
			groupBox1.Location = new Point(12, 214);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(283, 405);
			groupBox1.TabIndex = 45;
			groupBox1.TabStop = false;
			groupBox1.Text = "phiếu mượn";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dgvChiTiet);
			groupBox2.Location = new Point(454, 214);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(489, 405);
			groupBox2.TabIndex = 46;
			groupBox2.TabStop = false;
			groupBox2.Text = "chi tiết";
			// 
			// dgvChiTiet
			// 
			dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvChiTiet.Location = new Point(6, 26);
			dgvChiTiet.Name = "dgvChiTiet";
			dgvChiTiet.RowHeadersWidth = 51;
			dgvChiTiet.Size = new Size(477, 372);
			dgvChiTiet.TabIndex = 43;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(416, 101);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(110, 42);
			btnThem.TabIndex = 47;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThemSach_Click;
			// 
			// btnLuuPhieu
			// 
			btnLuuPhieu.Location = new Point(321, 267);
			btnLuuPhieu.Name = "btnLuuPhieu";
			btnLuuPhieu.Size = new Size(110, 42);
			btnLuuPhieu.TabIndex = 48;
			btnLuuPhieu.Text = "Lưu phiếu";
			btnLuuPhieu.UseVisualStyleBackColor = true;
			btnLuuPhieu.Click += btnLuuPhieu_Click;
			// 
			// dgvDanhSachChon
			// 
			dgvDanhSachChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDanhSachChon.Location = new Point(532, 74);
			dgvDanhSachChon.Name = "dgvDanhSachChon";
			dgvDanhSachChon.RowHeadersWidth = 51;
			dgvDanhSachChon.Size = new Size(271, 109);
			dgvDanhSachChon.TabIndex = 44;
			// 
			// frmMuonSach
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(955, 631);
			Controls.Add(dgvDanhSachChon);
			Controls.Add(btnLuuPhieu);
			Controls.Add(btnThem);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label3);
			Controls.Add(cbSach);
			Controls.Add(label1);
			Controls.Add(cbDocGia);
			Name = "frmMuonSach";
			Text = "frmMuonSach";
			Load += frmMuonSach_Load;
			((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvDanhSachChon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbDocGia;
		private Label label1;
		private ComboBox cbSach;
		private Label label3;
		private DataGridView dgvPhieuMuon;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private DataGridView dgvChiTiet;
		private Button btnThem;
		private Button btnLuuPhieu;
		private DataGridView dgvDanhSachChon;
	}
}