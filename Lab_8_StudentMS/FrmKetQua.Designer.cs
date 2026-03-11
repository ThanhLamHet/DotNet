namespace Lab_8_StudentMS
{
	partial class FrmKetQua
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
			label1 = new Label();
			txtDiem = new TextBox();
			btnLuu = new Button();
			btnXoa = new Button();
			btnThem = new Button();
			label5 = new Label();
			label4 = new Label();
			dataGridViewDiem = new DataGridView();
			groupBox1 = new GroupBox();
			txtMaMH = new TextBox();
			txtMaSV = new TextBox();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewDiem).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(40, 39, 81);
			label1.Location = new Point(77, 134);
			label1.Name = "label1";
			label1.Size = new Size(55, 20);
			label1.TabIndex = 36;
			label1.Text = "Điểm:";
			// 
			// txtDiem
			// 
			txtDiem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtDiem.Location = new Point(145, 131);
			txtDiem.Name = "txtDiem";
			txtDiem.Size = new Size(299, 28);
			txtDiem.TabIndex = 35;
			// 
			// btnLuu
			// 
			btnLuu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnLuu.ForeColor = Color.FromArgb(40, 39, 81);
			btnLuu.Location = new Point(733, 137);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(110, 54);
			btnLuu.TabIndex = 34;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(40, 39, 81);
			btnXoa.Location = new Point(669, 197);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(110, 54);
			btnXoa.TabIndex = 33;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(40, 39, 81);
			btnThem.Location = new Point(603, 137);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(110, 54);
			btnThem.TabIndex = 32;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label5.ForeColor = Color.FromArgb(40, 39, 81);
			label5.Location = new Point(16, 86);
			label5.Name = "label5";
			label5.Size = new Size(113, 20);
			label5.TabIndex = 31;
			label5.Text = "MãMôn Học:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label4.ForeColor = Color.FromArgb(40, 39, 81);
			label4.Location = new Point(9, 40);
			label4.Name = "label4";
			label4.Size = new Size(120, 20);
			label4.TabIndex = 30;
			label4.Text = "Mã Sinh Viên:";
			// 
			// dataGridViewDiem
			// 
			dataGridViewDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewDiem.Location = new Point(12, 293);
			dataGridViewDiem.Name = "dataGridViewDiem";
			dataGridViewDiem.RowHeadersWidth = 51;
			dataGridViewDiem.Size = new Size(870, 275);
			dataGridViewDiem.TabIndex = 39;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(txtMaMH);
			groupBox1.Controls.Add(txtMaSV);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(txtDiem);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 97);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(514, 176);
			groupBox1.TabIndex = 40;
			groupBox1.TabStop = false;
			// 
			// txtMaMH
			// 
			txtMaMH.Location = new Point(145, 83);
			txtMaMH.Name = "txtMaMH";
			txtMaMH.Size = new Size(299, 27);
			txtMaMH.TabIndex = 38;
			// 
			// txtMaSV
			// 
			txtMaSV.Location = new Point(145, 37);
			txtMaSV.Name = "txtMaSV";
			txtMaSV.Size = new Size(299, 27);
			txtMaSV.TabIndex = 37;
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.FromArgb(40, 39, 81);
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(870, 62);
			label2.TabIndex = 39;
			label2.Text = "Kết Quả";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// FrmKetQua
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(894, 580);
			Controls.Add(label2);
			Controls.Add(groupBox1);
			Controls.Add(dataGridViewDiem);
			Controls.Add(btnLuu);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Name = "FrmKetQua";
			Text = "FrmKetQua";
			Load += FrmKetQua_Load_1;
			((System.ComponentModel.ISupportInitialize)dataGridViewDiem).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TextBox txtDiem;
		private Button btnLuu;
		private Button btnXoa;
		private Button btnThem;
		private Label label5;
		private Label label4;
		private DataGridView dataGridViewDiem;
		private GroupBox groupBox1;
		private Label label2;
		private TextBox txtMaMH;
		private TextBox txtMaSV;
	}
}