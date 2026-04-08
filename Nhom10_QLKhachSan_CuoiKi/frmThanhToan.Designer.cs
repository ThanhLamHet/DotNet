namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmThanhToan
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
			cboDonDP = new ComboBox();
			label2 = new Label();
			txtTenKH = new TextBox();
			txtTenNV = new TextBox();
			label3 = new Label();
			label4 = new Label();
			dtpNgayTT = new DateTimePicker();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			btnTongTien = new Button();
			label17 = new Label();
			lblTongTien = new Label();
			label19 = new Label();
			label15 = new Label();
			lblTienGiam = new Label();
			label14 = new Label();
			cboMaKM = new ComboBox();
			label13 = new Label();
			label9 = new Label();
			txtPhuThu = new TextBox();
			label11 = new Label();
			label12 = new Label();
			label10 = new Label();
			lblTienDV = new Label();
			label8 = new Label();
			lblTienPhong = new Label();
			label5 = new Label();
			dgvPhong = new DataGridView();
			groupBox3 = new GroupBox();
			groupBox4 = new GroupBox();
			dgvDichVu = new DataGridView();
			groupBox5 = new GroupBox();
			btnInHoaDon = new Button();
			btnThanhToan = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
			groupBox5.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 33);
			label1.Name = "label1";
			label1.Size = new Size(133, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã đơn đặt phòng";
			// 
			// cboDonDP
			// 
			cboDonDP.DropDownStyle = ComboBoxStyle.DropDownList;
			cboDonDP.FormattingEnabled = true;
			cboDonDP.Location = new Point(209, 30);
			cboDonDP.Margin = new Padding(3, 4, 3, 4);
			cboDonDP.Name = "cboDonDP";
			cboDonDP.Size = new Size(228, 28);
			cboDonDP.TabIndex = 1;
			cboDonDP.SelectedIndexChanged += cboDonDP_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(45, 85);
			label2.Name = "label2";
			label2.Size = new Size(111, 20);
			label2.TabIndex = 2;
			label2.Text = "Tên khách hàng";
			// 
			// txtTenKH
			// 
			txtTenKH.Enabled = false;
			txtTenKH.Location = new Point(209, 82);
			txtTenKH.Margin = new Padding(3, 4, 3, 4);
			txtTenKH.Name = "txtTenKH";
			txtTenKH.Size = new Size(228, 27);
			txtTenKH.TabIndex = 3;
			// 
			// txtTenNV
			// 
			txtTenNV.Enabled = false;
			txtTenNV.Location = new Point(209, 141);
			txtTenNV.Margin = new Padding(3, 4, 3, 4);
			txtTenNV.Name = "txtTenNV";
			txtTenNV.Size = new Size(228, 27);
			txtTenNV.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(57, 144);
			label3.Name = "label3";
			label3.Size = new Size(99, 20);
			label3.TabIndex = 4;
			label3.Text = "Tên nhân viên";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(37, 209);
			label4.Name = "label4";
			label4.Size = new Size(119, 20);
			label4.TabIndex = 6;
			label4.Text = "Ngày thanh toán";
			// 
			// dtpNgayTT
			// 
			dtpNgayTT.CustomFormat = "dd/MM/yyyy";
			dtpNgayTT.Enabled = false;
			dtpNgayTT.Format = DateTimePickerFormat.Custom;
			dtpNgayTT.Location = new Point(209, 202);
			dtpNgayTT.Margin = new Padding(3, 4, 3, 4);
			dtpNgayTT.Name = "dtpNgayTT";
			dtpNgayTT.Size = new Size(228, 27);
			dtpNgayTT.TabIndex = 7;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top;
			groupBox1.Controls.Add(dtpNgayTT);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtTenNV);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(txtTenKH);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(cboDonDP);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 13);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(467, 260);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin cơ bản";
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top;
			groupBox2.Controls.Add(btnTongTien);
			groupBox2.Controls.Add(label17);
			groupBox2.Controls.Add(lblTongTien);
			groupBox2.Controls.Add(label19);
			groupBox2.Controls.Add(label15);
			groupBox2.Controls.Add(lblTienGiam);
			groupBox2.Controls.Add(label14);
			groupBox2.Controls.Add(cboMaKM);
			groupBox2.Controls.Add(label13);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(txtPhuThu);
			groupBox2.Controls.Add(label11);
			groupBox2.Controls.Add(label12);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(lblTienDV);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(lblTienPhong);
			groupBox2.Controls.Add(label5);
			groupBox2.Location = new Point(12, 281);
			groupBox2.Margin = new Padding(3, 4, 3, 4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(3, 4, 3, 4);
			groupBox2.Size = new Size(467, 372);
			groupBox2.TabIndex = 9;
			groupBox2.TabStop = false;
			groupBox2.Text = "Danh sách mục chi";
			// 
			// btnTongTien
			// 
			btnTongTien.Location = new Point(293, 272);
			btnTongTien.Margin = new Padding(3, 4, 3, 4);
			btnTongTien.Name = "btnTongTien";
			btnTongTien.Size = new Size(139, 31);
			btnTongTien.TabIndex = 23;
			btnTongTien.Text = "Tính tổng tiền";
			btnTongTien.UseVisualStyleBackColor = true;
			btnTongTien.Click += btnTongTien_Click;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.ForeColor = Color.Red;
			label17.Location = new Point(397, 324);
			label17.Name = "label17";
			label17.Size = new Size(40, 20);
			label17.TabIndex = 22;
			label17.Text = "VND";
			// 
			// lblTongTien
			// 
			lblTongTien.AutoSize = true;
			lblTongTien.ForeColor = Color.Red;
			lblTongTien.Location = new Point(204, 324);
			lblTongTien.Name = "lblTongTien";
			lblTongTien.Size = new Size(17, 20);
			lblTongTien.TabIndex = 21;
			lblTongTien.Text = "0";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.ForeColor = Color.Red;
			label19.Location = new Point(81, 323);
			label19.Name = "label19";
			label19.Size = new Size(75, 20);
			label19.TabIndex = 20;
			label19.Text = "Tổng tiền:";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(397, 232);
			label15.Name = "label15";
			label15.Size = new Size(40, 20);
			label15.TabIndex = 19;
			label15.Text = "VND";
			// 
			// lblTienGiam
			// 
			lblTienGiam.AutoSize = true;
			lblTienGiam.Location = new Point(204, 232);
			lblTienGiam.Name = "lblTienGiam";
			lblTienGiam.Size = new Size(17, 20);
			lblTienGiam.TabIndex = 18;
			lblTienGiam.Text = "0";
			lblTienGiam.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(109, 232);
			label14.Name = "label14";
			label14.Size = new Size(47, 20);
			label14.TabIndex = 17;
			label14.Text = "Giảm:";
			// 
			// cboMaKM
			// 
			cboMaKM.DropDownStyle = ComboBoxStyle.DropDownList;
			cboMaKM.FormattingEnabled = true;
			cboMaKM.Location = new Point(204, 177);
			cboMaKM.Margin = new Padding(3, 4, 3, 4);
			cboMaKM.Name = "cboMaKM";
			cboMaKM.Size = new Size(228, 28);
			cboMaKM.TabIndex = 8;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(397, 129);
			label13.Name = "label13";
			label13.Size = new Size(40, 20);
			label13.TabIndex = 16;
			label13.Text = "VND";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(397, 84);
			label9.Name = "label9";
			label9.Size = new Size(40, 20);
			label9.TabIndex = 15;
			label9.Text = "VND";
			// 
			// txtPhuThu
			// 
			txtPhuThu.Location = new Point(204, 125);
			txtPhuThu.Margin = new Padding(3, 4, 3, 4);
			txtPhuThu.Name = "txtPhuThu";
			txtPhuThu.Size = new Size(173, 27);
			txtPhuThu.TabIndex = 8;
			txtPhuThu.TextAlign = HorizontalAlignment.Right;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(397, 41);
			label11.Name = "label11";
			label11.Size = new Size(40, 20);
			label11.TabIndex = 14;
			label11.Text = "VND";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(44, 185);
			label12.Name = "label12";
			label12.Size = new Size(112, 20);
			label12.TabIndex = 13;
			label12.Text = "Mã khuyến mãi:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(95, 129);
			label10.Name = "label10";
			label10.Size = new Size(61, 20);
			label10.TabIndex = 11;
			label10.Text = "Phụ thu:";
			// 
			// lblTienDV
			// 
			lblTienDV.AutoSize = true;
			lblTienDV.Location = new Point(204, 84);
			lblTienDV.Name = "lblTienDV";
			lblTienDV.Size = new Size(17, 20);
			lblTienDV.TabIndex = 10;
			lblTienDV.Text = "0";
			lblTienDV.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(65, 84);
			label8.Name = "label8";
			label8.Size = new Size(91, 20);
			label8.TabIndex = 9;
			label8.Text = "Tiền dịch vụ:";
			// 
			// lblTienPhong
			// 
			lblTienPhong.AutoSize = true;
			lblTienPhong.Location = new Point(204, 41);
			lblTienPhong.Name = "lblTienPhong";
			lblTienPhong.Size = new Size(17, 20);
			lblTienPhong.TabIndex = 8;
			lblTienPhong.Text = "0";
			lblTienPhong.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(69, 41);
			label5.Name = "label5";
			label5.Size = new Size(87, 20);
			label5.TabIndex = 7;
			label5.Text = "Tiền phòng:";
			// 
			// dgvPhong
			// 
			dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPhong.Location = new Point(7, 29);
			dgvPhong.Margin = new Padding(3, 4, 3, 4);
			dgvPhong.Name = "dgvPhong";
			dgvPhong.RowHeadersWidth = 51;
			dgvPhong.Size = new Size(541, 223);
			dgvPhong.TabIndex = 10;
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top;
			groupBox3.Controls.Add(dgvPhong);
			groupBox3.Location = new Point(500, 13);
			groupBox3.Margin = new Padding(3, 4, 3, 4);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(3, 4, 3, 4);
			groupBox3.Size = new Size(554, 260);
			groupBox3.TabIndex = 11;
			groupBox3.TabStop = false;
			groupBox3.Text = "Danh sách phòng đã thuê";
			// 
			// groupBox4
			// 
			groupBox4.Anchor = AnchorStyles.Top;
			groupBox4.Controls.Add(dgvDichVu);
			groupBox4.Location = new Point(500, 281);
			groupBox4.Margin = new Padding(3, 4, 3, 4);
			groupBox4.Name = "groupBox4";
			groupBox4.Padding = new Padding(3, 4, 3, 4);
			groupBox4.Size = new Size(554, 271);
			groupBox4.TabIndex = 12;
			groupBox4.TabStop = false;
			groupBox4.Text = "Danh sách dịch vụ đã sử dụng";
			// 
			// dgvDichVu
			// 
			dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDichVu.Location = new Point(7, 28);
			dgvDichVu.Margin = new Padding(3, 4, 3, 4);
			dgvDichVu.Name = "dgvDichVu";
			dgvDichVu.RowHeadersWidth = 51;
			dgvDichVu.Size = new Size(541, 235);
			dgvDichVu.TabIndex = 10;
			// 
			// groupBox5
			// 
			groupBox5.Anchor = AnchorStyles.Top;
			groupBox5.Controls.Add(btnInHoaDon);
			groupBox5.Controls.Add(btnThanhToan);
			groupBox5.Location = new Point(503, 565);
			groupBox5.Margin = new Padding(3, 4, 3, 4);
			groupBox5.Name = "groupBox5";
			groupBox5.Padding = new Padding(3, 4, 3, 4);
			groupBox5.Size = new Size(353, 85);
			groupBox5.TabIndex = 13;
			groupBox5.TabStop = false;
			groupBox5.Text = "Tính năng";
			// 
			// btnInHoaDon
			// 
			btnInHoaDon.Location = new Point(82, 25);
			btnInHoaDon.Margin = new Padding(3, 4, 3, 4);
			btnInHoaDon.Name = "btnInHoaDon";
			btnInHoaDon.Size = new Size(103, 49);
			btnInHoaDon.TabIndex = 1;
			btnInHoaDon.Text = "In hóa đơn";
			btnInHoaDon.UseVisualStyleBackColor = true;
			btnInHoaDon.Click += btnInHoaDon_Click;
			// 
			// btnThanhToan
			// 
			btnThanhToan.Location = new Point(243, 25);
			btnThanhToan.Margin = new Padding(3, 4, 3, 4);
			btnThanhToan.Name = "btnThanhToan";
			btnThanhToan.Size = new Size(103, 49);
			btnThanhToan.TabIndex = 0;
			btnThanhToan.Text = "Thanh toán";
			btnThanhToan.UseVisualStyleBackColor = true;
			btnThanhToan.Click += btnThanhToan_Click;
			// 
			// frmThanhToan
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1092, 665);
			Controls.Add(groupBox5);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmThanhToan";
			Text = "Thanh toán đơn";
			Load += frmThanhToan_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
			groupBox3.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
			groupBox5.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
        private ComboBox cboDonDP;
        private Label label2;
        private TextBox txtTenKH;
        private TextBox txtTenNV;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNgayTT;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label10;
        private Label lblTienDV;
        private Label label8;
        private Label lblTienPhong;
        private Label label5;
        private Label label15;
        private Label lblTienGiam;
        private Label label14;
        private ComboBox cboMaKM;
        private Label label13;
        private Label label9;
        private TextBox txtPhuThu;
        private Label label11;
        private Label label12;
        private Label label17;
        private Label lblTongTien;
        private Label label19;
        private Button btnTongTien;
        private DataGridView dgvPhong;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvDichVu;
        private GroupBox groupBox5;
        private Button btnInHoaDon;
        private Button btnThanhToan;
    }
}