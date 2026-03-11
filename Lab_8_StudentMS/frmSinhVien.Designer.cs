namespace Lab_8_StudentMS
{
    partial class frmSinhVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
			groupBox2 = new GroupBox();
			radioButton_Nam = new CheckBox();
			radioButton_Nu = new CheckBox();
			groupBox1 = new GroupBox();
			comboBox_MaKhoa = new ComboBox();
			label6 = new Label();
			label7 = new Label();
			label3 = new Label();
			dtp_NgaySinh = new DateTimePicker();
			txtMaSoSinhVien = new TextBox();
			label5 = new Label();
			label4 = new Label();
			txtDiaChi = new TextBox();
			txtSoDienThoai = new TextBox();
			label2 = new Label();
			txtHoTen = new TextBox();
			label1 = new Label();
			dataGridViewSinhVien = new DataGridView();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
			SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.Transparent;
			groupBox2.Controls.Add(radioButton_Nam);
			groupBox2.Controls.Add(radioButton_Nu);
			groupBox2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox2.ForeColor = Color.FromArgb(40, 39, 81);
			groupBox2.Location = new Point(225, 271);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(169, 73);
			groupBox2.TabIndex = 10;
			groupBox2.TabStop = false;
			groupBox2.Text = "Giới tính";
			// 
			// radioButton_Nam
			// 
			radioButton_Nam.AutoSize = true;
			radioButton_Nam.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			radioButton_Nam.Location = new Point(6, 26);
			radioButton_Nam.Name = "radioButton_Nam";
			radioButton_Nam.Size = new Size(70, 29);
			radioButton_Nam.TabIndex = 5;
			radioButton_Nam.Text = "Nam";
			radioButton_Nam.UseVisualStyleBackColor = true;
			// 
			// radioButton_Nu
			// 
			radioButton_Nu.AutoSize = true;
			radioButton_Nu.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			radioButton_Nu.Location = new Point(102, 26);
			radioButton_Nu.Name = "radioButton_Nu";
			radioButton_Nu.Size = new Size(61, 29);
			radioButton_Nu.TabIndex = 6;
			radioButton_Nu.Text = "Nữ";
			radioButton_Nu.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(comboBox_MaKhoa);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(dtp_NgaySinh);
			groupBox1.Controls.Add(txtMaSoSinhVien);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(txtSoDienThoai);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtHoTen);
			groupBox1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.ForeColor = Color.FromArgb(40, 39, 81);
			groupBox1.Location = new Point(48, 77);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(943, 176);
			groupBox1.TabIndex = 9;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin chi tiết";
			// 
			// comboBox_MaKhoa
			// 
			comboBox_MaKhoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			comboBox_MaKhoa.FormattingEnabled = true;
			comboBox_MaKhoa.Location = new Point(583, 129);
			comboBox_MaKhoa.Name = "comboBox_MaKhoa";
			comboBox_MaKhoa.Size = new Size(299, 27);
			comboBox_MaKhoa.TabIndex = 12;
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
			// dtp_NgaySinh
			// 
			dtp_NgaySinh.Font = new Font("Comic Sans MS", 9F);
			dtp_NgaySinh.Location = new Point(119, 130);
			dtp_NgaySinh.Name = "dtp_NgaySinh";
			dtp_NgaySinh.Size = new Size(299, 28);
			dtp_NgaySinh.TabIndex = 3;
			// 
			// txtMaSoSinhVien
			// 
			txtMaSoSinhVien.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtMaSoSinhVien.Location = new Point(119, 38);
			txtMaSoSinhVien.Name = "txtMaSoSinhVien";
			txtMaSoSinhVien.Size = new Size(299, 28);
			txtMaSoSinhVien.TabIndex = 9;
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
			// txtSoDienThoai
			// 
			txtSoDienThoai.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtSoDienThoai.Location = new Point(583, 38);
			txtSoDienThoai.Name = "txtSoDienThoai";
			txtSoDienThoai.Size = new Size(299, 28);
			txtSoDienThoai.TabIndex = 5;
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
			label1.Location = new Point(54, 9);
			label1.Name = "label1";
			label1.Size = new Size(919, 65);
			label1.TabIndex = 8;
			label1.Text = "Quản Lý Sinh Viên";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dataGridViewSinhVien
			// 
			dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewSinhVien.Location = new Point(12, 363);
			dataGridViewSinhVien.Name = "dataGridViewSinhVien";
			dataGridViewSinhVien.RowHeadersWidth = 51;
			dataGridViewSinhVien.Size = new Size(991, 275);
			dataGridViewSinhVien.TabIndex = 11;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(40, 39, 81);
			btnThem.Location = new Point(631, 271);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(102, 38);
			btnThem.TabIndex = 12;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(40, 39, 81);
			btnXoa.Location = new Point(631, 315);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(102, 38);
			btnXoa.TabIndex = 13;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnSua.ForeColor = Color.FromArgb(40, 39, 81);
			btnSua.Location = new Point(761, 271);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(102, 38);
			btnSua.TabIndex = 14;
			btnSua.Text = "Lưu";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// frmSinhVien
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(142, 172, 222);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(1016, 655);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(dataGridViewSinhVien);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			DoubleBuffered = true;
			Name = "frmSinhVien";
			Text = "frmSinhVien";
			Load += frmSinhVien_Load;
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox2;
		private CheckBox radioButton_Nam;
		private CheckBox radioButton_Nu;
		private GroupBox groupBox1;
		private Label label6;
		private Label label7;
		private Label label3;
		private DateTimePicker dtp_NgaySinh;
		private TextBox txtMaSoSinhVien;
		private Label label5;
		private Label label4;
		private TextBox txtDiaChi;
		private TextBox txtSoDienThoai;
		private Label label2;
		private TextBox txtHoTen;
		private Label label1;
		private DataGridView dataGridViewSinhVien;
		private ComboBox comboBox_MaKhoa;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
	}
}
