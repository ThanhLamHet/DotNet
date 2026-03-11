namespace Lab8_QuanLySV
{
	partial class FormKhoa
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
			dgvKhoa = new DataGridView();
			label1 = new Label();
			txtTenKhoa = new TextBox();
			label2 = new Label();
			txtMaKhoa = new TextBox();
			txtTim = new TextBox();
			btnTim = new Button();
			btnLamMoi = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			btnThem = new Button();
			((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
			SuspendLayout();
			// 
			// dgvKhoa
			// 
			dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKhoa.Location = new Point(12, 423);
			dgvKhoa.Name = "dgvKhoa";
			dgvKhoa.RowHeadersWidth = 51;
			dgvKhoa.Size = new Size(632, 233);
			dgvKhoa.TabIndex = 44;
			dgvKhoa.SelectionChanged += dgvKhoa_SelectionChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(40, 39, 81);
			label1.Location = new Point(112, 169);
			label1.Name = "label1";
			label1.Size = new Size(91, 20);
			label1.TabIndex = 43;
			label1.Text = "Tên Khoa:";
			// 
			// txtTenKhoa
			// 
			txtTenKhoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtTenKhoa.Location = new Point(209, 166);
			txtTenKhoa.Name = "txtTenKhoa";
			txtTenKhoa.Size = new Size(299, 28);
			txtTenKhoa.TabIndex = 42;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(40, 39, 81);
			label2.Location = new Point(115, 126);
			label2.Name = "label2";
			label2.Size = new Size(88, 20);
			label2.TabIndex = 41;
			label2.Text = "Mã Khoa:";
			// 
			// txtMaKhoa
			// 
			txtMaKhoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtMaKhoa.Location = new Point(209, 123);
			txtMaKhoa.Name = "txtMaKhoa";
			txtMaKhoa.Size = new Size(299, 28);
			txtMaKhoa.TabIndex = 40;
			// 
			// txtTim
			// 
			txtTim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtTim.Location = new Point(125, 356);
			txtTim.Name = "txtTim";
			txtTim.Size = new Size(263, 28);
			txtTim.TabIndex = 34;
			// 
			// btnTim
			// 
			btnTim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnTim.ForeColor = Color.FromArgb(40, 39, 81);
			btnTim.Location = new Point(394, 350);
			btnTim.Name = "btnTim";
			btnTim.Size = new Size(114, 38);
			btnTim.TabIndex = 39;
			btnTim.Text = "Tìm Kiếm";
			btnTim.UseVisualStyleBackColor = true;
			btnTim.Click += btnTim_Click;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnLamMoi.ForeColor = Color.FromArgb(40, 39, 81);
			btnLamMoi.Location = new Point(459, 268);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(114, 62);
			btnLamMoi.TabIndex = 38;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnSua.ForeColor = Color.FromArgb(40, 39, 81);
			btnSua.Location = new Point(329, 268);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(114, 62);
			btnSua.TabIndex = 37;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(40, 39, 81);
			btnXoa.Location = new Point(201, 268);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(114, 62);
			btnXoa.TabIndex = 36;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(40, 39, 81);
			btnThem.Location = new Point(74, 268);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(114, 62);
			btnThem.TabIndex = 35;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// FormKhoa
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(656, 668);
			Controls.Add(dgvKhoa);
			Controls.Add(label1);
			Controls.Add(txtTenKhoa);
			Controls.Add(label2);
			Controls.Add(txtMaKhoa);
			Controls.Add(txtTim);
			Controls.Add(btnTim);
			Controls.Add(btnLamMoi);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Name = "FormKhoa";
			Text = "FormKhoa";
			((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvKhoa;
		private Label label1;
		private TextBox txtTenKhoa;
		private Label label2;
		private TextBox txtMaKhoa;
		private TextBox txtTim;
		private Button btnTim;
		private Button btnLamMoi;
		private Button btnSua;
		private Button btnXoa;
		private Button btnThem;
	}
}