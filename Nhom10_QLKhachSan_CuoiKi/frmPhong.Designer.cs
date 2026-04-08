namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmPhong
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
			dgvPhong = new DataGridView();
			groupBox1 = new GroupBox();
			btnLamMoi = new Button();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			txtGia = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label2 = new Label();
			txtMaPhong = new TextBox();
			label1 = new Label();
			txtMoTa = new TextBox();
			label5 = new Label();
			txtTenPhong = new TextBox();
			label6 = new Label();
			cboLoaiPhong = new ComboBox();
			cboTrangThai = new ComboBox();
			groupBox2 = new GroupBox();
			btnLoc = new Button();
			cbLocTrangThai = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvPhong
			// 
			dgvPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPhong.Location = new Point(26, 352);
			dgvPhong.Margin = new Padding(3, 4, 3, 4);
			dgvPhong.Name = "dgvPhong";
			dgvPhong.RowHeadersWidth = 51;
			dgvPhong.Size = new Size(703, 211);
			dgvPhong.TabIndex = 24;
			dgvPhong.CellContentClick += dgvPhong_CellContentClick;
			dgvPhong.SelectionChanged += dgvPhong_SelectionChanged;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top;
			groupBox1.Controls.Add(btnLamMoi);
			groupBox1.Controls.Add(btnThem);
			groupBox1.Controls.Add(btnXoa);
			groupBox1.Controls.Add(btnSua);
			groupBox1.Location = new Point(415, 226);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(276, 78);
			groupBox1.TabIndex = 23;
			groupBox1.TabStop = false;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLamMoi.Location = new Point(205, 20);
			btnLamMoi.Margin = new Padding(3, 4, 3, 4);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(56, 39);
			btnLamMoi.TabIndex = 12;
			btnLamMoi.Text = "⟳";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnThem.Location = new Point(16, 20);
			btnThem.Margin = new Padding(3, 4, 3, 4);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(56, 39);
			btnThem.TabIndex = 9;
			btnThem.Text = "+";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnXoa.Location = new Point(142, 20);
			btnXoa.Margin = new Padding(3, 4, 3, 4);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(56, 39);
			btnXoa.TabIndex = 11;
			btnXoa.Text = "🗑️";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSua.Location = new Point(79, 20);
			btnSua.Margin = new Padding(3, 4, 3, 4);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(56, 39);
			btnSua.TabIndex = 10;
			btnSua.Text = "✏️";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// txtGia
			// 
			txtGia.Anchor = AnchorStyles.Top;
			txtGia.Enabled = false;
			txtGia.Location = new Point(473, 83);
			txtGia.Margin = new Padding(3, 4, 3, 4);
			txtGia.Name = "txtGia";
			txtGia.Size = new Size(190, 27);
			txtGia.TabIndex = 21;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top;
			label3.AutoSize = true;
			label3.Location = new Point(377, 87);
			label3.Name = "label3";
			label3.Size = new Size(31, 20);
			label3.TabIndex = 20;
			label3.Text = "Giá";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top;
			label4.AutoSize = true;
			label4.Location = new Point(377, 30);
			label4.Name = "label4";
			label4.Size = new Size(75, 20);
			label4.TabIndex = 19;
			label4.Text = "Trạng thái";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top;
			label2.AutoSize = true;
			label2.Location = new Point(44, 87);
			label2.Name = "label2";
			label2.Size = new Size(84, 20);
			label2.TabIndex = 17;
			label2.Text = "Loại phòng";
			// 
			// txtMaPhong
			// 
			txtMaPhong.Anchor = AnchorStyles.Top;
			txtMaPhong.Enabled = false;
			txtMaPhong.Location = new Point(148, 26);
			txtMaPhong.Margin = new Padding(3, 4, 3, 4);
			txtMaPhong.Name = "txtMaPhong";
			txtMaPhong.Size = new Size(190, 27);
			txtMaPhong.TabIndex = 16;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Location = new Point(44, 30);
			label1.Name = "label1";
			label1.Size = new Size(77, 20);
			label1.TabIndex = 15;
			label1.Text = "Mã phòng";
			// 
			// txtMoTa
			// 
			txtMoTa.Anchor = AnchorStyles.Top;
			txtMoTa.Location = new Point(473, 143);
			txtMoTa.Margin = new Padding(3, 4, 3, 4);
			txtMoTa.Name = "txtMoTa";
			txtMoTa.Size = new Size(190, 27);
			txtMoTa.TabIndex = 28;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top;
			label5.AutoSize = true;
			label5.Location = new Point(377, 147);
			label5.Name = "label5";
			label5.Size = new Size(48, 20);
			label5.TabIndex = 27;
			label5.Text = "Mô tả";
			// 
			// txtTenPhong
			// 
			txtTenPhong.Anchor = AnchorStyles.Top;
			txtTenPhong.Location = new Point(148, 143);
			txtTenPhong.Margin = new Padding(3, 4, 3, 4);
			txtTenPhong.Name = "txtTenPhong";
			txtTenPhong.Size = new Size(190, 27);
			txtTenPhong.TabIndex = 26;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Top;
			label6.AutoSize = true;
			label6.Location = new Point(44, 147);
			label6.Name = "label6";
			label6.Size = new Size(79, 20);
			label6.TabIndex = 25;
			label6.Text = "Tên phòng";
			// 
			// cboLoaiPhong
			// 
			cboLoaiPhong.Anchor = AnchorStyles.Top;
			cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
			cboLoaiPhong.FormattingEnabled = true;
			cboLoaiPhong.Location = new Point(148, 83);
			cboLoaiPhong.Margin = new Padding(3, 4, 3, 4);
			cboLoaiPhong.Name = "cboLoaiPhong";
			cboLoaiPhong.Size = new Size(190, 28);
			cboLoaiPhong.TabIndex = 29;
			// 
			// cboTrangThai
			// 
			cboTrangThai.Anchor = AnchorStyles.Top;
			cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
			cboTrangThai.Enabled = false;
			cboTrangThai.FormattingEnabled = true;
			cboTrangThai.Items.AddRange(new object[] { "Trống", "Đã đặt trước", "Có khách" });
			cboTrangThai.Location = new Point(473, 26);
			cboTrangThai.Margin = new Padding(3, 4, 3, 4);
			cboTrangThai.Name = "cboTrangThai";
			cboTrangThai.Size = new Size(190, 28);
			cboTrangThai.TabIndex = 30;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top;
			groupBox2.Controls.Add(btnLoc);
			groupBox2.Controls.Add(cbLocTrangThai);
			groupBox2.Location = new Point(63, 212);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(316, 92);
			groupBox2.TabIndex = 31;
			groupBox2.TabStop = false;
			groupBox2.Text = "Lọc Trạng Thái";
			// 
			// btnLoc
			// 
			btnLoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLoc.Location = new Point(235, 34);
			btnLoc.Margin = new Padding(3, 4, 3, 4);
			btnLoc.Name = "btnLoc";
			btnLoc.Size = new Size(56, 39);
			btnLoc.TabIndex = 10;
			btnLoc.Text = "Lọc";
			btnLoc.UseVisualStyleBackColor = true;
			btnLoc.Click += btnLoc_Click;
			// 
			// cbLocTrangThai
			// 
			cbLocTrangThai.FormattingEnabled = true;
			cbLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Trống", "Đã đặt trước", "Có khách" });
			cbLocTrangThai.Location = new Point(6, 42);
			cbLocTrangThai.Name = "cbLocTrangThai";
			cbLocTrangThai.Size = new Size(214, 28);
			cbLocTrangThai.TabIndex = 0;
			// 
			// frmPhong
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(753, 578);
			Controls.Add(groupBox2);
			Controls.Add(cboTrangThai);
			Controls.Add(cboLoaiPhong);
			Controls.Add(txtMoTa);
			Controls.Add(label5);
			Controls.Add(txtTenPhong);
			Controls.Add(label6);
			Controls.Add(dgvPhong);
			Controls.Add(groupBox1);
			Controls.Add(txtGia);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(txtMaPhong);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmPhong";
			Text = "Quản lý phòng";
			Load += frmPhong_Load;
			((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvPhong;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtGia;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox txtMaPhong;
        private Label label1;
        private TextBox txtMoTa;
        private Label label5;
        private TextBox txtTenPhong;
        private Label label6;
        private ComboBox cboLoaiPhong;
        private ComboBox cboTrangThai;
		private GroupBox groupBox2;
		private ComboBox cbLocTrangThai;
		private Button btnLoc;
	}
}