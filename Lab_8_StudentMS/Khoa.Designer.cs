namespace Lab_8_StudentMS
{
	partial class frmKhoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
			dataGridViewKhoa = new DataGridView();
			label5 = new Label();
			label4 = new Label();
			txtTenKhoa = new TextBox();
			txtMaKhoa = new TextBox();
			btnLuu = new Button();
			btnXoa = new Button();
			btnThem = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewKhoa).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewKhoa
			// 
			dataGridViewKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewKhoa.Location = new Point(12, 304);
			dataGridViewKhoa.Name = "dataGridViewKhoa";
			dataGridViewKhoa.RowHeadersWidth = 51;
			dataGridViewKhoa.Size = new Size(843, 260);
			dataGridViewKhoa.TabIndex = 0;
			dataGridViewKhoa.CellContentClick += dataGridViewKhoa_CellContentClick;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label5.ForeColor = Color.FromArgb(40, 39, 81);
			label5.Location = new Point(459, 132);
			label5.Name = "label5";
			label5.Size = new Size(91, 20);
			label5.TabIndex = 12;
			label5.Text = "Tên Khoa:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label4.ForeColor = Color.FromArgb(40, 39, 81);
			label4.Location = new Point(462, 86);
			label4.Name = "label4";
			label4.Size = new Size(88, 20);
			label4.TabIndex = 11;
			label4.Text = "Mã Khoa:";
			// 
			// txtTenKhoa
			// 
			txtTenKhoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtTenKhoa.Location = new Point(556, 129);
			txtTenKhoa.Name = "txtTenKhoa";
			txtTenKhoa.Size = new Size(299, 28);
			txtTenKhoa.TabIndex = 10;
			// 
			// txtMaKhoa
			// 
			txtMaKhoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtMaKhoa.Location = new Point(556, 83);
			txtMaKhoa.Name = "txtMaKhoa";
			txtMaKhoa.Size = new Size(299, 28);
			txtMaKhoa.TabIndex = 9;
			// 
			// btnLuu
			// 
			btnLuu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnLuu.ForeColor = Color.FromArgb(40, 39, 81);
			btnLuu.Location = new Point(704, 194);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(102, 38);
			btnLuu.TabIndex = 17;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click_1;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(40, 39, 81);
			btnXoa.Location = new Point(574, 238);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(102, 38);
			btnXoa.TabIndex = 16;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(40, 39, 81);
			btnThem.Location = new Point(574, 194);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(102, 38);
			btnThem.TabIndex = 15;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click_1;
			// 
			// frmKhoa
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(144, 170, 229);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(867, 576);
			Controls.Add(btnLuu);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(txtTenKhoa);
			Controls.Add(txtMaKhoa);
			Controls.Add(dataGridViewKhoa);
			Name = "frmKhoa";
			Text = "Khoa";
			Load += Khoa_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewKhoa).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewKhoa;
		private Label label5;
		private Label label4;
		private TextBox txtTenKhoa;
		private TextBox txtMaKhoa;
		private Button btnLuu;
		private Button btnXoa;
		private Button btnThem;
	}
}