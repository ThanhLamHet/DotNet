namespace Lab_8_StudentMS
{
	partial class FormMonHoc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonHoc));
			btnLuu = new Button();
			btnXoa = new Button();
			btnThem = new Button();
			label5 = new Label();
			label4 = new Label();
			txtTenMon = new TextBox();
			txtMaMon = new TextBox();
			dataGridViewMonHoc = new DataGridView();
			label1 = new Label();
			txtSoTiet = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).BeginInit();
			SuspendLayout();
			// 
			// btnLuu
			// 
			btnLuu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnLuu.ForeColor = Color.FromArgb(40, 39, 81);
			btnLuu.Location = new Point(702, 141);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(102, 38);
			btnLuu.TabIndex = 25;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// btnXoa
			// 
			btnXoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnXoa.ForeColor = Color.FromArgb(40, 39, 81);
			btnXoa.Location = new Point(636, 185);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(102, 38);
			btnXoa.TabIndex = 24;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThem
			// 
			btnThem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			btnThem.ForeColor = Color.FromArgb(40, 39, 81);
			btnThem.Location = new Point(572, 141);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(102, 38);
			btnThem.TabIndex = 23;
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
			label5.Location = new Point(16, 172);
			label5.Name = "label5";
			label5.Size = new Size(121, 20);
			label5.TabIndex = 22;
			label5.Text = "Tên Môn Học:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label4.ForeColor = Color.FromArgb(40, 39, 81);
			label4.Location = new Point(19, 126);
			label4.Name = "label4";
			label4.Size = new Size(118, 20);
			label4.TabIndex = 21;
			label4.Text = "Mã Môn Học:";
			// 
			// txtTenMon
			// 
			txtTenMon.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtTenMon.Location = new Point(155, 169);
			txtTenMon.Name = "txtTenMon";
			txtTenMon.Size = new Size(299, 28);
			txtTenMon.TabIndex = 20;
			// 
			// txtMaMon
			// 
			txtMaMon.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtMaMon.Location = new Point(155, 123);
			txtMaMon.Name = "txtMaMon";
			txtMaMon.Size = new Size(299, 28);
			txtMaMon.TabIndex = 19;
			// 
			// dataGridViewMonHoc
			// 
			dataGridViewMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewMonHoc.Location = new Point(12, 346);
			dataGridViewMonHoc.Name = "dataGridViewMonHoc";
			dataGridViewMonHoc.RowHeadersWidth = 51;
			dataGridViewMonHoc.Size = new Size(792, 284);
			dataGridViewMonHoc.TabIndex = 18;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(40, 39, 81);
			label1.Location = new Point(68, 220);
			label1.Name = "label1";
			label1.Size = new Size(69, 20);
			label1.TabIndex = 27;
			label1.Text = "Số Tiết:";
			// 
			// txtSoTiet
			// 
			txtSoTiet.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
			txtSoTiet.Location = new Point(155, 217);
			txtSoTiet.Name = "txtSoTiet";
			txtSoTiet.Size = new Size(299, 28);
			txtSoTiet.TabIndex = 26;
			// 
			// FormMonHoc
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(142, 172, 222);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(820, 642);
			Controls.Add(label1);
			Controls.Add(txtSoTiet);
			Controls.Add(btnLuu);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(txtTenMon);
			Controls.Add(txtMaMon);
			Controls.Add(dataGridViewMonHoc);
			DoubleBuffered = true;
			Name = "FormMonHoc";
			Text = "FormMonHoc";
			Load += FormMonHoc_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLuu;
		private Button btnXoa;
		private Button btnThem;
		private Label label5;
		private Label label4;
		private TextBox txtTenMon;
		private TextBox txtMaMon;
		private DataGridView dataGridViewMonHoc;
		private Label label1;
		private TextBox txtSoTiet;
	}
}