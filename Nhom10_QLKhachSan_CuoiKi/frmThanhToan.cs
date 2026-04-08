using Microsoft.EntityFrameworkCore;
using Nhom10_QLKhachSan_CuoiKi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Nhom10_QLKhachSan_CuoiKi
{
    public partial class frmThanhToan : Form
    {
        private QLKhachSanContext db = new QLKhachSanContext();
        decimal tienPhong = 0;
        decimal tienDV = 0;
		decimal? giam = 0;
		decimal? khuyenmai = 0;
		PrintDocument printDoc = new PrintDocument();
        Bitmap qrBitmap;
        public frmThanhToan()
        {
            InitializeComponent();
        }
        private void LoadDonChuaThanhToan()
        {
            cboDonDP.DataSource = db.Datphongs
                                .Where(dp => !db.Hoadons.Any(hd => hd.MaDp == dp.MaDp))
                                .ToList(); ;
            cboDonDP.DisplayMember = "MaDp";
            cboDonDP.ValueMember = "MaDp";
        }
        private void LoadKhuyenMai()
        {
            var km = db.Khuyenmais.ToList();

            cboMaKM.DataSource = km;
            cboMaKM.DisplayMember = "TenKm";
            cboMaKM.ValueMember = "MaKm";
        }
        private void LoadThongTinChung(int maDP)
        {
            var dp = db.Datphongs
                .Where(x => x.MaDp == maDP)
                .Select(x => new
                {
                    TenKH = x.MaKhNavigation.HoTen,
                    TenNV = x.MaNvNavigation.HoTen,
					x.TienCoc
                })
                .FirstOrDefault();

            if (dp != null)
            {
                txtTenKH.Text = dp.TenKH;
                txtTenNV.Text = dp.TenNV;
				giam += dp.TienCoc;
				lblTienGiam.Text = giam.ToString();
            }
        }
        private void LoadPhong(int maDP)
        {
            var ds = (from ct in db.ChitietDps
                      join p in db.Phongs on ct.MaPhong equals p.MaPhong
                      where ct.MaDp == maDP
                      select new
                      {
                          p.TenPhong,
                          ct.NgayNhanDk,
                          ct.NgayTraDk,
                          ct.GiaThucTe,

                          SoNgay = Math.Max(1,
                                    (int)Math.Ceiling(
                                        (ct.NgayTraDk - ct.NgayNhanDk).Value.TotalDays
                                    )),

                          ThanhTien = Math.Max(1,
                                        (int)Math.Ceiling(
                                            (ct.NgayTraDk - ct.NgayNhanDk).Value.TotalDays
                                        )) * (ct.GiaThucTe ?? 0)
                      }).ToList();

            dgvPhong.DataSource = ds;
           // dgvPhong.Columns["GiaThucTe"].DefaultCellStyle.Format = "N0";
           // dgvPhong.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }
        private void LoadDichVu(int maDP)
        {
            var ds = (from sd in db.SudungDvs
                      join dv in db.Dichvus on sd.MaDv equals dv.MaDv
                      join ct in db.ChitietDps on sd.MaCtdp equals ct.MaCtdp
                      where ct.MaDp == maDP
                      select new
                      {
                          dv.TenDv,
                          sd.SoLuong,
                          sd.DonGiaThucTe,
                          ThanhTien = (sd.SoLuong ?? 0) * (sd.DonGiaThucTe ?? 0)
                      }).ToList();

            dgvDichVu.DataSource = ds;

           // dgvDichVu.Columns["DonGiaThucTe"].DefaultCellStyle.Format = "N0";
           // dgvDichVu.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }
        private void TinhTien(int maDP)
        {
            tienPhong = 0;
            tienDV = 0;

            var dsPhong = db.ChitietDps.Where(x => x.MaDp == maDP).ToList();

            foreach (var ct in dsPhong)
            {
                double soNgayRaw = (ct.NgayTraDk - ct.NgayNhanDk)?.TotalDays ?? 0;

                // Làm tròn lên và đảm bảo tối thiểu 1 ngày
                int soNgay = Math.Max(1, (int)Math.Ceiling(soNgayRaw));

                tienPhong += soNgay * (ct.GiaThucTe ?? 0);
            }

            var dsDV = (from sd in db.SudungDvs
                        join ct in db.ChitietDps on sd.MaCtdp equals ct.MaCtdp
                        where ct.MaDp == maDP
                        select sd).ToList();

            foreach (var dv in dsDV)
            {
                tienDV += (dv.SoLuong ?? 0) * (dv.DonGiaThucTe ?? 0);
            }

            lblTienPhong.Text = tienPhong.ToString();
            lblTienDV.Text = tienDV.ToString();
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
			// 1. Áp dụng giao diện đồng bộ
			ApplyModernUI();


			LoadDonChuaThanhToan();
            LoadKhuyenMai();
            cboDonDP.SelectedIndex = -1;
        }
		private void ApplyModernUI()
		{
			// Tông màu chủ đạo
			this.BackColor = Color.White;
			this.Font = new Font("Segoe UI", 10);

			// Style cho các nút bấm hành động (Sử dụng Find để tránh lỗi nếu tên Control bị thay đổi)
			if (this.Controls.Find("btnThanhToan", true).FirstOrDefault() is Button btnTT)
				StyleButton(btnTT, Color.FromArgb(34, 197, 94), Color.White);  // Xanh lá cho Thanh toán

			if (this.Controls.Find("btnInHoaDon", true).FirstOrDefault() is Button btnIn)
				StyleButton(btnIn, Color.FromArgb(30, 58, 138), Color.White);   // Xanh Navy cho In hóa đơn

			if (this.Controls.Find("btnTongTien", true).FirstOrDefault() is Button btnTong)
				StyleButton(btnTong, Color.FromArgb(71, 85, 105), Color.White); // Xám đá cho Tính tổng tiền

			// Chỉnh các ô nhập liệu và GroupBox (Dùng đệ quy)
			SetupVisualStyles(this);

			// Định dạng 2 bảng dữ liệu
			StyleDataGridView(dgvPhong);
			StyleDataGridView(dgvDichVu);
		}

		private void SetupVisualStyles(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is TextBox txt) txt.BorderStyle = BorderStyle.FixedSingle;
				if (c is ComboBox cbo) cbo.FlatStyle = FlatStyle.Flat;
				if (c is GroupBox gb)
				{
					gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
					gb.ForeColor = Color.FromArgb(30, 58, 138);
				}

				// Đệ quy để style cả các control nằm con trong GroupBox/Panel
				if (c.HasChildren)
				{
					SetupVisualStyles(c);
				}
			}
		}

		private void StyleButton(Button btn, Color backColor, Color foreColor)
		{
			btn.FlatStyle = FlatStyle.Flat;
			btn.BackColor = backColor;
			btn.ForeColor = foreColor;
			btn.FlatAppearance.BorderSize = 0;
			btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			btn.Cursor = Cursors.Hand;
			btn.Height = 35;
		}

		private void StyleDataGridView(DataGridView dgv)
		{
			dgv.BackgroundColor = Color.White;
			dgv.BorderStyle = BorderStyle.None;
			dgv.EnableHeadersVisualStyles = false;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.RowHeadersVisible = false;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Header
			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			dgv.ColumnHeadersHeight = 40;

			// Rows
			dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
			dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
			dgv.RowTemplate.Height = 35;
			dgv.GridColor = Color.FromArgb(241, 245, 249);
			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
		}

		private void btnTongTien_Click(object sender, EventArgs e)
        {
            int phuThu = 0;
			giam -= khuyenmai;
			khuyenmai = 0;
			if (cboDonDP.Text == "")
			{
				return;
			}
			int.TryParse(txtPhuThu.Text, out phuThu);

            if (cboMaKM.SelectedValue != null)
            {
                int maKM = (int)cboMaKM.SelectedValue;

                var km = db.Khuyenmais.Find(maKM);
                if (km != null)
                {
					khuyenmai = (tienPhong + tienDV) * (km.PhanTramGiam ?? 0) / 100;

					giam +=khuyenmai;
                }
            }

            lblTienGiam.Text = giam.ToString();

            int tong = Convert.ToInt32(tienPhong + tienDV + phuThu - giam);
            lblTongTien.Text = tong.ToString();
        }
        private string TaoVietQR(decimal soTien, string maDP)
        {
            string bank = "MB"; // MBBank, BIDV, VCB, TCB...
            string stk = "0383438198"; // số tài khoản của bạn
            string template = "compact";

            string noiDung = $"Thanh toan don {maDP}";
            string tenTK = "KHACH SAN NHOM 10";

            string url = $"https://img.vietqr.io/image/{bank}-{stk}-{template}.png" +
                         $"?amount={soTien}" +
                         $"&addInfo={Uri.EscapeDataString(noiDung)}" +
                         $"&accountName={Uri.EscapeDataString(tenTK)}";

            return url;
        }
		private void LoadQR()
		{
			// Loại bỏ dấu phẩy hoặc chấm nếu có trên Label trước khi chuyển thành số
			string rawTien = lblTongTien.Text.Replace(",", "").Replace(".", "");
			if (!decimal.TryParse(rawTien, out decimal soTien)) soTien = 0;

			string url = TaoVietQR(soTien, cboDonDP.Text);

			using (WebClient wc = new WebClient())
			{
				byte[] data = wc.DownloadData(url);
				using (MemoryStream ms = new MemoryStream(data))
				{
					qrBitmap = new Bitmap(ms);
				}
			}
		}
		private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			int startX = 50; // Lề trái
			int startY = 50; // Lề trên
			int width = e.PageBounds.Width - 100; // Độ rộng in khả dụng
			int y = startY;

			// --- KHAI BÁO FONT & BÚT VẼ ---
			Font titleFont = new Font("Courier New", 24, FontStyle.Bold); // Font giống máy in bill
			Font headerFont = new Font("Arial", 16, FontStyle.Bold);
			Font boldFont = new Font("Arial", 12, FontStyle.Bold);
			Font normalFont = new Font("Arial", 12);
			Font italicFont = new Font("Arial", 10, FontStyle.Italic);

			// Bút vẽ nét đứt (Dashed line) để làm đường phân cách
			Pen dashedPen = new Pen(Color.Black, 1);
			dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

			// --- 1. HEADER: THÔNG TIN KHÁCH SẠN ---
			string hotelName = "KHÁCH SẠN NHÓM 10";
			var nameSize = g.MeasureString(hotelName, titleFont);
			g.DrawString(hotelName, titleFont, Brushes.Black, startX + (width - nameSize.Width) / 2, y); // Căn giữa
			y += 40;

			string address = "123 Đường ABC, Biên Hòa, Đồng Nai";
			var addrSize = g.MeasureString(address, normalFont);
			g.DrawString(address, normalFont, Brushes.Black, startX + (width - addrSize.Width) / 2, y);
			y += 25;

			string phone = "Điện thoại: 038 343 8198";
			var phoneSize = g.MeasureString(phone, normalFont);
			g.DrawString(phone, normalFont, Brushes.Black, startX + (width - phoneSize.Width) / 2, y);
			y += 35;

			g.DrawLine(dashedPen, startX, y, startX + width, y);
			y += 20;

			// --- 2. TIÊU ĐỀ HÓA ĐƠN ---
			string invoiceTitle = "HÓA ĐƠN THANH TOÁN";
			var titleSize = g.MeasureString(invoiceTitle, headerFont);
			g.DrawString(invoiceTitle, headerFont, Brushes.Black, startX + (width - titleSize.Width) / 2, y);
			y += 40;

			// --- 3. THÔNG TIN CHUNG ---
			g.DrawString($"Mã Hóa Đơn: #{cboDonDP.Text}", boldFont, Brushes.Black, startX, y);
			g.DrawString($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}", normalFont, Brushes.Black, startX + width - 200, y);
			y += 30;
			g.DrawString($"Khách hàng: {txtTenKH.Text}", normalFont, Brushes.Black, startX, y);
			y += 30;
			g.DrawString($"Thu ngân: {txtTenNV.Text}", normalFont, Brushes.Black, startX, y);
			y += 30;

			g.DrawLine(dashedPen, startX, y, startX + width, y);
			y += 20;

			// --- 4. CHI TIẾT CHI PHÍ ---
			g.DrawString("MÔ TẢ", boldFont, Brushes.Black, startX, y);
			g.DrawString("THÀNH TIỀN", boldFont, Brushes.Black, startX + width - 110, y);
			y += 35;

			// Hàm phụ để in một dòng và tự động căn lề phải cho số tiền
			void DrawLineItem(string label, string amount, bool isTotal = false)
			{
				Font f = isTotal ? new Font("Arial", 16, FontStyle.Bold) : normalFont;
				Brush b = isTotal ? Brushes.DarkRed : Brushes.Black;

				// Tự động định dạng số tiền có dấu phẩy cho đẹp (VD: 1,500,000)
				string formattedAmount = amount;
				if (decimal.TryParse(amount.Replace(",", "").Replace(".", "."), out decimal parsedAmt))
				{
					formattedAmount = parsedAmt.ToString("N0");
				}

				g.DrawString(label, f, Brushes.Black, startX, y);
				var amtSize = g.MeasureString(formattedAmount, f);
				g.DrawString(formattedAmount, f, b, startX + width - amtSize.Width, y);
				y += (isTotal ? 40 : 30);
			}

			DrawLineItem("Tiền phòng:", lblTienPhong.Text);
			DrawLineItem("Tiền dịch vụ:", lblTienDV.Text);
			DrawLineItem("Phụ thu:", txtPhuThu.Text);

			// Chỉ in dòng giảm giá nếu có giảm giá
			if (lblTienGiam.Text != "0" && !string.IsNullOrEmpty(lblTienGiam.Text))
			{
				DrawLineItem("Giảm giá/Khuyến mãi:", "-" + lblTienGiam.Text);
			}

			y += 10;
			g.DrawLine(dashedPen, startX, y, startX + width, y);
			y += 20;

			// --- 5. TỔNG CỘNG ---
			DrawLineItem("TỔNG THANH TOÁN (VND):", lblTongTien.Text, true);
			y += 20;

			// --- 6. KHU VỰC QUÉT MÃ QR ---
			if (qrBitmap != null)
			{
				int qrSize = 160; // Kích thước QR Code
				int qrX = startX + (width - qrSize) / 2; // Tính toán để QR Code ra chính giữa

				// Vẽ một khung viền bao quanh QR Code
				g.DrawRectangle(Pens.DarkGray, qrX - 5, y - 5, qrSize + 10, qrSize + 10);
				g.DrawImage(qrBitmap, qrX, y, qrSize, qrSize);
				y += qrSize + 15;

				// Chú thích dưới QR Code
				string qrText1 = "Quét mã bằng ứng dụng Ngân hàng";
				string qrText2 = "để thanh toán nhanh chóng & chính xác";

				var text1Size = g.MeasureString(qrText1, italicFont);
				var text2Size = g.MeasureString(qrText2, italicFont);

				g.DrawString(qrText1, italicFont, Brushes.DimGray, startX + (width - text1Size.Width) / 2, y);
				y += 20;
				g.DrawString(qrText2, italicFont, Brushes.DimGray, startX + (width - text2Size.Width) / 2, y);
				y += 50;
			}

			// --- 7. LỜI CẢM ƠN ---
			string thanks = "Cảm ơn Quý khách và Hẹn gặp lại!";
			var thanksSize = g.MeasureString(thanks, boldFont);
			g.DrawString(thanks, boldFont, Brushes.Black, startX + (width - thanksSize.Width) / 2, y); y += 50;
		}
		private void txtPhuThu_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // chặn ký tự
			}
		}
		private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboDonDP.SelectedValue == null) return;

            int maDP = (int)cboDonDP.SelectedValue;
            Datphong? dp = db.Datphongs.Find(maDP);

            if (dp == null) return;

            //decimal phuThu = 0;
            //decimal giam = 0;
            //decimal tong = 0;

            int.TryParse(txtPhuThu.Text, out int phuThu);
            int.TryParse(lblTienGiam.Text, out int giam);
            int.TryParse(lblTongTien.Text, out int tong);

            var hd = new Hoadon
            {
                MaDp = maDP,
                MaNv = dp.MaNv,
                NgayTt = DateTime.Now,
                TongTien = tienPhong + tienDV,
                PhuThu = phuThu,
                TienGiam = tienPhong + tienDV - tong,
                ThanhTien = tong,
                MaKm = cboMaKM.SelectedValue as int?
            };

            db.Hoadons.Add(hd);

            if (dp != null)
            {
                dp.TrangThai = "Đã thanh toán";
            }
			
			var ds = (from ct in db.ChitietDps
					  join p in db.Phongs on ct.MaPhong equals p.MaPhong
					  where ct.MaDp == maDP
					  select new
					  {
						  p.MaPhong,
					  }).ToList();
			foreach (var item in ds)
			{
				Phong? p = db.Phongs.Find(item.MaPhong);
				if (p == null) continue;
				p.TrangThai = "Trống";
			}

			db.SaveChanges();
            LamMoi();

            MessageBox.Show("Thanh toán thành công!");
            LoadDonChuaThanhToan();

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(lblTongTien.Text) || lblTongTien.Text == "0")
			{
				MessageBox.Show("Vui lòng tính tổng tiền trước khi in!", "Thông báo");
				return;
			}

			try
			{
				LoadQR(); // Tải mã QR từ VietQR

				// Xóa đăng ký cũ để tránh lỗi in chồng khi bấm in nhiều lần
				printDoc.PrintPage -= printDoc_PrintPage;
				printDoc.PrintPage += printDoc_PrintPage;

				PrintPreviewDialog preview = new PrintPreviewDialog();
				preview.Document = printDoc;

				// Chỉnh kích thước cửa sổ preview to ra (80% màn hình)
				((Form)preview).WindowState = FormWindowState.Maximized;
				preview.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không thể khởi tạo máy in: " + ex.Message, "Lỗi in ấn");
			}
		}

        private void LamMoi()
        {
            txtTenNV.Clear();
            txtTenKH.Clear();
            lblTienDV.Text = "0";
            lblTienPhong.Text = "0";
            lblTienGiam.Text = "0";
            lblTongTien.Text = "0";
            txtPhuThu.Text = "0";
			giam = 0;
			khuyenmai = 0;
			cboMaKM.SelectedIndex = -1;
            dgvDichVu.DataSource = "";
            dgvPhong.DataSource = "";
        }
        private void cboDonDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDonDP.SelectedItem == null || cboDonDP.SelectedIndex == -1)
            {
                LamMoi();
                return;
            }
            
            var dp = cboDonDP.SelectedItem as Datphong;
            if (dp == null) return;

            int maDP = dp.MaDp;
			giam = 0;
            LoadThongTinChung(maDP);
            LoadPhong(maDP);
            LoadDichVu(maDP);
            TinhTien(maDP);
        }
    }
}
