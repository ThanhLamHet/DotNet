namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmThemHuyDichVu
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
			cboCTDP = new ComboBox();
			cboDichVu = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			dgvDSDichVu = new DataGridView();
			btnThemDV = new Button();
			btnHuyDV = new Button();
			btnLamMoi = new Button();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtSoLuong = new TextBox();
			txtDonGia = new TextBox();
			txtThanhTien = new TextBox();
			((System.ComponentModel.ISupportInitialize)dgvDSDichVu).BeginInit();
			SuspendLayout();
			// 
			// cboCTDP
			// 
			cboCTDP.FormattingEnabled = true;
			cboCTDP.Location = new Point(20, 51);
			cboCTDP.Name = "cboCTDP";
			cboCTDP.Size = new Size(227, 28);
			cboCTDP.TabIndex = 0;
			cboCTDP.SelectedIndexChanged += cboCTDP_SelectedIndexChanged;
			// 
			// cboDichVu
			// 
			cboDichVu.FormattingEnabled = true;
			cboDichVu.Location = new Point(20, 116);
			cboDichVu.Name = "cboDichVu";
			cboDichVu.Size = new Size(227, 28);
			cboDichVu.TabIndex = 1;
			cboDichVu.SelectedIndexChanged += cboDichVu_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(20, 28);
			label1.Name = "label1";
			label1.Size = new Size(129, 20);
			label1.TabIndex = 2;
			label1.Text = "Chi tiết đặt phòng";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(20, 93);
			label2.Name = "label2";
			label2.Size = new Size(60, 20);
			label2.TabIndex = 3;
			label2.Text = "Dịch Vụ";
			// 
			// dgvDSDichVu
			// 
			dgvDSDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDSDichVu.Location = new Point(20, 176);
			dgvDSDichVu.Name = "dgvDSDichVu";
			dgvDSDichVu.RowHeadersWidth = 51;
			dgvDSDichVu.Size = new Size(698, 318);
			dgvDSDichVu.TabIndex = 4;
			// 
			// btnThemDV
			// 
			btnThemDV.Location = new Point(726, 176);
			btnThemDV.Name = "btnThemDV";
			btnThemDV.Size = new Size(118, 95);
			btnThemDV.TabIndex = 5;
			btnThemDV.Text = "Thêm";
			btnThemDV.UseVisualStyleBackColor = true;
			btnThemDV.Click += btnThemDV_Click;
			// 
			// btnHuyDV
			// 
			btnHuyDV.Location = new Point(726, 288);
			btnHuyDV.Name = "btnHuyDV";
			btnHuyDV.Size = new Size(118, 95);
			btnHuyDV.TabIndex = 6;
			btnHuyDV.Text = "Hủy";
			btnHuyDV.UseVisualStyleBackColor = true;
			btnHuyDV.Click += btnHuyDV_Click;
			// 
			// btnLamMoi
			// 
			btnLamMoi.Location = new Point(726, 399);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(118, 95);
			btnLamMoi.TabIndex = 7;
			btnLamMoi.Text = "Làm Mới";
			btnLamMoi.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(321, 40);
			label3.Name = "label3";
			label3.Size = new Size(69, 20);
			label3.TabIndex = 8;
			label3.Text = "Số lượng";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(321, 81);
			label4.Name = "label4";
			label4.Size = new Size(63, 20);
			label4.TabIndex = 9;
			label4.Text = "Đơn Giá";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(321, 119);
			label5.Name = "label5";
			label5.Size = new Size(81, 20);
			label5.TabIndex = 10;
			label5.Text = "Thành Tiền";
			// 
			// txtSoLuong
			// 
			txtSoLuong.Location = new Point(420, 40);
			txtSoLuong.Name = "txtSoLuong";
			txtSoLuong.Size = new Size(246, 27);
			txtSoLuong.TabIndex = 11;
			txtSoLuong.TextChanged += txtSoLuong_TextChanged;
			// 
			// txtDonGia
			// 
			txtDonGia.Location = new Point(420, 78);
			txtDonGia.Name = "txtDonGia";
			txtDonGia.Size = new Size(246, 27);
			txtDonGia.TabIndex = 12;
			// 
			// txtThanhTien
			// 
			txtThanhTien.Location = new Point(420, 116);
			txtThanhTien.Name = "txtThanhTien";
			txtThanhTien.Size = new Size(246, 27);
			txtThanhTien.TabIndex = 13;
			// 
			// frmThemHuyDichVu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(854, 545);
			Controls.Add(txtThanhTien);
			Controls.Add(txtDonGia);
			Controls.Add(txtSoLuong);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(btnLamMoi);
			Controls.Add(btnHuyDV);
			Controls.Add(btnThemDV);
			Controls.Add(dgvDSDichVu);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(cboDichVu);
			Controls.Add(cboCTDP);
			Name = "frmThemHuyDichVu";
			Text = "Thêm Hủy Dịch Vụ";
			Load += frmThemHuyDichVu_Load;
			((System.ComponentModel.ISupportInitialize)dgvDSDichVu).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cboCTDP;
        private ComboBox cboDichVu;
        private Label label1;
        private Label label2;
        private DataGridView dgvDSDichVu;
        private Button btnThemDV;
        private Button btnHuyDV;
        private Button btnLamMoi;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private TextBox txtThanhTien;
    }
}