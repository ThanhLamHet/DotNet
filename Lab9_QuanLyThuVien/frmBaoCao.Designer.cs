namespace Lab9_QuanLyThuVien
{
	partial class frmBaoCao
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
			cbLoaiBaoCao = new ComboBox();
			label3 = new Label();
			dgvBaoCao = new DataGridView();
			btnThongKe = new Button();
			((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(52, 150);
			label1.Name = "label1";
			label1.Size = new Size(101, 19);
			label1.TabIndex = 40;
			label1.Text = "Loại báo cáo:";
			// 
			// cbLoaiBaoCao
			// 
			cbLoaiBaoCao.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbLoaiBaoCao.FormattingEnabled = true;
			cbLoaiBaoCao.Location = new Point(159, 147);
			cbLoaiBaoCao.Name = "cbLoaiBaoCao";
			cbLoaiBaoCao.Size = new Size(250, 27);
			cbLoaiBaoCao.TabIndex = 39;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(12, 9);
			label3.Name = "label3";
			label3.Size = new Size(881, 51);
			label3.TabIndex = 42;
			label3.Text = "Báo Cáo";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dgvBaoCao
			// 
			dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBaoCao.Location = new Point(12, 294);
			dgvBaoCao.Name = "dgvBaoCao";
			dgvBaoCao.RowHeadersWidth = 51;
			dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvBaoCao.Size = new Size(881, 266);
			dgvBaoCao.TabIndex = 48;
			// 
			// btnThongKe
			// 
			btnThongKe.Font = new Font("Times New Roman", 10.2F);
			btnThongKe.Location = new Point(441, 140);
			btnThongKe.Name = "btnThongKe";
			btnThongKe.Size = new Size(106, 39);
			btnThongKe.TabIndex = 49;
			btnThongKe.Text = "Thống kê";
			btnThongKe.UseVisualStyleBackColor = true;
			btnThongKe.Click += btnThongKe_Click;
			// 
			// frmBaoCao
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(905, 572);
			Controls.Add(btnThongKe);
			Controls.Add(dgvBaoCao);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(cbLoaiBaoCao);
			Name = "frmBaoCao";
			Text = "frmBaoCao";
			Load += frmBaoCao_Load;
			((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox cbLoaiBaoCao;
		private Label label3;
		private DataGridView dgvBaoCao;
		private Button btnThongKe;
	}
}