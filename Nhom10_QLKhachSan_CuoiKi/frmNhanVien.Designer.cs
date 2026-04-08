namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			dgvNhanVien = new DataGridView();
			panelTop = new Panel();
			lblTongSo = new Label();
			cboLocTrangThai = new ComboBox();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			btnLamMoi = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnThem = new Button();
			btnChonAnh = new Button();
			picHinhAnh = new PictureBox();
			cboTrangThai = new ComboBox();
			lbl5 = new Label();
			cboChucVu = new ComboBox();
			lbl4 = new Label();
			txtSDT = new TextBox();
			lbl3 = new Label();
			txtHoTen = new TextBox();
			lbl2 = new Label();
			txtMaNV = new TextBox();
			lbl1 = new Label();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
			panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.FixedPanel = FixedPanel.Panel2;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(dgvNhanVien);
			splitContainer1.Panel1.Controls.Add(panelTop);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
			splitContainer1.Panel2.Controls.Add(btnLamMoi);
			splitContainer1.Panel2.Controls.Add(btnXoa);
			splitContainer1.Panel2.Controls.Add(btnSua);
			splitContainer1.Panel2.Controls.Add(btnThem);
			splitContainer1.Panel2.Controls.Add(btnChonAnh);
			splitContainer1.Panel2.Controls.Add(picHinhAnh);
			splitContainer1.Panel2.Controls.Add(cboTrangThai);
			splitContainer1.Panel2.Controls.Add(lbl5);
			splitContainer1.Panel2.Controls.Add(cboChucVu);
			splitContainer1.Panel2.Controls.Add(lbl4);
			splitContainer1.Panel2.Controls.Add(txtSDT);
			splitContainer1.Panel2.Controls.Add(lbl3);
			splitContainer1.Panel2.Controls.Add(txtHoTen);
			splitContainer1.Panel2.Controls.Add(lbl2);
			splitContainer1.Panel2.Controls.Add(txtMaNV);
			splitContainer1.Panel2.Controls.Add(lbl1);
			splitContainer1.Size = new Size(1061, 600);
			splitContainer1.SplitterDistance = 711;
			splitContainer1.TabIndex = 0;
			// 
			// dgvNhanVien
			// 
			dgvNhanVien.BackgroundColor = Color.White;
			dgvNhanVien.BorderStyle = BorderStyle.None;
			dgvNhanVien.ColumnHeadersHeight = 29;
			dgvNhanVien.Dock = DockStyle.Fill;
			dgvNhanVien.Location = new Point(0, 60);
			dgvNhanVien.Name = "dgvNhanVien";
			dgvNhanVien.RowHeadersWidth = 51;
			dgvNhanVien.Size = new Size(711, 540);
			dgvNhanVien.TabIndex = 1;
			dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
			// 
			// panelTop
			// 
			panelTop.BackColor = Color.White;
			panelTop.Controls.Add(lblTongSo);
			panelTop.Controls.Add(cboLocTrangThai);
			panelTop.Controls.Add(txtTimKiem);
			panelTop.Controls.Add(btnTimKiem);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Size = new Size(711, 60);
			panelTop.TabIndex = 0;
			// 
			// lblTongSo
			// 
			lblTongSo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblTongSo.AutoSize = true;
			lblTongSo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
			lblTongSo.ForeColor = Color.FromArgb(41, 128, 185);
			lblTongSo.Location = new Point(516, 20);
			lblTongSo.Name = "lblTongSo";
			lblTongSo.Size = new Size(192, 23);
			lblTongSo.TabIndex = 3;
			lblTongSo.Text = "Tổng số: 0 | Đã nghỉ: 0";
			// 
			// cboLocTrangThai
			// 
			cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
			cboLocTrangThai.Font = new Font("Segoe UI", 10F);
			cboLocTrangThai.FormattingEnabled = true;
			cboLocTrangThai.Location = new Point(349, 16);
			cboLocTrangThai.Name = "cboLocTrangThai";
			cboLocTrangThai.Size = new Size(130, 31);
			cboLocTrangThai.TabIndex = 2;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Font = new Font("Segoe UI", 10F);
			txtTimKiem.Location = new Point(20, 16);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.PlaceholderText = "Nhập tên hoặc SĐT...";
			txtTimKiem.Size = new Size(200, 30);
			txtTimKiem.TabIndex = 0;
			// 
			// btnTimKiem
			// 
			btnTimKiem.BackColor = Color.FromArgb(41, 128, 185);
			btnTimKiem.FlatAppearance.BorderSize = 0;
			btnTimKiem.FlatStyle = FlatStyle.Flat;
			btnTimKiem.ForeColor = Color.White;
			btnTimKiem.Location = new Point(226, 12);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(102, 37);
			btnTimKiem.TabIndex = 1;
			btnTimKiem.Text = "Tìm kiếm";
			btnTimKiem.UseVisualStyleBackColor = false;
			// 
			// btnLamMoi
			// 
			btnLamMoi.BackColor = Color.Gray;
			btnLamMoi.FlatAppearance.BorderSize = 0;
			btnLamMoi.FlatStyle = FlatStyle.Flat;
			btnLamMoi.ForeColor = Color.White;
			btnLamMoi.Location = new Point(180, 510);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(120, 40);
			btnLamMoi.TabIndex = 0;
			btnLamMoi.Text = "Làm mới";
			btnLamMoi.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			btnXoa.BackColor = Color.Red;
			btnXoa.FlatAppearance.BorderSize = 0;
			btnXoa.FlatStyle = FlatStyle.Flat;
			btnXoa.ForeColor = Color.White;
			btnXoa.Location = new Point(30, 510);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(120, 40);
			btnXoa.TabIndex = 1;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = false;
			// 
			// btnSua
			// 
			btnSua.BackColor = Color.FromArgb(255, 128, 0);
			btnSua.FlatAppearance.BorderSize = 0;
			btnSua.FlatStyle = FlatStyle.Flat;
			btnSua.ForeColor = Color.White;
			btnSua.Location = new Point(180, 450);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(120, 40);
			btnSua.TabIndex = 2;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = false;
			// 
			// btnThem
			// 
			btnThem.BackColor = Color.Green;
			btnThem.FlatAppearance.BorderSize = 0;
			btnThem.FlatStyle = FlatStyle.Flat;
			btnThem.ForeColor = Color.White;
			btnThem.Location = new Point(30, 450);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(120, 40);
			btnThem.TabIndex = 3;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = false;
			// 
			// btnChonAnh
			// 
			btnChonAnh.BackColor = Color.FromArgb(149, 165, 166);
			btnChonAnh.FlatAppearance.BorderSize = 0;
			btnChonAnh.FlatStyle = FlatStyle.Flat;
			btnChonAnh.ForeColor = Color.White;
			btnChonAnh.Location = new Point(100, 180);
			btnChonAnh.Name = "btnChonAnh";
			btnChonAnh.Size = new Size(120, 30);
			btnChonAnh.TabIndex = 1;
			btnChonAnh.Text = "Chọn Ảnh";
			btnChonAnh.UseVisualStyleBackColor = false;
			// 
			// picHinhAnh
			// 
			picHinhAnh.BackColor = Color.Gainsboro;
			picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
			picHinhAnh.Location = new Point(100, 20);
			picHinhAnh.Name = "picHinhAnh";
			picHinhAnh.Size = new Size(120, 150);
			picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
			picHinhAnh.TabIndex = 0;
			picHinhAnh.TabStop = false;
			// 
			// cboTrangThai
			// 
			cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
			cboTrangThai.Location = new Point(100, 387);
			cboTrangThai.Name = "cboTrangThai";
			cboTrangThai.Size = new Size(200, 29);
			cboTrangThai.TabIndex = 4;
			// 
			// lbl5
			// 
			lbl5.AutoSize = true;
			lbl5.Location = new Point(20, 390);
			lbl5.Name = "lbl5";
			lbl5.Size = new Size(91, 23);
			lbl5.TabIndex = 5;
			lbl5.Text = "Trạng thái:";
			// 
			// cboChucVu
			// 
			cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
			cboChucVu.Location = new Point(100, 347);
			cboChucVu.Name = "cboChucVu";
			cboChucVu.Size = new Size(200, 29);
			cboChucVu.TabIndex = 6;
			// 
			// lbl4
			// 
			lbl4.AutoSize = true;
			lbl4.Location = new Point(20, 350);
			lbl4.Name = "lbl4";
			lbl4.Size = new Size(76, 23);
			lbl4.TabIndex = 7;
			lbl4.Text = "Chức vụ:";
			// 
			// txtSDT
			// 
			txtSDT.Location = new Point(100, 307);
			txtSDT.Name = "txtSDT";
			txtSDT.Size = new Size(200, 29);
			txtSDT.TabIndex = 8;
			// 
			// lbl3
			// 
			lbl3.AutoSize = true;
			lbl3.Location = new Point(20, 310);
			lbl3.Name = "lbl3";
			lbl3.Size = new Size(44, 23);
			lbl3.TabIndex = 9;
			lbl3.Text = "SĐT:";
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(100, 267);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(200, 29);
			txtHoTen.TabIndex = 10;
			// 
			// lbl2
			// 
			lbl2.AutoSize = true;
			lbl2.Location = new Point(20, 270);
			lbl2.Name = "lbl2";
			lbl2.Size = new Size(67, 23);
			lbl2.TabIndex = 11;
			lbl2.Text = "Họ Tên:";
			// 
			// txtMaNV
			// 
			txtMaNV.Location = new Point(100, 227);
			txtMaNV.Name = "txtMaNV";
			txtMaNV.ReadOnly = true;
			txtMaNV.Size = new Size(200, 29);
			txtMaNV.TabIndex = 12;
			// 
			// lbl1
			// 
			lbl1.AutoSize = true;
			lbl1.Location = new Point(20, 230);
			lbl1.Name = "lbl1";
			lbl1.Size = new Size(67, 23);
			lbl1.TabIndex = 13;
			lbl1.Text = "Mã NV:";
			// 
			// frmNhanVien
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1061, 600);
			Controls.Add(splitContainer1);
			Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmNhanVien";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Quản Lý Nhân Viên";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
			panelTop.ResumeLayout(false);
			panelTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbl1;
    }
}