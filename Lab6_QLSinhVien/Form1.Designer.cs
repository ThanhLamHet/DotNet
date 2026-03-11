namespace Lab6_QLSinhVien
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			btTravelDS = new Button();
			btChonDS = new Button();
			btTravel = new Button();
			btChon1 = new Button();
			groupBox2 = new GroupBox();
			lvDachon = new ListView();
			STT1 = new ColumnHeader();
			MaSV1 = new ColumnHeader();
			Hoten1 = new ColumnHeader();
			groupBox1 = new GroupBox();
			lvDanhSachSV = new ListView();
			STT = new ColumnHeader();
			MaSV = new ColumnHeader();
			Hotten = new ColumnHeader();
			btnThem = new Button();
			txtHoten = new TextBox();
			label2 = new Label();
			txtMaSV = new TextBox();
			label3 = new Label();
			btnXoa = new Button();
			btnThoat = new Button();
			txtTimKiem = new TextBox();
			btntimKiem = new Button();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btTravelDS
			// 
			btTravelDS.BackColor = Color.FromArgb(247, 213, 54);
			btTravelDS.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btTravelDS.ForeColor = Color.FromArgb(2, 16, 29);
			btTravelDS.Location = new Point(632, 387);
			btTravelDS.Name = "btTravelDS";
			btTravelDS.Size = new Size(67, 46);
			btTravelDS.TabIndex = 20;
			btTravelDS.Text = "<<";
			btTravelDS.UseVisualStyleBackColor = false;
			btTravelDS.Click += btTravelDS_Click;
			// 
			// btChonDS
			// 
			btChonDS.BackColor = Color.FromArgb(247, 213, 54);
			btChonDS.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btChonDS.ForeColor = Color.FromArgb(2, 16, 29);
			btChonDS.Location = new Point(632, 335);
			btChonDS.Name = "btChonDS";
			btChonDS.Size = new Size(67, 46);
			btChonDS.TabIndex = 19;
			btChonDS.Text = "<";
			btChonDS.UseVisualStyleBackColor = false;
			btChonDS.Click += btChonDS_Click;
			// 
			// btTravel
			// 
			btTravel.BackColor = Color.FromArgb(247, 213, 54);
			btTravel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btTravel.ForeColor = Color.FromArgb(2, 16, 29);
			btTravel.Location = new Point(524, 387);
			btTravel.Name = "btTravel";
			btTravel.Size = new Size(67, 46);
			btTravel.TabIndex = 18;
			btTravel.Text = ">>";
			btTravel.UseVisualStyleBackColor = false;
			btTravel.Click += btTravel_Click;
			// 
			// btChon1
			// 
			btChon1.BackColor = Color.FromArgb(247, 213, 54);
			btChon1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btChon1.ForeColor = Color.FromArgb(2, 16, 29);
			btChon1.Location = new Point(524, 335);
			btChon1.Name = "btChon1";
			btChon1.Size = new Size(67, 46);
			btChon1.TabIndex = 17;
			btChon1.Text = ">";
			btChon1.UseVisualStyleBackColor = false;
			btChon1.Click += btTraisangphai_Click;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.Transparent;
			groupBox2.Controls.Add(lvDachon);
			groupBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
			groupBox2.ForeColor = Color.FromArgb(253, 230, 224);
			groupBox2.Location = new Point(705, 238);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(476, 404);
			groupBox2.TabIndex = 16;
			groupBox2.TabStop = false;
			groupBox2.Text = "Danh Sách Đã Chọn";
			// 
			// lvDachon
			// 
			lvDachon.Columns.AddRange(new ColumnHeader[] { STT1, MaSV1, Hoten1 });
			lvDachon.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lvDachon.ForeColor = Color.FromArgb(2, 16, 29);
			lvDachon.FullRowSelect = true;
			lvDachon.Location = new Point(15, 40);
			lvDachon.Name = "lvDachon";
			lvDachon.Size = new Size(445, 347);
			lvDachon.TabIndex = 31;
			lvDachon.UseCompatibleStateImageBehavior = false;
			lvDachon.View = View.Details;
			// 
			// STT1
			// 
			STT1.Text = "STT";
			// 
			// MaSV1
			// 
			MaSV1.Text = "Mã sinh viên";
			MaSV1.Width = 120;
			// 
			// Hoten1
			// 
			Hoten1.Text = "Họ và tên";
			Hoten1.Width = 180;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(lvDanhSachSV);
			groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
			groupBox1.ForeColor = Color.FromArgb(253, 230, 224);
			groupBox1.Location = new Point(48, 238);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(470, 404);
			groupBox1.TabIndex = 15;
			groupBox1.TabStop = false;
			groupBox1.Text = "Danh Sách Sinh Viên";
			// 
			// lvDanhSachSV
			// 
			lvDanhSachSV.Columns.AddRange(new ColumnHeader[] { STT, MaSV, Hotten });
			lvDanhSachSV.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lvDanhSachSV.ForeColor = Color.FromArgb(2, 16, 29);
			lvDanhSachSV.FullRowSelect = true;
			lvDanhSachSV.Location = new Point(11, 40);
			lvDanhSachSV.Name = "lvDanhSachSV";
			lvDanhSachSV.Size = new Size(445, 347);
			lvDanhSachSV.TabIndex = 30;
			lvDanhSachSV.UseCompatibleStateImageBehavior = false;
			lvDanhSachSV.View = View.Details;
			// 
			// STT
			// 
			STT.Text = "STT";
			// 
			// MaSV
			// 
			MaSV.Text = "Mã sinh viên";
			MaSV.Width = 120;
			// 
			// Hotten
			// 
			Hotten.Text = "Họ và tên";
			Hotten.Width = 180;
			// 
			// btnThem
			// 
			btnThem.BackColor = Color.FromArgb(247, 213, 54);
			btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(2, 16, 29);
			btnThem.Location = new Point(720, 38);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(119, 41);
			btnThem.TabIndex = 14;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = false;
			btnThem.Click += btnThem_Click;
			// 
			// txtHoten
			// 
			txtHoten.BackColor = Color.FromArgb(247, 213, 54);
			txtHoten.Font = new Font("Segoe UI", 11F);
			txtHoten.ForeColor = Color.FromArgb(2, 16, 29);
			txtHoten.Location = new Point(320, 90);
			txtHoten.Name = "txtHoten";
			txtHoten.Size = new Size(324, 32);
			txtHoten.TabIndex = 13;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(253, 230, 224);
			label2.Location = new Point(206, 93);
			label2.Name = "label2";
			label2.Size = new Size(102, 22);
			label2.TabIndex = 12;
			label2.Text = "Họ và tên:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtMaSV
			// 
			txtMaSV.BackColor = Color.FromArgb(247, 213, 54);
			txtMaSV.Font = new Font("Segoe UI", 11F);
			txtMaSV.ForeColor = Color.FromArgb(2, 16, 29);
			txtMaSV.Location = new Point(320, 52);
			txtMaSV.Name = "txtMaSV";
			txtMaSV.Size = new Size(324, 32);
			txtMaSV.TabIndex = 24;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(253, 230, 224);
			label3.Location = new Point(180, 57);
			label3.Name = "label3";
			label3.Size = new Size(128, 22);
			label3.TabIndex = 23;
			label3.Text = "Mã sinh viên:";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnXoa
			// 
			btnXoa.BackColor = Color.FromArgb(247, 213, 54);
			btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(2, 16, 29);
			btnXoa.Location = new Point(720, 85);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(119, 41);
			btnXoa.TabIndex = 25;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = false;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThoat
			// 
			btnThoat.BackColor = Color.FromArgb(247, 213, 54);
			btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btnThoat.ForeColor = Color.FromArgb(2, 16, 29);
			btnThoat.Location = new Point(845, 60);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(119, 41);
			btnThoat.TabIndex = 26;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = false;
			btnThoat.Click += btnThoat_Click;
			// 
			// txtTimKiem
			// 
			txtTimKiem.BackColor = Color.FromArgb(247, 213, 54);
			txtTimKiem.Font = new Font("Segoe UI", 11F);
			txtTimKiem.ForeColor = Color.FromArgb(2, 16, 29);
			txtTimKiem.Location = new Point(309, 174);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(542, 32);
			txtTimKiem.TabIndex = 28;
			// 
			// btntimKiem
			// 
			btntimKiem.BackColor = Color.FromArgb(247, 213, 54);
			btntimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btntimKiem.ForeColor = Color.FromArgb(2, 16, 29);
			btntimKiem.Location = new Point(184, 171);
			btntimKiem.Name = "btntimKiem";
			btntimKiem.Size = new Size(101, 36);
			btntimKiem.TabIndex = 29;
			btntimKiem.Text = "Tìm Kiếm";
			btntimKiem.UseVisualStyleBackColor = false;
			btntimKiem.Click += btntimKiem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(226, 67, 45);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(1227, 664);
			Controls.Add(btntimKiem);
			Controls.Add(txtTimKiem);
			Controls.Add(btnThoat);
			Controls.Add(btnXoa);
			Controls.Add(txtMaSV);
			Controls.Add(label3);
			Controls.Add(btTravelDS);
			Controls.Add(btChonDS);
			Controls.Add(btTravel);
			Controls.Add(btChon1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(btnThem);
			Controls.Add(txtHoten);
			Controls.Add(label2);
			DoubleBuffered = true;
			ForeColor = Color.FromArgb(2, 16, 29);
			Name = "Form1";
			Text = "Quản Lý Sinh Viên";
			groupBox2.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btTravelDS;
		private Button btChonDS;
		private Button btTravel;
		private Button btChon1;
		private GroupBox groupBox2;
		private GroupBox groupBox1;
		private Button btnThem;
		private TextBox txtHoten;
		private Label label2;
		private TextBox txtMaSV;
		private Label label3;
		private Button btnXoa;
		private Button btnThoat;
		private TextBox txtTimKiem;
		private Button btntimKiem;
		private ListView lvDanhSachSV;
		private ColumnHeader STT;
		private ColumnHeader MaSV;
		private ColumnHeader Hotten;
		private ListView lvDachon;
		private ColumnHeader STT1;
		private ColumnHeader MaSV1;
		private ColumnHeader Hoten1;
	}
}
