namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmDichVu
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
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtMaDV = new TextBox();
			txtTenDV = new TextBox();
			txtDonViTinh = new TextBox();
			txtGiaDV = new TextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnLamMoi = new Button();
			btnTim = new Button();
			txtTimKiem = new TextBox();
			label5 = new Label();
			dgvDichVu = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Location = new Point(35, 14);
			label1.Name = "label1";
			label1.Size = new Size(81, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã dịch vụ";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top;
			label2.AutoSize = true;
			label2.Location = new Point(33, 59);
			label2.Name = "label2";
			label2.Size = new Size(83, 20);
			label2.TabIndex = 1;
			label2.Text = "Tên dịch vụ";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top;
			label3.AutoSize = true;
			label3.Location = new Point(424, 62);
			label3.Name = "label3";
			label3.Size = new Size(86, 20);
			label3.TabIndex = 2;
			label3.Text = "Giá Dịch Vụ";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top;
			label4.AutoSize = true;
			label4.Location = new Point(424, 14);
			label4.Name = "label4";
			label4.Size = new Size(81, 20);
			label4.TabIndex = 3;
			label4.Text = "Đơn vị tính";
			// 
			// txtMaDV
			// 
			txtMaDV.Anchor = AnchorStyles.Top;
			txtMaDV.Enabled = false;
			txtMaDV.Location = new Point(137, 11);
			txtMaDV.Name = "txtMaDV";
			txtMaDV.Size = new Size(243, 27);
			txtMaDV.TabIndex = 4;
			// 
			// txtTenDV
			// 
			txtTenDV.Anchor = AnchorStyles.Top;
			txtTenDV.Location = new Point(137, 56);
			txtTenDV.Name = "txtTenDV";
			txtTenDV.Size = new Size(243, 27);
			txtTenDV.TabIndex = 5;
			// 
			// txtDonViTinh
			// 
			txtDonViTinh.Anchor = AnchorStyles.Top;
			txtDonViTinh.Location = new Point(516, 11);
			txtDonViTinh.Name = "txtDonViTinh";
			txtDonViTinh.Size = new Size(243, 27);
			txtDonViTinh.TabIndex = 6;
			// 
			// txtGiaDV
			// 
			txtGiaDV.Anchor = AnchorStyles.Top;
			txtGiaDV.Location = new Point(516, 59);
			txtGiaDV.Name = "txtGiaDV";
			txtGiaDV.Size = new Size(243, 27);
			txtGiaDV.TabIndex = 7;
			// 
			// btnThem
			// 
			btnThem.Anchor = AnchorStyles.Top;
			btnThem.Location = new Point(36, 102);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(117, 46);
			btnThem.TabIndex = 8;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Anchor = AnchorStyles.Top;
			btnXoa.Location = new Point(36, 154);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(117, 46);
			btnXoa.TabIndex = 9;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Anchor = AnchorStyles.Top;
			btnSua.Location = new Point(157, 102);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(117, 46);
			btnSua.TabIndex = 10;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Anchor = AnchorStyles.Top;
			btnLamMoi.Location = new Point(157, 154);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(117, 46);
			btnLamMoi.TabIndex = 11;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// btnTim
			// 
			btnTim.Anchor = AnchorStyles.Top;
			btnTim.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnTim.Location = new Point(487, 158);
			btnTim.Name = "btnTim";
			btnTim.Size = new Size(196, 44);
			btnTim.TabIndex = 12;
			btnTim.Text = "Tìm";
			btnTim.UseVisualStyleBackColor = true;
			btnTim.Click += btnTim_Click;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Anchor = AnchorStyles.Top;
			txtTimKiem.Location = new Point(435, 125);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(309, 27);
			txtTimKiem.TabIndex = 13;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top;
			label5.AutoSize = true;
			label5.Location = new Point(435, 102);
			label5.Name = "label5";
			label5.Size = new Size(75, 20);
			label5.TabIndex = 14;
			label5.Text = "Tìm Kiếm:";
			// 
			// dgvDichVu
			// 
			dgvDichVu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDichVu.Location = new Point(33, 215);
			dgvDichVu.Name = "dgvDichVu";
			dgvDichVu.RowHeadersWidth = 51;
			dgvDichVu.Size = new Size(741, 223);
			dgvDichVu.TabIndex = 15;
			dgvDichVu.CellClick += dgvDichVu_CellClick;
			// 
			// frmDichVu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(803, 450);
			Controls.Add(dgvDichVu);
			Controls.Add(label5);
			Controls.Add(txtTimKiem);
			Controls.Add(btnTim);
			Controls.Add(btnLamMoi);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(txtGiaDV);
			Controls.Add(txtDonViTinh);
			Controls.Add(txtTenDV);
			Controls.Add(txtMaDV);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmDichVu";
			Text = "Dịch Vụ";
			Load += frmDichVu_Load;
			((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaDV;
        private TextBox txtTenDV;
        private TextBox txtDonViTinh;
        private TextBox txtGiaDV;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnTim;
        private TextBox txtTimKiem;
        private Label label5;
        private DataGridView dgvDichVu;
    }
}
