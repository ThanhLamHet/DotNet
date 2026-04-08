namespace Nhom10_QLKhachSan_CuoiKi
{
    partial class frmBaoCao
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			panelTop = new Panel();
			btnXuatExcel = new Button();
			btnThongKe = new Button();
			dtpDenNgay = new DateTimePicker();
			lblDenNgay = new Label();
			dtpTuNgay = new DateTimePicker();
			lblTuNgay = new Label();
			panelBottom = new Panel();
			lblTongDoanhThu = new Label();
			lblSoDon = new Label();
			chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
			dgvBaoCao = new DataGridView();
			panelTop.SuspendLayout();
			panelBottom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.BackColor = Color.White;
			panelTop.Controls.Add(btnXuatExcel);
			panelTop.Controls.Add(btnThongKe);
			panelTop.Controls.Add(dtpDenNgay);
			panelTop.Controls.Add(lblDenNgay);
			panelTop.Controls.Add(dtpTuNgay);
			panelTop.Controls.Add(lblTuNgay);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Size = new Size(984, 70);
			panelTop.TabIndex = 0;
			// 
			// btnXuatExcel
			// 
			btnXuatExcel.BackColor = Color.FromArgb(39, 174, 96);
			btnXuatExcel.Cursor = Cursors.Hand;
			btnXuatExcel.FlatAppearance.BorderSize = 0;
			btnXuatExcel.FlatStyle = FlatStyle.Flat;
			btnXuatExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
			btnXuatExcel.ForeColor = Color.White;
			btnXuatExcel.Location = new Point(653, 12);
			btnXuatExcel.Name = "btnXuatExcel";
			btnXuatExcel.Size = new Size(110, 32);
			btnXuatExcel.TabIndex = 5;
			btnXuatExcel.Text = "Xuất Excel";
			btnXuatExcel.UseVisualStyleBackColor = false;
			// 
			// btnThongKe
			// 
			btnThongKe.BackColor = Color.FromArgb(41, 128, 185);
			btnThongKe.Cursor = Cursors.Hand;
			btnThongKe.FlatAppearance.BorderSize = 0;
			btnThongKe.FlatStyle = FlatStyle.Flat;
			btnThongKe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
			btnThongKe.ForeColor = Color.White;
			btnThongKe.Location = new Point(528, 12);
			btnThongKe.Name = "btnThongKe";
			btnThongKe.Size = new Size(110, 32);
			btnThongKe.TabIndex = 4;
			btnThongKe.Text = "Lọc Dữ Liệu";
			btnThongKe.UseVisualStyleBackColor = false;
			// 
			// dtpDenNgay
			// 
			dtpDenNgay.CustomFormat = "dd/MM/yyyy";
			dtpDenNgay.Font = new Font("Segoe UI", 10F);
			dtpDenNgay.Format = DateTimePickerFormat.Custom;
			dtpDenNgay.Location = new Point(368, 15);
			dtpDenNgay.Name = "dtpDenNgay";
			dtpDenNgay.Size = new Size(130, 30);
			dtpDenNgay.TabIndex = 3;
			// 
			// lblDenNgay
			// 
			lblDenNgay.AutoSize = true;
			lblDenNgay.Font = new Font("Segoe UI", 10F);
			lblDenNgay.Location = new Point(275, 17);
			lblDenNgay.Name = "lblDenNgay";
			lblDenNgay.Size = new Size(87, 23);
			lblDenNgay.TabIndex = 2;
			lblDenNgay.Text = "Đến ngày:";
			// 
			// dtpTuNgay
			// 
			dtpTuNgay.CustomFormat = "dd/MM/yyyy";
			dtpTuNgay.Font = new Font("Segoe UI", 10F);
			dtpTuNgay.Format = DateTimePickerFormat.Custom;
			dtpTuNgay.Location = new Point(124, 15);
			dtpTuNgay.Name = "dtpTuNgay";
			dtpTuNgay.Size = new Size(130, 30);
			dtpTuNgay.TabIndex = 1;
			// 
			// lblTuNgay
			// 
			lblTuNgay.AutoSize = true;
			lblTuNgay.Font = new Font("Segoe UI", 10F);
			lblTuNgay.Location = new Point(43, 17);
			lblTuNgay.Name = "lblTuNgay";
			lblTuNgay.Size = new Size(75, 23);
			lblTuNgay.TabIndex = 0;
			lblTuNgay.Text = "Từ ngày:";
			// 
			// panelBottom
			// 
			panelBottom.BackColor = Color.FromArgb(236, 240, 241);
			panelBottom.Controls.Add(lblTongDoanhThu);
			panelBottom.Controls.Add(lblSoDon);
			panelBottom.Dock = DockStyle.Bottom;
			panelBottom.Location = new Point(0, 551);
			panelBottom.Name = "panelBottom";
			panelBottom.Size = new Size(984, 60);
			panelBottom.TabIndex = 1;
			// 
			// lblTongDoanhThu
			// 
			lblTongDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblTongDoanhThu.AutoSize = true;
			lblTongDoanhThu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			lblTongDoanhThu.ForeColor = Color.FromArgb(192, 57, 43);
			lblTongDoanhThu.Location = new Point(540, 13);
			lblTongDoanhThu.Name = "lblTongDoanhThu";
			lblTongDoanhThu.Size = new Size(361, 37);
			lblTongDoanhThu.TabIndex = 1;
			lblTongDoanhThu.Text = "TỔNG DOANH THU: 0 VNĐ";
			// 
			// lblSoDon
			// 
			lblSoDon.AutoSize = true;
			lblSoDon.Font = new Font("Segoe UI", 12F);
			lblSoDon.ForeColor = Color.FromArgb(52, 73, 94);
			lblSoDon.Location = new Point(20, 20);
			lblSoDon.Name = "lblSoDon";
			lblSoDon.Size = new Size(180, 28);
			lblSoDon.TabIndex = 0;
			lblSoDon.Text = "Tổng số hóa đơn: 0";
			// 
			// chartDoanhThu
			// 
			chartArea1.Name = "ChartArea1";
			chartDoanhThu.ChartAreas.Add(chartArea1);
			chartDoanhThu.Dock = DockStyle.Top;
			legend1.Name = "Legend1";
			chartDoanhThu.Legends.Add(legend1);
			chartDoanhThu.Location = new Point(0, 70);
			chartDoanhThu.Name = "chartDoanhThu";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartDoanhThu.Series.Add(series1);
			chartDoanhThu.Size = new Size(984, 250);
			chartDoanhThu.TabIndex = 6;
			chartDoanhThu.Text = "chartDoanhThu";
			chartDoanhThu.Click += chartDoanhThu_Click;
			// 
			// dgvBaoCao
			// 
			dgvBaoCao.BackgroundColor = Color.White;
			dgvBaoCao.BorderStyle = BorderStyle.None;
			dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBaoCao.Dock = DockStyle.Fill;
			dgvBaoCao.Location = new Point(0, 320);
			dgvBaoCao.Name = "dgvBaoCao";
			dgvBaoCao.RowHeadersWidth = 51;
			dgvBaoCao.Size = new Size(984, 231);
			dgvBaoCao.TabIndex = 2;
			// 
			// frmBaoCao
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(984, 611);
			Controls.Add(dgvBaoCao);
			Controls.Add(chartDoanhThu);
			Controls.Add(panelBottom);
			Controls.Add(panelTop);
			Font = new Font("Segoe UI", 9.75F);
			Name = "frmBaoCao";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Báo Cáo Doanh Thu";
			panelTop.ResumeLayout(false);
			panelTop.PerformLayout();
			panelBottom.ResumeLayout(false);
			panelBottom.PerformLayout();
			((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblSoDon;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
    }
}