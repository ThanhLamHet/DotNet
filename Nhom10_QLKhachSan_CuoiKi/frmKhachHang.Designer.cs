namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmKhachHang
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
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            bttTimKiem = new Button();
            label7 = new Label();
            bttSua = new Button();
            bttXoa = new Button();
            bttLamMoi = new Button();
            bttThem = new Button();
            groupBox2 = new GroupBox();
            txtMaKH = new TextBox();
            label3 = new Label();
            txtSDT = new TextBox();
            txtCCCD = new TextBox();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvKhachHang = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(bttTimKiem);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(bttSua);
            groupBox1.Controls.Add(bttXoa);
            groupBox1.Controls.Add(bttLamMoi);
            groupBox1.Controls.Add(bttThem);
            groupBox1.Location = new Point(566, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 184);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tính Năng";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(84, 127);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(275, 27);
            txtTimKiem.TabIndex = 8;
            // 
            // bttTimKiem
            // 
            bttTimKiem.Location = new Point(368, 121);
            bttTimKiem.Name = "bttTimKiem";
            bttTimKiem.Size = new Size(105, 39);
            bttTimKiem.TabIndex = 7;
            bttTimKiem.Text = "🔍Tìm Kiếm";
            bttTimKiem.UseVisualStyleBackColor = true;
            bttTimKiem.Click += bttTimKiem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 130);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 5;
            label7.Text = "Tìm Kiếm";
            // 
            // bttSua
            // 
            bttSua.Location = new Point(137, 37);
            bttSua.Name = "bttSua";
            bttSua.Size = new Size(91, 39);
            bttSua.TabIndex = 4;
            bttSua.Text = "✏️Sửa";
            bttSua.UseVisualStyleBackColor = true;
            bttSua.Click += bttSua_Click;
            // 
            // bttXoa
            // 
            bttXoa.Location = new Point(255, 37);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(91, 39);
            bttXoa.TabIndex = 3;
            bttXoa.Text = "🚫Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += bttXoa_Click;
            // 
            // bttLamMoi
            // 
            bttLamMoi.Location = new Point(368, 37);
            bttLamMoi.Name = "bttLamMoi";
            bttLamMoi.Size = new Size(105, 39);
            bttLamMoi.TabIndex = 2;
            bttLamMoi.Text = "🔄Làm Mới";
            bttLamMoi.UseVisualStyleBackColor = true;
            bttLamMoi.Click += bttLamMoi_Click;
            // 
            // bttThem
            // 
            bttThem.Location = new Point(22, 37);
            bttThem.Name = "bttThem";
            bttThem.Size = new Size(91, 39);
            bttThem.TabIndex = 1;
            bttThem.Text = "✚Thêm";
            bttThem.UseVisualStyleBackColor = true;
            bttThem.Click += bttThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMaKH);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(txtCCCD);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(38, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 277);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Khách Hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Enabled = false;
            txtMaKH.ForeColor = SystemColors.WindowText;
            txtMaKH.Location = new Point(117, 41);
            txtMaKH.Multiline = true;
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(253, 28);
            txtMaKH.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 49);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 19;
            label3.Text = "Mã KH";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(117, 213);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(253, 28);
            txtSDT.TabIndex = 18;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(117, 83);
            txtCCCD.Multiline = true;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(253, 28);
            txtCCCD.TabIndex = 17;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(117, 126);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(253, 28);
            txtHoTen.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 166);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 28);
            txtEmail.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 90);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 12;
            label5.Text = "CCCD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 217);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 11;
            label4.Text = "Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 129);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 9;
            label2.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 174);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(12, 339);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1113, 333);
            dgvKhachHang.TabIndex = 22;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 684);
            Controls.Add(dgvKhachHang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTimKiem;
        private Button bttTimKiem;
        private Label label7;
        private Button bttSua;
        private Button bttXoa;
        private Button bttLamMoi;
        private Button bttThem;
        private GroupBox groupBox2;
        private TextBox txtSDT;
        private TextBox txtCCCD;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dgvKhachHang;
        private TextBox txtMaKH;
        private Label label3;
    }
}