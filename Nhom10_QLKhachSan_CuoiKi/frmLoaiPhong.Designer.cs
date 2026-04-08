namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmLoaiPhong
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
			label1 = new Label();
			txtMaLP = new TextBox();
			txtTenLP = new TextBox();
			label2 = new Label();
			txtGia = new TextBox();
			label3 = new Label();
			label4 = new Label();
			numSoNguoi = new NumericUpDown();
			btnThem = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			btnLamMoi = new Button();
			groupBox1 = new GroupBox();
			dgvLoaiPhong = new DataGridView();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)numSoNguoi).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 36);
			label1.Name = "label1";
			label1.Size = new Size(59, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã loại";
			// 
			// txtMaLP
			// 
			txtMaLP.Enabled = false;
			txtMaLP.Location = new Point(139, 36);
			txtMaLP.Margin = new Padding(3, 4, 3, 4);
			txtMaLP.Name = "txtMaLP";
			txtMaLP.Size = new Size(190, 27);
			txtMaLP.TabIndex = 1;
			// 
			// txtTenLP
			// 
			txtTenLP.Location = new Point(139, 93);
			txtTenLP.Margin = new Padding(3, 4, 3, 4);
			txtTenLP.Name = "txtTenLP";
			txtTenLP.Size = new Size(190, 27);
			txtTenLP.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 93);
			label2.Name = "label2";
			label2.Size = new Size(108, 20);
			label2.TabIndex = 2;
			label2.Text = "Tên loại phòng";
			// 
			// txtGia
			// 
			txtGia.Location = new Point(489, 89);
			txtGia.Margin = new Padding(3, 4, 3, 4);
			txtGia.Name = "txtGia";
			txtGia.Size = new Size(141, 27);
			txtGia.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(446, 93);
			label3.Name = "label3";
			label3.Size = new Size(31, 20);
			label3.TabIndex = 6;
			label3.Text = "Giá";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(413, 36);
			label4.Name = "label4";
			label4.Size = new Size(69, 20);
			label4.TabIndex = 4;
			label4.Text = "Số người";
			// 
			// numSoNguoi
			// 
			numSoNguoi.Location = new Point(489, 32);
			numSoNguoi.Margin = new Padding(3, 4, 3, 4);
			numSoNguoi.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numSoNguoi.Name = "numSoNguoi";
			numSoNguoi.Size = new Size(191, 27);
			numSoNguoi.TabIndex = 8;
			numSoNguoi.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnThem.Location = new Point(16, 20);
			btnThem.Margin = new Padding(3, 4, 3, 4);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(56, 39);
			btnThem.TabIndex = 9;
			btnThem.Text = "+";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnSua
			// 
			btnSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSua.Location = new Point(79, 20);
			btnSua.Margin = new Padding(3, 4, 3, 4);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(56, 39);
			btnSua.TabIndex = 10;
			btnSua.Text = "✏️";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnXoa.Location = new Point(142, 20);
			btnXoa.Margin = new Padding(3, 4, 3, 4);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(56, 39);
			btnXoa.TabIndex = 11;
			btnXoa.Text = "🗑️";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLamMoi.Location = new Point(205, 20);
			btnLamMoi.Margin = new Padding(3, 4, 3, 4);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(56, 39);
			btnLamMoi.TabIndex = 12;
			btnLamMoi.Text = "⟳";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnLamMoi);
			groupBox1.Controls.Add(btnThem);
			groupBox1.Controls.Add(btnXoa);
			groupBox1.Controls.Add(btnSua);
			groupBox1.Location = new Point(446, 139);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(274, 68);
			groupBox1.TabIndex = 13;
			groupBox1.TabStop = false;
			// 
			// dgvLoaiPhong
			// 
			dgvLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvLoaiPhong.Location = new Point(12, 215);
			dgvLoaiPhong.Margin = new Padding(3, 4, 3, 4);
			dgvLoaiPhong.MultiSelect = false;
			dgvLoaiPhong.Name = "dgvLoaiPhong";
			dgvLoaiPhong.ReadOnly = true;
			dgvLoaiPhong.RowHeadersWidth = 51;
			dgvLoaiPhong.Size = new Size(708, 199);
			dgvLoaiPhong.TabIndex = 14;
			dgvLoaiPhong.SelectionChanged += dgvLoaiPhong_SelectionChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(636, 93);
			label5.Name = "label5";
			label5.Size = new Size(40, 20);
			label5.TabIndex = 15;
			label5.Text = "VND";
			// 
			// frmLoaiPhong
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(732, 431);
			Controls.Add(label5);
			Controls.Add(dgvLoaiPhong);
			Controls.Add(groupBox1);
			Controls.Add(numSoNguoi);
			Controls.Add(txtGia);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(txtTenLP);
			Controls.Add(label2);
			Controls.Add(txtMaLP);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmLoaiPhong";
			Text = "Quản lý loại phòng";
			Load += frmLoaiPhong_Load;
			((System.ComponentModel.ISupportInitialize)numSoNguoi).EndInit();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private TextBox txtMaLP;
        private TextBox txtTenLP;
        private Label label2;
        private TextBox txtGia;
        private Label label3;
        private Label label4;
        private NumericUpDown numSoNguoi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox groupBox1;
        private DataGridView dgvLoaiPhong;
        private Label label5;
    }
}
