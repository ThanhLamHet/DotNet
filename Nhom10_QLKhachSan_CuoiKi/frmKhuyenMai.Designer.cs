namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmKhuyenMai
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
			groupBox2 = new GroupBox();
			dtpNgayKetThuc = new DateTimePicker();
			nudPhanTramKM = new NumericUpDown();
			label4 = new Label();
			label1 = new Label();
			dtpNgayBatDau = new DateTimePicker();
			txtMaKM = new TextBox();
			label3 = new Label();
			txtTenKM = new TextBox();
			label5 = new Label();
			label2 = new Label();
			dgvKhuyenMai = new DataGridView();
			groupBox1 = new GroupBox();
			txtTimKiem = new TextBox();
			bttTimKiem = new Button();
			label7 = new Label();
			bttSua = new Button();
			bttXoa = new Button();
			bttLamMoi = new Button();
			bttThem = new Button();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudPhanTramKM).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dtpNgayKetThuc);
			groupBox2.Controls.Add(nudPhanTramKM);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(dtpNgayBatDau);
			groupBox2.Controls.Add(txtMaKM);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(txtTenKM);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label2);
			groupBox2.Location = new Point(41, 53);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(528, 266);
			groupBox2.TabIndex = 22;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thông Tin Khuyến Mãi";
			// 
			// dtpNgayKetThuc
			// 
			dtpNgayKetThuc.Location = new Point(201, 211);
			dtpNgayKetThuc.Name = "dtpNgayKetThuc";
			dtpNgayKetThuc.Size = new Size(250, 27);
			dtpNgayKetThuc.TabIndex = 26;
			// 
			// nudPhanTramKM
			// 
			nudPhanTramKM.Location = new Point(201, 128);
			nudPhanTramKM.Name = "nudPhanTramKM";
			nudPhanTramKM.Size = new Size(250, 27);
			nudPhanTramKM.TabIndex = 25;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(40, 216);
			label4.Name = "label4";
			label4.Size = new Size(105, 20);
			label4.TabIndex = 24;
			label4.Text = "Ngày Kết Thúc";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(41, 174);
			label1.Name = "label1";
			label1.Size = new Size(101, 20);
			label1.TabIndex = 23;
			label1.Text = "Ngày Bắt Đầu";
			// 
			// dtpNgayBatDau
			// 
			dtpNgayBatDau.Location = new Point(201, 169);
			dtpNgayBatDau.Name = "dtpNgayBatDau";
			dtpNgayBatDau.Size = new Size(250, 27);
			dtpNgayBatDau.TabIndex = 21;
			// 
			// txtMaKM
			// 
			txtMaKM.Enabled = false;
			txtMaKM.ForeColor = SystemColors.WindowText;
			txtMaKM.Location = new Point(201, 41);
			txtMaKM.Multiline = true;
			txtMaKM.Name = "txtMaKM";
			txtMaKM.Size = new Size(253, 28);
			txtMaKM.TabIndex = 20;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(41, 49);
			label3.Name = "label3";
			label3.Size = new Size(111, 20);
			label3.TabIndex = 19;
			label3.Text = "Mã Khuyến Mãi";
			// 
			// txtTenKM
			// 
			txtTenKM.Location = new Point(201, 82);
			txtTenKM.Multiline = true;
			txtTenKM.Name = "txtTenKM";
			txtTenKM.Size = new Size(253, 28);
			txtTenKM.TabIndex = 17;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(41, 90);
			label5.Name = "label5";
			label5.Size = new Size(113, 20);
			label5.TabIndex = 12;
			label5.Text = "Tên Khuyến Mãi";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 130);
			label2.Name = "label2";
			label2.Size = new Size(159, 20);
			label2.TabIndex = 9;
			label2.Text = "Phần Trăm Khuyến Mãi";
			// 
			// dgvKhuyenMai
			// 
			dgvKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKhuyenMai.Location = new Point(12, 372);
			dgvKhuyenMai.Name = "dgvKhuyenMai";
			dgvKhuyenMai.RowHeadersWidth = 51;
			dgvKhuyenMai.Size = new Size(1093, 239);
			dgvKhuyenMai.TabIndex = 23;
			dgvKhuyenMai.CellClick += dgvKhuyenMai_CellClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtTimKiem);
			groupBox1.Controls.Add(bttTimKiem);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(bttSua);
			groupBox1.Controls.Add(bttXoa);
			groupBox1.Controls.Add(bttLamMoi);
			groupBox1.Controls.Add(bttThem);
			groupBox1.Location = new Point(575, 82);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(489, 184);
			groupBox1.TabIndex = 24;
			groupBox1.TabStop = false;
			groupBox1.Text = "Tính Năng";
			// 
			// txtTimKiem
			// 
			txtTimKiem.Location = new Point(84, 127);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(275, 27);
			txtTimKiem.TabIndex = 8;
			// 
			// bttTimKiem
			// 
			bttTimKiem.Location = new Point(368, 121);
			bttTimKiem.Name = "bttTimKiem";
			bttTimKiem.Size = new Size(105, 39);
			bttTimKiem.TabIndex = 7;
			bttTimKiem.Text = "🔍Tìm Kiếm";
			bttTimKiem.UseVisualStyleBackColor = true;
			bttTimKiem.Click += bttTimKiem_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 130);
			label7.Name = "label7";
			label7.Size = new Size(72, 20);
			label7.TabIndex = 5;
			label7.Text = "Tìm Kiếm";
			// 
			// bttSua
			// 
			bttSua.Location = new Point(137, 37);
			bttSua.Name = "bttSua";
			bttSua.Size = new Size(91, 39);
			bttSua.TabIndex = 4;
			bttSua.Text = "✏️Sửa";
			bttSua.UseVisualStyleBackColor = true;
			bttSua.Click += bttSua_Click;
			// 
			// bttXoa
			// 
			bttXoa.Location = new Point(255, 37);
			bttXoa.Name = "bttXoa";
			bttXoa.Size = new Size(91, 39);
			bttXoa.TabIndex = 3;
			bttXoa.Text = "🚫Xóa";
			bttXoa.UseVisualStyleBackColor = true;
			bttXoa.Click += bttXoa_Click;
			// 
			// bttLamMoi
			// 
			bttLamMoi.Location = new Point(368, 37);
			bttLamMoi.Name = "bttLamMoi";
			bttLamMoi.Size = new Size(105, 39);
			bttLamMoi.TabIndex = 2;
			bttLamMoi.Text = "🔄Làm Mới";
			bttLamMoi.UseVisualStyleBackColor = true;
			bttLamMoi.Click += bttLamMoi_Click;
			// 
			// bttThem
			// 
			bttThem.Location = new Point(22, 37);
			bttThem.Name = "bttThem";
			bttThem.Size = new Size(91, 39);
			bttThem.TabIndex = 1;
			bttThem.Text = "✚Thêm";
			bttThem.UseVisualStyleBackColor = true;
			bttThem.Click += bttThem_Click;
			// 
			// frmKhuyenMai
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1117, 623);
			Controls.Add(groupBox1);
			Controls.Add(dgvKhuyenMai);
			Controls.Add(groupBox2);
			Name = "frmKhuyenMai";
			Text = "frmKhuyenMai";
			Load += frmKhuyenMai_Load;
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudPhanTramKM).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox2;
        private TextBox txtMaKM;
        private Label label3;
        private TextBox txtTenKM;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dtpNgayBatDau;
        private DataGridView dgvKhuyenMai;
        private GroupBox groupBox1;
        private TextBox txtTimKiem;
        private Button bttTimKiem;
        private Label label7;
        private Button bttSua;
        private Button bttXoa;
        private Button bttLamMoi;
        private Button bttThem;
        private NumericUpDown nudPhanTramKM;
        private DateTimePicker dtpNgayKetThuc;
    }
}