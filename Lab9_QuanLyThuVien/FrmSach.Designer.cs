namespace Lab9_QuanLyThuVien
{
	partial class FrmSach
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
			dgvSach = new DataGridView();
			btnLamMoi = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnThem = new Button();
			txtTimKiem = new TextBox();
			groupBox1 = new GroupBox();
			txtTriGia = new TextBox();
			label5 = new Label();
			txtNhaXB = new TextBox();
			label4 = new Label();
			txtNamXB = new TextBox();
			label6 = new Label();
			txtTacGia = new TextBox();
			txtTenSach = new TextBox();
			txtMaSach = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnTim = new Button();
			((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvSach
			// 
			dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSach.Location = new Point(12, 385);
			dgvSach.Name = "dgvSach";
			dgvSach.RowHeadersWidth = 51;
			dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvSach.Size = new Size(932, 308);
			dgvSach.TabIndex = 47;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Times New Roman", 10.2F);
			btnLamMoi.Location = new Point(724, 313);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(106, 39);
			btnLamMoi.TabIndex = 46;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.2F);
			btnXoa.Location = new Point(724, 257);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(106, 39);
			btnXoa.TabIndex = 45;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Times New Roman", 10.2F);
			btnSua.Location = new Point(592, 313);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(106, 39);
			btnSua.TabIndex = 44;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.2F);
			btnThem.Location = new Point(593, 257);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(106, 39);
			btnThem.TabIndex = 43;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Font = new Font("Times New Roman", 10.2F);
			txtTimKiem.Location = new Point(65, 280);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(301, 27);
			txtTimKiem.TabIndex = 42;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtTriGia);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(txtNhaXB);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtNamXB);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(txtTacGia);
			groupBox1.Controls.Add(txtTenSach);
			groupBox1.Controls.Add(txtMaSach);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(12, 55);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(932, 219);
			groupBox1.TabIndex = 41;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin sách";
			// 
			// txtTriGia
			// 
			txtTriGia.Font = new Font("Times New Roman", 10.2F);
			txtTriGia.Location = new Point(578, 130);
			txtTriGia.Name = "txtTriGia";
			txtTriGia.Size = new Size(250, 27);
			txtTriGia.TabIndex = 30;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Times New Roman", 10.2F);
			label5.Location = new Point(515, 133);
			label5.Name = "label5";
			label5.Size = new Size(57, 19);
			label5.TabIndex = 29;
			label5.Text = "Trị giá:";
			// 
			// txtNhaXB
			// 
			txtNhaXB.Font = new Font("Times New Roman", 10.2F);
			txtNhaXB.Location = new Point(578, 61);
			txtNhaXB.Name = "txtNhaXB";
			txtNhaXB.Size = new Size(250, 27);
			txtNhaXB.TabIndex = 28;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 10.2F);
			label4.Location = new Point(472, 64);
			label4.Name = "label4";
			label4.Size = new Size(100, 19);
			label4.TabIndex = 27;
			label4.Text = "Nhà xuất bản:";
			// 
			// txtNamXB
			// 
			txtNamXB.Font = new Font("Times New Roman", 10.2F);
			txtNamXB.Location = new Point(578, 97);
			txtNamXB.Name = "txtNamXB";
			txtNamXB.Size = new Size(250, 27);
			txtNamXB.TabIndex = 26;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Times New Roman", 10.2F);
			label6.Location = new Point(467, 100);
			label6.Name = "label6";
			label6.Size = new Size(105, 19);
			label6.TabIndex = 24;
			label6.Text = "Năm xuất bản:";
			// 
			// txtTacGia
			// 
			txtTacGia.Font = new Font("Times New Roman", 10.2F);
			txtTacGia.Location = new Point(163, 130);
			txtTacGia.Name = "txtTacGia";
			txtTacGia.Size = new Size(250, 27);
			txtTacGia.TabIndex = 21;
			// 
			// txtTenSach
			// 
			txtTenSach.Font = new Font("Times New Roman", 10.2F);
			txtTenSach.Location = new Point(163, 95);
			txtTenSach.Name = "txtTenSach";
			txtTenSach.Size = new Size(250, 27);
			txtTenSach.TabIndex = 20;
			// 
			// txtMaSach
			// 
			txtMaSach.Font = new Font("Times New Roman", 10.2F);
			txtMaSach.Location = new Point(163, 61);
			txtMaSach.Name = "txtMaSach";
			txtMaSach.Size = new Size(250, 27);
			txtMaSach.TabIndex = 19;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.2F);
			label3.Location = new Point(67, 133);
			label3.Name = "label3";
			label3.Size = new Size(87, 19);
			label3.TabIndex = 16;
			label3.Text = "Tên tác giả:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.2F);
			label2.Location = new Point(81, 100);
			label2.Name = "label2";
			label2.Size = new Size(73, 19);
			label2.TabIndex = 15;
			label2.Text = "Tên sách:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.2F);
			label1.Location = new Point(84, 61);
			label1.Name = "label1";
			label1.Size = new Size(70, 19);
			label1.TabIndex = 14;
			label1.Text = "Mã sách:";
			// 
			// btnTim
			// 
			btnTim.Font = new Font("Times New Roman", 10.2F);
			btnTim.Location = new Point(372, 280);
			btnTim.Name = "btnTim";
			btnTim.Size = new Size(94, 29);
			btnTim.TabIndex = 40;
			btnTim.Text = "Tìm Kiếm";
			btnTim.UseVisualStyleBackColor = true;
			btnTim.Click += btnTim_Click;
			// 
			// FrmSach
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(964, 705);
			Controls.Add(dgvSach);
			Controls.Add(btnLamMoi);
			Controls.Add(btnXoa);
			Controls.Add(btnSua);
			Controls.Add(btnThem);
			Controls.Add(txtTimKiem);
			Controls.Add(groupBox1);
			Controls.Add(btnTim);
			Name = "FrmSach";
			Text = "FrmSach";
			Load += FrmSach_Load;
			((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvSach;
		private Button btnLamMoi;
		private Button btnXoa;
		private Button btnSua;
		private Button btnThem;
		private TextBox txtTimKiem;
		private GroupBox groupBox1;
		private Label label6;
		private TextBox txtTacGia;
		private TextBox txtTenSach;
		private TextBox txtMaSach;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button btnTim;
		private TextBox txtNamXB;
		private TextBox txtTriGia;
		private Label label5;
		private TextBox txtNhaXB;
		private Label label4;
	}
}