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
			cboNhanVien = new ComboBox();
			lblNhanVien = new Label();
			btnInPDF = new Button();
			btnXuatExcel = new Button();
			btnThongKe = new Button();
			cboLoaiBaoCao = new ComboBox();
			lblLoaiBaoCao = new Label();
			dtpDenNgay = new DateTimePicker();
			lblDenNgay = new Label();
			dtpTuNgay = new DateTimePicker();
			lblTuNgay = new Label();
			panelBottom = new Panel();
			lblCongSuat = new Label();
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
			panelTop.Controls.Add(cboNhanVien);
			panelTop.Controls.Add(lblNhanVien);
			panelTop.Controls.Add(btnInPDF);
			panelTop.Controls.Add(btnXuatExcel);
			panelTop.Controls.Add(btnThongKe);
			panelTop.Controls.Add(cboLoaiBaoCao);
			panelTop.Controls.Add(lblLoaiBaoCao);
			panelTop.Controls.Add(dtpDenNgay);
			panelTop.Controls.Add(lblDenNgay);
			panelTop.Controls.Add(dtpTuNgay);
			panelTop.Controls.Add(lblTuNgay);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Size = new Size(1100, 100);
			panelTop.TabIndex = 0;
			panelTop.Paint += panelTop_Paint;
			// 
			// cboNhanVien
			// 
			cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
			cboNhanVien.FormattingEnabled = true;
			cboNhanVien.Location = new Point(540, 58);
			cboNhanVien.Name = "cboNhanVien";
			cboNhanVien.Size = new Size(160, 29);
			cboNhanVien.TabIndex = 9;
			cboNhanVien.SelectedIndexChanged += cboNhanVien_SelectedIndexChanged;
			// 
			// lblNhanVien
			// 
			lblNhanVien.AutoSize = true;
			lblNhanVien.Location = new Point(447, 62);
			lblNhanVien.Name = "lblNhanVien";
			lblNhanVien.Size = new Size(92, 23);
			lblNhanVien.TabIndex = 8;
			lblNhanVien.Text = "Nhân viên:";
			// 
			// btnInPDF
			// 
			btnInPDF.BackColor = Color.FromArgb(231, 76, 60);
			btnInPDF.FlatStyle = FlatStyle.Flat;
			btnInPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnInPDF.ForeColor = Color.White;
			btnInPDF.Location = new Point(960, 55);
			btnInPDF.Name = "btnInPDF";
			btnInPDF.Size = new Size(110, 32);
			btnInPDF.TabIndex = 6;
			btnInPDF.Text = "In Báo Cáo PDF";
			btnInPDF.UseVisualStyleBackColor = false;
			// 
			// btnXuatExcel
			// 
			btnXuatExcel.BackColor = Color.FromArgb(39, 174, 96);
			btnXuatExcel.FlatStyle = FlatStyle.Flat;
			btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnXuatExcel.ForeColor = Color.White;
			btnXuatExcel.Location = new Point(840, 55);
			btnXuatExcel.Name = "btnXuatExcel";
			btnXuatExcel.Size = new Size(110, 32);
			btnXuatExcel.TabIndex = 5;
			btnXuatExcel.Text = "Xuất Excel";
			btnXuatExcel.UseVisualStyleBackColor = false;
			// 
			// btnThongKe
			// 
			btnThongKe.BackColor = Color.FromArgb(41, 128, 185);
			btnThongKe.FlatStyle = FlatStyle.Flat;
			btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnThongKe.ForeColor = Color.White;
			btnThongKe.Location = new Point(720, 55);
			btnThongKe.Name = "btnThongKe";
			btnThongKe.Size = new Size(110, 32);
			btnThongKe.TabIndex = 4;
			btnThongKe.Text = "Lọc Dữ Liệu";
			btnThongKe.UseVisualStyleBackColor = false;
			// 
			// cboLoaiBaoCao
			// 
			cboLoaiBaoCao.DropDownStyle = ComboBoxStyle.DropDownList;
			cboLoaiBaoCao.Location = new Point(540, 18);
			cboLoaiBaoCao.Name = "cboLoaiBaoCao";
			cboLoaiBaoCao.Size = new Size(160, 29);
			cboLoaiBaoCao.TabIndex = 7;
			// 
			// lblLoaiBaoCao
			// 
			lblLoaiBaoCao.AutoSize = true;
			lblLoaiBaoCao.Location = new Point(447, 20);
			lblLoaiBaoCao.Name = "lblLoaiBaoCao";
			lblLoaiBaoCao.Size = new Size(111, 23);
			lblLoaiBaoCao.TabIndex = 6;
			lblLoaiBaoCao.Text = "Loại báo cáo:";
			// 
			// dtpDenNgay
			// 
			dtpDenNgay.Format = DateTimePickerFormat.Short;
			dtpDenNgay.Location = new Point(300, 20);
			dtpDenNgay.Name = "dtpDenNgay";
			dtpDenNgay.Size = new Size(130, 29);
			dtpDenNgay.TabIndex = 3;
			// 
			// lblDenNgay
			// 
			lblDenNgay.AutoSize = true;
			lblDenNgay.Location = new Point(230, 24);
			lblDenNgay.Name = "lblDenNgay";
			lblDenNgay.Size = new Size(87, 23);
			lblDenNgay.TabIndex = 2;
			lblDenNgay.Text = "Đến ngày:";
			// 
			// dtpTuNgay
			// 
			dtpTuNgay.Format = DateTimePickerFormat.Short;
			dtpTuNgay.Location = new Point(80, 20);
			dtpTuNgay.Name = "dtpTuNgay";
			dtpTuNgay.Size = new Size(130, 29);
			dtpTuNgay.TabIndex = 1;
			// 
			// lblTuNgay
			// 
			lblTuNgay.AutoSize = true;
			lblTuNgay.Location = new Point(15, 24);
			lblTuNgay.Name = "lblTuNgay";
			lblTuNgay.Size = new Size(75, 23);
			lblTuNgay.TabIndex = 0;
			lblTuNgay.Text = "Từ ngày:";
			// 
			// panelBottom
			// 
			panelBottom.BackColor = Color.FromArgb(236, 240, 241);
			panelBottom.Controls.Add(lblCongSuat);
			panelBottom.Controls.Add(lblTongDoanhThu);
			panelBottom.Controls.Add(lblSoDon);
			panelBottom.Dock = DockStyle.Bottom;
			panelBottom.Location = new Point(0, 600);
			panelBottom.Name = "panelBottom";
			panelBottom.Size = new Size(1100, 60);
			panelBottom.TabIndex = 1;
			// 
			// lblCongSuat
			// 
			lblCongSuat.AutoSize = true;
			lblCongSuat.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
			lblCongSuat.Location = new Point(250, 20);
			lblCongSuat.Name = "lblCongSuat";
			lblCongSuat.Size = new Size(168, 23);
			lblCongSuat.TabIndex = 2;
			lblCongSuat.Text = "Công suất phòng: 0%";
			// 
			// lblTongDoanhThu
			// 
			lblTongDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblTongDoanhThu.AutoSize = true;
			lblTongDoanhThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			lblTongDoanhThu.ForeColor = Color.FromArgb(192, 57, 43);
			lblTongDoanhThu.Location = new Point(750, 15);
			lblTongDoanhThu.Name = "lblTongDoanhThu";
			lblTongDoanhThu.Size = new Size(323, 32);
			lblTongDoanhThu.TabIndex = 1;
			lblTongDoanhThu.Text = "TỔNG DOANH THU: 0 VNĐ";
			// 
			// lblSoDon
			// 
			lblSoDon.AutoSize = true;
			lblSoDon.Location = new Point(20, 20);
			lblSoDon.Name = "lblSoDon";
			lblSoDon.Size = new Size(158, 23);
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
			chartDoanhThu.Location = new Point(0, 100);
			chartDoanhThu.Name = "chartDoanhThu";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartDoanhThu.Series.Add(series1);
			chartDoanhThu.Size = new Size(1100, 250);
			chartDoanhThu.TabIndex = 6;
			// 
			// dgvBaoCao
			// 
			dgvBaoCao.BackgroundColor = Color.White;
			dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBaoCao.Dock = DockStyle.Fill;
			dgvBaoCao.Location = new Point(0, 350);
			dgvBaoCao.Name = "dgvBaoCao";
			dgvBaoCao.RowHeadersWidth = 51;
			dgvBaoCao.Size = new Size(1100, 250);
			dgvBaoCao.TabIndex = 2;
			// 
			// frmBaoCao
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1100, 660);
			Controls.Add(dgvBaoCao);
			Controls.Add(chartDoanhThu);
			Controls.Add(panelBottom);
			Controls.Add(panelTop);
			Font = new Font("Segoe UI", 9.75F);
			Name = "frmBaoCao";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Hệ Thống Báo Cáo Chuyên Nghiệp";
			panelTop.ResumeLayout(false);
			panelTop.PerformLayout();
			panelBottom.ResumeLayout(false);
			panelBottom.PerformLayout();
			((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTop;
        private Button btnXuatExcel;
        private Button btnThongKe;
        private Button btnInPDF;
        private DateTimePicker dtpDenNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblTuNgay;
        private Panel panelBottom;
        private Label lblTongDoanhThu;
        private Label lblSoDon;
        private Label lblCongSuat;
        private DataGridView dgvBaoCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private ComboBox cboLoaiBaoCao;
        private Label lblLoaiBaoCao;
        private ComboBox cboNhanVien;
        private Label lblNhanVien;
    }
}