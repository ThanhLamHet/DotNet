namespace Lab9_QuanLyThuVien
{
	partial class frmBangCap
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
			txtMaBangCap = new TextBox();
			txtTenBangCap = new TextBox();
			dgvBangCap = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			btnLamMoi = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnThem = new Button();
			((System.ComponentModel.ISupportInitialize)dgvBangCap).BeginInit();
			SuspendLayout();
			// 
			// txtMaBangCap
			// 
			txtMaBangCap.Font = new Font("Times New Roman", 10.2F);
			txtMaBangCap.Location = new Point(153, 111);
			txtMaBangCap.Name = "txtMaBangCap";
			txtMaBangCap.ReadOnly = true;
			txtMaBangCap.Size = new Size(265, 27);
			txtMaBangCap.TabIndex = 0;
			// 
			// txtTenBangCap
			// 
			txtTenBangCap.Font = new Font("Times New Roman", 10.2F);
			txtTenBangCap.Location = new Point(153, 156);
			txtTenBangCap.Name = "txtTenBangCap";
			txtTenBangCap.Size = new Size(265, 27);
			txtTenBangCap.TabIndex = 1;
			// 
			// dgvBangCap
			// 
			dgvBangCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBangCap.Location = new Point(12, 295);
			dgvBangCap.Name = "dgvBangCap";
			dgvBangCap.RowHeadersWidth = 51;
			dgvBangCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvBangCap.Size = new Size(742, 218);
			dgvBangCap.TabIndex = 32;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(47, 114);
			label1.Name = "label1";
			label1.Size = new Size(98, 19);
			label1.TabIndex = 34;
			label1.Text = "Mã bằng cấp:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(44, 159);
			label2.Name = "label2";
			label2.Size = new Size(101, 19);
			label2.TabIndex = 35;
			label2.Text = "Tên bằng cấp:";
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Times New Roman", 10.2F);
			btnLamMoi.Location = new Point(603, 159);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(106, 39);
			btnLamMoi.TabIndex = 40;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.2F);
			btnXoa.Location = new Point(603, 99);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(106, 39);
			btnXoa.TabIndex = 39;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Times New Roman", 10.2F);
			btnSua.Location = new Point(472, 159);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(106, 39);
			btnSua.TabIndex = 38;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.2F);
			btnThem.Location = new Point(472, 99);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(106, 39);
			btnThem.TabIndex = 37;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// frmBangCap
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoValidate = AutoValidate.EnablePreventFocusChange;
			BackgroundImage = Properties.Resources.wood_background;
			ClientSize = new Size(766, 525);
			Controls.Add(btnLamMoi);
			Controls.Add(btnXoa);
			Controls.Add(btnSua);
			Controls.Add(btnThem);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvBangCap);
			Controls.Add(txtTenBangCap);
			Controls.Add(txtMaBangCap);
			Name = "frmBangCap";
			Text = "frmBangCap";
			Load += frmBangCap_Load;
			((System.ComponentModel.ISupportInitialize)dgvBangCap).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtMaBangCap;
		private TextBox txtTenBangCap;
		private DataGridView dgvBangCap;
		private Label label1;
		private Label label2;
		private Button btnLamMoi;
		private Button btnXoa;
		private Button btnSua;
		private Button btnThem;
	}
}