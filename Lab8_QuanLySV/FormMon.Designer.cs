namespace Lab8_QuanLySV
{
	partial class FormMon
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
			txtTenMon = new TextBox();
			label2 = new Label();
			txtMaMon = new TextBox();
			txtTim = new TextBox();
			btnTim = new Button();
			btnLamMoi = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			btnThem = new Button();
			dgvMon = new DataGridView();
			label3 = new Label();
			txtSoTiet = new TextBox();
			((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(40, 39, 81);
			label1.Location = new Point(73, 117);
			label1.Name = "label1";
			label1.Size = new Size(84, 20);
			label1.TabIndex = 53;
			label1.Text = "Tên Môn:";
			// 
			// txtTenMon
			// 
			txtTenMon.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtTenMon.Location = new Point(170, 114);
			txtTenMon.Name = "txtTenMon";
			txtTenMon.Size = new Size(299, 28);
			txtTenMon.TabIndex = 52;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(40, 39, 81);
			label2.Location = new Point(76, 74);
			label2.Name = "label2";
			label2.Size = new Size(81, 20);
			label2.TabIndex = 51;
			label2.Text = "Mã Môn:";
			// 
			// txtMaMon
			// 
			txtMaMon.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtMaMon.Location = new Point(170, 71);
			txtMaMon.Name = "txtMaMon";
			txtMaMon.Size = new Size(299, 28);
			txtMaMon.TabIndex = 50;
			// 
			// txtTim
			// 
			txtTim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtTim.Location = new Point(94, 283);
			txtTim.Name = "txtTim";
			txtTim.Size = new Size(263, 28);
			txtTim.TabIndex = 44;
			// 
			// btnTim
			// 
			btnTim.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnTim.ForeColor = Color.FromArgb(40, 39, 81);
			btnTim.Location = new Point(363, 277);
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
			btnLamMoi.Location = new Point(428, 195);
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
			btnSua.Location = new Point(298, 195);
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
			btnXoa.Location = new Point(170, 195);
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
			btnThem.Location = new Point(43, 195);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(114, 62);
			btnThem.TabIndex = 45;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// dgvMon
			// 
			dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMon.Location = new Point(12, 349);
			dgvMon.Name = "dgvMon";
			dgvMon.RowHeadersWidth = 51;
			dgvMon.Size = new Size(568, 233);
			dgvMon.TabIndex = 54;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(40, 39, 81);
			label3.Location = new Point(88, 157);
			label3.Name = "label3";
			label3.Size = new Size(69, 20);
			label3.TabIndex = 56;
			label3.Text = "Số Tiết:";
			// 
			// txtSoTiet
			// 
			txtSoTiet.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtSoTiet.Location = new Point(170, 154);
			txtSoTiet.Name = "txtSoTiet";
			txtSoTiet.Size = new Size(299, 28);
			txtSoTiet.TabIndex = 55;
			// 
			// FormMon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(592, 594);
			Controls.Add(label3);
			Controls.Add(txtSoTiet);
			Controls.Add(dgvMon);
			Controls.Add(label1);
			Controls.Add(txtTenMon);
			Controls.Add(label2);
			Controls.Add(txtMaMon);
			Controls.Add(txtTim);
			Controls.Add(btnTim);
			Controls.Add(btnLamMoi);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Name = "FormMon";
			Text = "FormMon";
			Load += FormMon_Load;
			((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtTenMon;
		private Label label2;
		private TextBox txtMaMon;
		private TextBox txtTim;
		private Button btnTim;
		private Button btnLamMoi;
		private Button btnSua;
		private Button btnXoa;
		private Button btnThem;
		private DataGridView dgvMon;
		private Label label3;
		private TextBox txtSoTiet;
	}
}