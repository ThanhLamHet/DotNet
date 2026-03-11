namespace Lab_3
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
			label1 = new Label();
			txtSoN = new TextBox();
			label2 = new Label();
			label3 = new Label();
			txtSoM = new TextBox();
			label4 = new Label();
			txtKetQua = new TextBox();
			btnCong = new Button();
			btnTru = new Button();
			btnNhan = new Button();
			btnChia = new Button();
			btnXoa = new Button();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			btnThoat = new Button();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = SystemColors.Info;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.IndianRed;
			label1.Location = new Point(12, 20);
			label1.Name = "label1";
			label1.Size = new Size(575, 55);
			label1.TabIndex = 0;
			label1.Text = "Thực Hiện Các Phép Tính";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtSoN
			// 
			txtSoN.Location = new Point(126, 140);
			txtSoN.Name = "txtSoN";
			txtSoN.Size = new Size(262, 27);
			txtSoN.TabIndex = 1;
			txtSoN.TextAlign = HorizontalAlignment.Right;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(71, 144);
			label2.Name = "label2";
			label2.Size = new Size(47, 23);
			label2.TabIndex = 2;
			label2.Text = "Số N";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(71, 195);
			label3.Name = "label3";
			label3.Size = new Size(49, 23);
			label3.TabIndex = 4;
			label3.Text = "Số M";
			// 
			// txtSoM
			// 
			txtSoM.Location = new Point(126, 191);
			txtSoM.Name = "txtSoM";
			txtSoM.Size = new Size(262, 27);
			txtSoM.TabIndex = 3;
			txtSoM.TextAlign = HorizontalAlignment.Right;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(48, 255);
			label4.Name = "label4";
			label4.Size = new Size(72, 23);
			label4.TabIndex = 6;
			label4.Text = "Kết Quả";
			// 
			// txtKetQua
			// 
			txtKetQua.BackColor = Color.PapayaWhip;
			txtKetQua.Location = new Point(126, 251);
			txtKetQua.Name = "txtKetQua";
			txtKetQua.Size = new Size(262, 27);
			txtKetQua.TabIndex = 5;
			txtKetQua.TextAlign = HorizontalAlignment.Right;
			// 
			// btnCong
			// 
			btnCong.Location = new Point(76, 326);
			btnCong.Name = "btnCong";
			btnCong.Size = new Size(66, 48);
			btnCong.TabIndex = 7;
			btnCong.Text = "+";
			btnCong.UseVisualStyleBackColor = true;
			btnCong.Click += btnCong_Click;
			// 
			// btnTru
			// 
			btnTru.Location = new Point(197, 326);
			btnTru.Name = "btnTru";
			btnTru.Size = new Size(66, 48);
			btnTru.TabIndex = 8;
			btnTru.Text = "-";
			btnTru.UseVisualStyleBackColor = true;
			btnTru.Click += btnTru_Click;
			// 
			// btnNhan
			// 
			btnNhan.Location = new Point(322, 326);
			btnNhan.Name = "btnNhan";
			btnNhan.Size = new Size(66, 48);
			btnNhan.TabIndex = 9;
			btnNhan.Text = "x";
			btnNhan.UseVisualStyleBackColor = true;
			btnNhan.Click += btnNhan_Click;
			// 
			// btnChia
			// 
			btnChia.Location = new Point(454, 326);
			btnChia.Name = "btnChia";
			btnChia.Size = new Size(66, 48);
			btnChia.TabIndex = 10;
			btnChia.Text = "/";
			btnChia.UseVisualStyleBackColor = true;
			btnChia.Click += btnChia_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(6, 165);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(93, 48);
			btnXoa.TabIndex = 11;
			btnXoa.Text = "Xoa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// groupBox1
			// 
			groupBox1.Location = new Point(53, 309);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(483, 75);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnThoat);
			groupBox2.Controls.Add(btnXoa);
			groupBox2.Location = new Point(431, 78);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(105, 226);
			groupBox2.TabIndex = 13;
			groupBox2.TabStop = false;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(6, 89);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(93, 48);
			btnThoat.TabIndex = 12;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(599, 451);
			Controls.Add(btnChia);
			Controls.Add(btnNhan);
			Controls.Add(btnTru);
			Controls.Add(btnCong);
			Controls.Add(label4);
			Controls.Add(txtKetQua);
			Controls.Add(label3);
			Controls.Add(txtSoM);
			Controls.Add(label2);
			Controls.Add(txtSoN);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Name = "Form1";
			Text = "Form1";
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtSoN;
		private Label label2;
		private Label label3;
		private TextBox txtSoM;
		private Label label4;
		private TextBox txtKetQua;
		private Button btnCong;
		private Button btnTru;
		private Button btnNhan;
		private Button btnChia;
		private Button btnXoa;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Button btnThoat;
	}
}
