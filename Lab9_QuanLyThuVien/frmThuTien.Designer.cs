namespace Lab9_QuanLyThuVien
{
	partial class frmThuTien
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
			cbNhanVien = new ComboBox();
			label2 = new Label();
			label1 = new Label();
			label3 = new Label();
			cbDocGia = new ComboBox();
			groupBox1 = new GroupBox();
			nudSoTienThu = new NumericUpDown();
			label5 = new Label();
			lblSoTienNo = new Label();
			btnLuu = new Button();
			btnLamMoi = new Button();
			btnXoa = new Button();
			txtTimKiem = new TextBox();
			btnTim = new Button();
			dgvPhieuThu = new DataGridView();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudSoTienThu).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvPhieuThu).BeginInit();
			SuspendLayout();
			// 
			// cbNhanVien
			// 
			cbNhanVien.FormattingEnabled = true;
			cbNhanVien.Location = new Point(124, 28);
			cbNhanVien.Name = "cbNhanVien";
			cbNhanVien.Size = new Size(258, 28);
			cbNhanVien.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.2F);
			label2.Location = new Point(68, 93);
			label2.Name = "label2";
			label2.Size = new Size(62, 19);
			label2.TabIndex = 26;
			label2.Text = "Số tiền:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.2F);
			label1.Location = new Point(37, 32);
			label1.Name = "label1";
			label1.Size = new Size(81, 19);
			label1.TabIndex = 25;
			label1.Text = "Nhân viên:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.2F);
			label3.Location = new Point(57, 47);
			label3.Name = "label3";
			label3.Size = new Size(71, 19);
			label3.TabIndex = 32;
			label3.Text = "Độc Giả:";
			// 
			// cbDocGia
			// 
			cbDocGia.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbDocGia.FormattingEnabled = true;
			cbDocGia.Location = new Point(134, 43);
			cbDocGia.Name = "cbDocGia";
			cbDocGia.Size = new Size(258, 27);
			cbDocGia.TabIndex = 31;
			cbDocGia.SelectedIndexChanged += cbDocGia_SelectedIndexChanged;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(nudSoTienThu);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(lblSoTienNo);
			groupBox1.Controls.Add(cbDocGia);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(37, 95);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(406, 194);
			groupBox1.TabIndex = 33;
			groupBox1.TabStop = false;
			groupBox1.Text = "groupBox1";
			// 
			// nudSoTienThu
			// 
			nudSoTienThu.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nudSoTienThu.Location = new Point(134, 151);
			nudSoTienThu.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			nudSoTienThu.Name = "nudSoTienThu";
			nudSoTienThu.Size = new Size(258, 27);
			nudSoTienThu.TabIndex = 35;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Times New Roman", 10.2F);
			label5.Location = new Point(41, 154);
			label5.Name = "label5";
			label5.Size = new Size(87, 19);
			label5.TabIndex = 34;
			label5.Text = "Số tiền thu:";
			// 
			// lblSoTienNo
			// 
			lblSoTienNo.AutoSize = true;
			lblSoTienNo.Font = new Font("Times New Roman", 10.2F);
			lblSoTienNo.ForeColor = Color.Red;
			lblSoTienNo.Location = new Point(134, 93);
			lblSoTienNo.Name = "lblSoTienNo";
			lblSoTienNo.Size = new Size(57, 19);
			lblSoTienNo.TabIndex = 33;
			lblSoTienNo.Text = "0 VND";
			// 
			// btnLuu
			// 
			btnLuu.Font = new Font("Times New Roman", 10.2F);
			btnLuu.Location = new Point(493, 122);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(106, 39);
			btnLuu.TabIndex = 37;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Times New Roman", 10.2F);
			btnLamMoi.Location = new Point(493, 229);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(106, 39);
			btnLamMoi.TabIndex = 39;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.2F);
			btnXoa.Location = new Point(493, 178);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(106, 39);
			btnXoa.TabIndex = 40;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Font = new Font("Times New Roman", 10.2F);
			txtTimKiem.Location = new Point(146, 320);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(258, 27);
			txtTimKiem.TabIndex = 42;
			// 
			// btnTim
			// 
			btnTim.Font = new Font("Times New Roman", 10.2F);
			btnTim.Location = new Point(410, 311);
			btnTim.Name = "btnTim";
			btnTim.Size = new Size(107, 42);
			btnTim.TabIndex = 41;
			btnTim.Text = "Tìm Kiếm";
			btnTim.UseVisualStyleBackColor = true;
			btnTim.Click += btnTim_Click;
			// 
			// dgvPhieuThu
			// 
			dgvPhieuThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPhieuThu.Location = new Point(12, 375);
			dgvPhieuThu.Name = "dgvPhieuThu";
			dgvPhieuThu.RowHeadersWidth = 51;
			dgvPhieuThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvPhieuThu.Size = new Size(609, 305);
			dgvPhieuThu.TabIndex = 48;
			// 
			// frmThuTien
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(633, 692);
			Controls.Add(dgvPhieuThu);
			Controls.Add(txtTimKiem);
			Controls.Add(btnTim);
			Controls.Add(btnXoa);
			Controls.Add(btnLamMoi);
			Controls.Add(btnLuu);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(cbNhanVien);
			Name = "frmThuTien";
			Text = "frmThuTien";
			Load += frmThuTien_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudSoTienThu).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvPhieuThu).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbNhanVien;
		private Label label2;
		private Label label1;
		private Label label3;
		private ComboBox cbDocGia;
		private GroupBox groupBox1;
		private Label lblSoTienNo;
		private Button btnLuu;
		private Button btnLamMoi;
		private Label label5;
		private NumericUpDown nudSoTienThu;
		private Button btnXoa;
		private TextBox txtTimKiem;
		private Button btnTim;
		private DataGridView dgvPhieuThu;
	}
}