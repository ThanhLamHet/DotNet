namespace Lab8_QuanLySV
{
	partial class FormKetQua
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
			txtTim = new TextBox();
			btnTim = new Button();
			btnLamMoi = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			btnThem = new Button();
			label3 = new Label();
			txtDiem = new TextBox();
			dgvKetQua = new DataGridView();
			cbSinhVien = new ComboBox();
			cbMon = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(40, 39, 81);
			label1.Location = new Point(197, 121);
			label1.Name = "label1";
			label1.Size = new Size(83, 20);
			label1.TabIndex = 53;
			label1.Text = "Môn học:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(40, 39, 81);
			label2.Location = new Point(194, 78);
			label2.Name = "label2";
			label2.Size = new Size(86, 20);
			label2.TabIndex = 51;
			label2.Text = "Sinh viên:";
			// 
			// txtTim
			// 
			txtTim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtTim.Location = new Point(202, 326);
			txtTim.Name = "txtTim";
			txtTim.Size = new Size(263, 28);
			txtTim.TabIndex = 44;
			// 
			// btnTim
			// 
			btnTim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnTim.ForeColor = Color.FromArgb(40, 39, 81);
			btnTim.Location = new Point(471, 320);
			btnTim.Name = "btnTim";
			btnTim.Size = new Size(114, 38);
			btnTim.TabIndex = 49;
			btnTim.Text = "Tìm Kiếm";
			btnTim.UseVisualStyleBackColor = true;
			btnTim.Click += btnTim_Click;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnLamMoi.ForeColor = Color.FromArgb(40, 39, 81);
			btnLamMoi.Location = new Point(536, 238);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(114, 62);
			btnLamMoi.TabIndex = 48;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnSua.ForeColor = Color.FromArgb(40, 39, 81);
			btnSua.Location = new Point(406, 238);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(114, 62);
			btnSua.TabIndex = 47;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(40, 39, 81);
			btnXoa.Location = new Point(278, 238);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(114, 62);
			btnXoa.TabIndex = 46;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(40, 39, 81);
			btnThem.Location = new Point(151, 238);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(114, 62);
			btnThem.TabIndex = 45;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(40, 39, 81);
			label3.Location = new Point(225, 166);
			label3.Name = "label3";
			label3.Size = new Size(55, 20);
			label3.TabIndex = 55;
			label3.Text = "Điểm:";
			// 
			// txtDiem
			// 
			txtDiem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtDiem.Location = new Point(286, 163);
			txtDiem.Name = "txtDiem";
			txtDiem.Size = new Size(299, 28);
			txtDiem.TabIndex = 54;
			// 
			// dgvKetQua
			// 
			dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKetQua.Location = new Point(12, 395);
			dgvKetQua.Name = "dgvKetQua";
			dgvKetQua.RowHeadersWidth = 51;
			dgvKetQua.Size = new Size(786, 280);
			dgvKetQua.TabIndex = 56;
			dgvKetQua.SelectionChanged += dgvKetQua_SelectionChanged;
			// 
			// cbSinhVien
			// 
			cbSinhVien.FormattingEnabled = true;
			cbSinhVien.Location = new Point(286, 75);
			cbSinhVien.Name = "cbSinhVien";
			cbSinhVien.Size = new Size(299, 28);
			cbSinhVien.TabIndex = 57;
			// 
			// cbMon
			// 
			cbMon.FormattingEnabled = true;
			cbMon.Location = new Point(286, 118);
			cbMon.Name = "cbMon";
			cbMon.Size = new Size(299, 28);
			cbMon.TabIndex = 58;
			// 
			// FormKetQua
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(810, 687);
			Controls.Add(cbMon);
			Controls.Add(cbSinhVien);
			Controls.Add(dgvKetQua);
			Controls.Add(label3);
			Controls.Add(txtDiem);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(txtTim);
			Controls.Add(btnTim);
			Controls.Add(btnLamMoi);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Name = "FormKetQua";
			Text = "FormKetQua";
			Load += FormKetQua_Load;
			((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtTim;
		private Button btnTim;
		private Button btnLamMoi;
		private Button btnSua;
		private Button btnXoa;
		private Button btnThem;
		private Label label3;
		private TextBox txtDiem;
		private DataGridView dgvKetQua;
		private ComboBox cbSinhVien;
		private ComboBox cbMon;
	}
}