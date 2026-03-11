namespace Lab4_BT5_QuanLySinhVien
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
			label1 = new Label();
			label2 = new Label();
			txtHoten = new TextBox();
			btCapnhat = new Button();
			groupBox1 = new GroupBox();
			lstLopA = new ListBox();
			groupBox2 = new GroupBox();
			lstLopB = new ListBox();
			btTraisangphai = new Button();
			btTatcasangphai = new Button();
			btPhaisangtrai = new Button();
			btTatcasangtrai = new Button();
			btKetthuc = new Button();
			btXoa = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.FlatStyle = FlatStyle.Flat;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(754, 56);
			label1.TabIndex = 0;
			label1.Text = "DANH SÁCH SINH VIÊN";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(185, 81, 88);
			label2.Location = new Point(59, 108);
			label2.Name = "label2";
			label2.Size = new Size(102, 22);
			label2.TabIndex = 1;
			label2.Text = "Họ và tên:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtHoten
			// 
			txtHoten.BackColor = Color.FromArgb(242, 232, 230);
			txtHoten.Font = new Font("Segoe UI", 11F);
			txtHoten.ForeColor = Color.FromArgb(183, 71, 79);
			txtHoten.Location = new Point(173, 105);
			txtHoten.Name = "txtHoten";
			txtHoten.Size = new Size(324, 32);
			txtHoten.TabIndex = 2;
			// 
			// btCapnhat
			// 
			btCapnhat.BackColor = Color.FromArgb(242, 232, 230);
			btCapnhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btCapnhat.ForeColor = Color.FromArgb(183, 71, 79);
			btCapnhat.Location = new Point(526, 102);
			btCapnhat.Name = "btCapnhat";
			btCapnhat.Size = new Size(119, 41);
			btCapnhat.TabIndex = 3;
			btCapnhat.Text = "Cập nhật";
			btCapnhat.UseVisualStyleBackColor = false;
			btCapnhat.Click += btCapnhat_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(lstLopA);
			groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
			groupBox1.ForeColor = Color.FromArgb(185, 81, 88);
			groupBox1.Location = new Point(12, 159);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(284, 404);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Lớp A";
			// 
			// lstLopA
			// 
			lstLopA.BackColor = Color.FromArgb(242, 232, 230);
			lstLopA.ForeColor = Color.FromArgb(183, 71, 79);
			lstLopA.FormattingEnabled = true;
			lstLopA.Location = new Point(6, 34);
			lstLopA.Name = "lstLopA";
			lstLopA.Size = new Size(272, 356);
			lstLopA.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.Transparent;
			groupBox2.Controls.Add(lstLopB);
			groupBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
			groupBox2.ForeColor = Color.FromArgb(185, 81, 88);
			groupBox2.Location = new Point(484, 159);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(282, 404);
			groupBox2.TabIndex = 5;
			groupBox2.TabStop = false;
			groupBox2.Text = "Lớp B";
			// 
			// lstLopB
			// 
			lstLopB.BackColor = Color.FromArgb(242, 232, 230);
			lstLopB.ForeColor = Color.FromArgb(183, 71, 79);
			lstLopB.FormattingEnabled = true;
			lstLopB.Location = new Point(6, 34);
			lstLopB.Name = "lstLopB";
			lstLopB.Size = new Size(270, 356);
			lstLopB.TabIndex = 1;
			// 
			// btTraisangphai
			// 
			btTraisangphai.BackColor = Color.FromArgb(242, 232, 230);
			btTraisangphai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btTraisangphai.ForeColor = Color.FromArgb(183, 71, 79);
			btTraisangphai.Location = new Point(302, 256);
			btTraisangphai.Name = "btTraisangphai";
			btTraisangphai.Size = new Size(67, 46);
			btTraisangphai.TabIndex = 6;
			btTraisangphai.Text = ">";
			btTraisangphai.UseVisualStyleBackColor = false;
			btTraisangphai.Click += btTraisangphai_Click;
			// 
			// btTatcasangphai
			// 
			btTatcasangphai.BackColor = Color.FromArgb(242, 232, 230);
			btTatcasangphai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btTatcasangphai.ForeColor = Color.FromArgb(183, 71, 79);
			btTatcasangphai.Location = new Point(302, 308);
			btTatcasangphai.Name = "btTatcasangphai";
			btTatcasangphai.Size = new Size(67, 46);
			btTatcasangphai.TabIndex = 7;
			btTatcasangphai.Text = ">>";
			btTatcasangphai.UseVisualStyleBackColor = false;
			btTatcasangphai.Click += btTatcasangphai_Click;
			// 
			// btPhaisangtrai
			// 
			btPhaisangtrai.BackColor = Color.FromArgb(242, 232, 230);
			btPhaisangtrai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btPhaisangtrai.ForeColor = Color.FromArgb(183, 71, 79);
			btPhaisangtrai.Location = new Point(411, 256);
			btPhaisangtrai.Name = "btPhaisangtrai";
			btPhaisangtrai.Size = new Size(67, 46);
			btPhaisangtrai.TabIndex = 8;
			btPhaisangtrai.Text = "<";
			btPhaisangtrai.UseVisualStyleBackColor = false;
			btPhaisangtrai.Click += btPhaisangtrai_Click;
			// 
			// btTatcasangtrai
			// 
			btTatcasangtrai.BackColor = Color.FromArgb(242, 232, 230);
			btTatcasangtrai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btTatcasangtrai.ForeColor = Color.FromArgb(183, 71, 79);
			btTatcasangtrai.Location = new Point(411, 308);
			btTatcasangtrai.Name = "btTatcasangtrai";
			btTatcasangtrai.Size = new Size(67, 46);
			btTatcasangtrai.TabIndex = 9;
			btTatcasangtrai.Text = "<<";
			btTatcasangtrai.UseVisualStyleBackColor = false;
			btTatcasangtrai.Click += btTatcasangtrai_Click;
			// 
			// btKetthuc
			// 
			btKetthuc.BackColor = Color.FromArgb(242, 232, 230);
			btKetthuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btKetthuc.ForeColor = Color.FromArgb(183, 71, 79);
			btKetthuc.Location = new Point(411, 579);
			btKetthuc.Name = "btKetthuc";
			btKetthuc.Size = new Size(119, 41);
			btKetthuc.TabIndex = 10;
			btKetthuc.Text = "Kết thúc";
			btKetthuc.UseVisualStyleBackColor = false;
			btKetthuc.Click += btKetthuc_Click;
			// 
			// btXoa
			// 
			btXoa.BackColor = Color.FromArgb(242, 232, 230);
			btXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			btXoa.ForeColor = Color.FromArgb(183, 71, 79);
			btXoa.Location = new Point(250, 579);
			btXoa.Name = "btXoa";
			btXoa.Size = new Size(119, 41);
			btXoa.TabIndex = 10;
			btXoa.Text = "Xóa";
			btXoa.UseVisualStyleBackColor = false;
			btXoa.Click += btXoa_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(240, 169, 169);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(778, 632);
			Controls.Add(btXoa);
			Controls.Add(btKetthuc);
			Controls.Add(btTatcasangtrai);
			Controls.Add(btPhaisangtrai);
			Controls.Add(btTatcasangphai);
			Controls.Add(btTraisangphai);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(btCapnhat);
			Controls.Add(txtHoten);
			Controls.Add(label2);
			Controls.Add(label1);
			DoubleBuffered = true;
			Name = "Form1";
			Text = "Quản Lý Sinh Viên";
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtHoten;
		private Button btCapnhat;
		private GroupBox groupBox1;
		private ListBox lstLopA;
		private GroupBox groupBox2;
		private ListBox lstLopB;
		private Button btTraisangphai;
		private Button btTatcasangphai;
		private Button btPhaisangtrai;
		private Button btTatcasangtrai;
		private Button btKetthuc;
		private Button btXoa;
	}
}
