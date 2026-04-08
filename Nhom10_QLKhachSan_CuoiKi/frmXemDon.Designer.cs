namespace Nhom10_QLKhachSan_CuoiKi
{
	partial class frmXemDon
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
			dgvDonDatPhong = new DataGridView();
			dgvChiTiet = new DataGridView();
			cbTrangThai = new ComboBox();
			btnLoc = new Button();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btnHuy = new Button();
			btnCapNhat = new Button();
			btnLuu = new Button();
			btnIn = new Button();
			((System.ComponentModel.ISupportInitialize)dgvDonDatPhong).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvDonDatPhong
			// 
			dgvDonDatPhong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dgvDonDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDonDatPhong.Location = new Point(12, 201);
			dgvDonDatPhong.Name = "dgvDonDatPhong";
			dgvDonDatPhong.ReadOnly = true;
			dgvDonDatPhong.RowHeadersWidth = 51;
			dgvDonDatPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDonDatPhong.Size = new Size(921, 199);
			dgvDonDatPhong.TabIndex = 16;
			dgvDonDatPhong.CellClick += dgvDonDatPhong_CellClick;
			// 
			// dgvChiTiet
			// 
			dgvChiTiet.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvChiTiet.Location = new Point(12, 406);
			dgvChiTiet.MultiSelect = false;
			dgvChiTiet.Name = "dgvChiTiet";
			dgvChiTiet.ReadOnly = true;
			dgvChiTiet.RowHeadersWidth = 51;
			dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvChiTiet.Size = new Size(922, 215);
			dgvChiTiet.TabIndex = 17;
			// 
			// cbTrangThai
			// 
			cbTrangThai.Anchor = AnchorStyles.Top;
			cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTrangThai.FormattingEnabled = true;
			cbTrangThai.Location = new Point(200, 86);
			cbTrangThai.Name = "cbTrangThai";
			cbTrangThai.Size = new Size(259, 28);
			cbTrangThai.TabIndex = 18;
			cbTrangThai.SelectedIndexChanged += cbTrangThai_SelectedIndexChanged;
			// 
			// btnLoc
			// 
			btnLoc.Font = new Font("Times New Roman", 10.8F);
			btnLoc.Location = new Point(265, 51);
			btnLoc.Name = "btnLoc";
			btnLoc.Size = new Size(92, 63);
			btnLoc.TabIndex = 20;
			btnLoc.Text = "Lọc";
			btnLoc.UseVisualStyleBackColor = true;
			btnLoc.Click += btnLoc_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(99, 88);
			label1.Name = "label1";
			label1.Size = new Size(95, 22);
			label1.TabIndex = 19;
			label1.Text = "Trạng thái:";
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top;
			groupBox2.Controls.Add(btnLoc);
			groupBox2.Controls.Add(btnHuy);
			groupBox2.Controls.Add(btnCapNhat);
			groupBox2.Location = new Point(549, 37);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(385, 130);
			groupBox2.TabIndex = 20;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chức Năng";
			// 
			// btnHuy
			// 
			btnHuy.Font = new Font("Times New Roman", 10.8F);
			btnHuy.Location = new Point(148, 51);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(92, 63);
			btnHuy.TabIndex = 21;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = true;
			btnHuy.Click += btnHuy_Click;
			// 
			// btnCapNhat
			// 
			btnCapNhat.Font = new Font("Times New Roman", 10.8F);
			btnCapNhat.Location = new Point(31, 51);
			btnCapNhat.Name = "btnCapNhat";
			btnCapNhat.Size = new Size(92, 63);
			btnCapNhat.TabIndex = 21;
			btnCapNhat.Text = "Cập Nhật";
			btnCapNhat.UseVisualStyleBackColor = true;
			btnCapNhat.Click += btnCapNhat_Click;
			// 
			// btnLuu
			// 
			btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnLuu.Font = new Font("Times New Roman", 10.8F);
			btnLuu.Location = new Point(183, 644);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(126, 63);
			btnLuu.TabIndex = 22;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// btnIn
			// 
			btnIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnIn.Font = new Font("Times New Roman", 10.8F);
			btnIn.Location = new Point(637, 644);
			btnIn.Name = "btnIn";
			btnIn.Size = new Size(126, 63);
			btnIn.TabIndex = 23;
			btnIn.Text = "In";
			btnIn.UseVisualStyleBackColor = true;
			btnIn.Click += btnIn_Click;
			// 
			// frmXemDon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(945, 719);
			Controls.Add(btnIn);
			Controls.Add(cbTrangThai);
			Controls.Add(label1);
			Controls.Add(btnLuu);
			Controls.Add(groupBox2);
			Controls.Add(dgvChiTiet);
			Controls.Add(dgvDonDatPhong);
			Name = "frmXemDon";
			Text = "Xem Đơn Đặt Phòng";
			Load += frmXemDon_Load;
			((System.ComponentModel.ISupportInitialize)dgvDonDatPhong).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DataGridView dgvDonDatPhong;
		private DataGridView dgvChiTiet;
		private ComboBox cbTrangThai;
		private Label label1;
		private Button btnLoc;
		private GroupBox groupBox2;
		private Button btnHuy;
		private Button btnCapNhat;
		private Button btnLuu;
		private Button btnIn;
	}
}