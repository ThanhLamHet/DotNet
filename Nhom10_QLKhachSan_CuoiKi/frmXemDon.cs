using Microsoft.EntityFrameworkCore;
using Nhom10_QLKhachSan_CuoiKi.Models;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Linq;
using System.IO;
using ClosedXML.Excel;

namespace Nhom10_QLKhachSan_CuoiKi
{
	public partial class frmXemDon : Form
	{
		QLKhachSanContext context = new QLKhachSanContext();
		private Bitmap qrCodeTemp; // Biến tạm lưu QR khi in

		public frmXemDon()
		{
			InitializeComponent();
		}

		private void frmXemDon_Load(object sender, EventArgs e)
		{
			// 1. Cài đặt các thành phần UI
			SetupVisualStyles();

			// 2. Định dạng 2 cái DataGridView
			StyleDataGridView(dgvDonDatPhong);
			StyleDataGridView(dgvChiTiet);

			// Thiết lập ComboBox trạng thái
			cbTrangThai.Items.Clear();
			cbTrangThai.Items.AddRange(new string[] { "Tất cả", "Đã đặt trước", "Có khách", "Đã thanh toán", "Đã hủy" });
			cbTrangThai.SelectedIndex = 0;

			LoadDanhSachDonHang();
		}

		private void SetupVisualStyles()
		{
			Color primaryBlue = Color.FromArgb(30, 58, 138);
			this.BackColor = Color.White;
			this.Font = new Font("Segoe UI", 10);

			// Gọi hàm đệ quy để sửa lỗi không nhận diện được control bên trong GroupBox/Panel
			ApplyStyleToAllControls(this);

			// Đặt màu cho các nút bấm
			StyleButton(btnLoc, primaryBlue, Color.White);
			StyleButton(btnCapNhat, Color.FromArgb(34, 197, 94), Color.White);
			StyleButton(btnIn, Color.FromArgb(124, 58, 237), Color.White);
			StyleButton(btnHuy, Color.FromArgb(239, 68, 68), Color.White);
			StyleButton(btnLuu, Color.FromArgb(71, 85, 105), Color.White);
		}

		// Hàm này giúp duyệt tất cả control nằm sâu bên trong
		private void ApplyStyleToAllControls(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is GroupBox gb)
				{
					gb.ForeColor = Color.FromArgb(30, 58, 138);
					gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
				}
				else if (c is Label || c is ComboBox || c is TextBox)
				{
					c.Font = new Font("Segoe UI", 9, FontStyle.Regular);
				}

				if (c.HasChildren) ApplyStyleToAllControls(c); // Duyệt tiếp control con
			}
		}

		private void StyleButton(Button btn, Color backColor, Color foreColor)
		{
			btn.FlatStyle = FlatStyle.Flat;
			btn.BackColor = backColor;
			btn.ForeColor = foreColor;
			btn.FlatAppearance.BorderSize = 0;
			btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			btn.Cursor = Cursors.Hand;
			btn.Height = 35; // Độ cao tiêu chuẩn cho hiện đại
		}

		private void StyleDataGridView(DataGridView dgv)
		{
			dgv.BackgroundColor = Color.White;
			dgv.BorderStyle = BorderStyle.None;
			dgv.EnableHeadersVisualStyles = false;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.MultiSelect = false;
			dgv.RowHeadersVisible = false;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Header (Tiêu đề cột)
			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			dgv.ColumnHeadersHeight = 40;

			// Cells (Ô dữ liệu)
			dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
			dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
			dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
			dgv.RowTemplate.Height = 35;
			dgv.GridColor = Color.FromArgb(241, 245, 249);

			// Xen kẽ màu dòng
			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
		}

		private void LoadDanhSachDonHang()
		{
			string trangThaiLoc = cbTrangThai.Text;

			var query = context.Datphongs
				.Include(d => d.MaKhNavigation)
				.Include(d => d.MaNvNavigation)
				.AsNoTracking()
				.AsQueryable();

			// Chỉ lọc theo trạng thái nếu khác "Tất cả"
			if (trangThaiLoc != "Tất cả")
			{
				query = query.Where(d => d.TrangThai == trangThaiLoc);
			}

			dgvDonDatPhong.DataSource = query.Select(d => new
			{
				MaDP = d.MaDp,
				KhachHang = d.MaKhNavigation.HoTen,
				NhanVien = d.MaNvNavigation.HoTen,
				NgayDat = d.NgayDat,
				TienCoc = d.TienCoc,
				TrangThai = d.TrangThai
			}).ToList();
		}

		private void btnLoc_Click(object sender, EventArgs e)
		{
			LoadDanhSachDonHang();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if (dgvDonDatPhong.CurrentRow == null)
			{
				MessageBox.Show("Vui lòng chọn một đơn hàng từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string trangThaiMoi = cbTrangThai.Text;
			if (trangThaiMoi == "Tất cả")
			{
				MessageBox.Show("Vui lòng chọn trạng thái cụ thể để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			int maDP = (int)dgvDonDatPhong.CurrentRow.Cells["MaDP"].Value;

			try
			{
				var donHang = context.Datphongs.Find(maDP);
				if (donHang != null)
				{
					if (donHang.TrangThai == "Đã hủy")
					{
						MessageBox.Show("Đơn hàng đã hủy không thể cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else if(donHang.TrangThai == "Đã thanh toán")
					{
						MessageBox.Show("Đơn hàng đã thanh toán không thể cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}


					donHang.TrangThai = trangThaiMoi;
					context.SaveChanges();

					MessageBox.Show($"Cập nhật trạng thái đơn #{maDP} thành '{trangThaiMoi}' thành công!", "Thành công");
					LoadDanhSachDonHang();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hệ thống: " + ex.Message);
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (dgvDonDatPhong.CurrentRow == null) return;

			int maDP = (int)dgvDonDatPhong.CurrentRow.Cells["MaDP"].Value;
			var confirm = MessageBox.Show($"Bạn có chắc chắn muốn HỦY đơn hàng #{maDP}?\nCác phòng liên quan sẽ được chuyển về trạng thái 'Trống'.",
										"Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (confirm == DialogResult.Yes)
			{
				try
				{
					var donHang = context.Datphongs.Include(d => d.ChitietDps).FirstOrDefault(d => d.MaDp == maDP);
					if (donHang != null)
					{
						donHang.TrangThai = "Đã hủy";

						// Trả phòng về trạng thái Trống
						foreach (var ct in donHang.ChitietDps)
						{
							var phong = context.Phongs.Find(ct.MaPhong);
							if (phong != null) phong.TrangThai = "Trống";
						}

						context.SaveChanges();
						MessageBox.Show("Đã hủy đơn hàng thành công!", "Thông báo");
						LoadDanhSachDonHang();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi hủy đơn: " + ex.Message);
				}
			}
		}

		private void dgvDonDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				int maDP = (int)dgvDonDatPhong.Rows[e.RowIndex].Cells["MaDP"].Value;
				cbTrangThai.Text = dgvDonDatPhong.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

				var chiTiet = context.ChitietDps
					.Include(c => c.MaPhongNavigation)
					.Where(c => c.MaDp == maDP)
					.Select(c => new
					{
						Phong = c.MaPhongNavigation.TenPhong,
						c.NgayNhanDk,
						c.NgayTraDk,
						GiaThucTe = c.GiaThucTe // ĐỔI TÊN TỪ "Gia" THÀNH "GiaThucTe" Ở ĐÂY
					}).ToList();
				dgvChiTiet.DataSource = chiTiet;

				// Cập nhật lại Header hiển thị cho đẹp
				if (dgvChiTiet.Columns.Contains("GiaThucTe"))
					dgvChiTiet.Columns["GiaThucTe"].HeaderText = "Giá phòng";
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra dữ liệu trước khi cho phép lưu
			if (dgvDonDatPhong.CurrentRow == null)
			{
				MessageBox.Show("Vui lòng chọn một đơn hàng bên trên!", "Thông báo");
				return;
			}

			if (dgvChiTiet.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu chi tiết để xuất!", "Thông báo");
				return;
			}

			// 2. Chuẩn bị dữ liệu tên file
			string maDP = dgvDonDatPhong.CurrentRow.Cells["MaDP"].Value?.ToString() ?? "Unknown";
			string thoiGian = DateTime.Now.ToString("ddMMyyyy_HHmm");

			// 3. Khởi tạo SaveFileDialog (Chỉ khai báo 1 lần duy nhất ở đây)
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.FileName = $"DONPHONG#{maDP}_{thoiGian}.xlsx"; // Tự động điền tên file
				sfd.Filter = "Excel Workbook|*.xlsx";
				sfd.Title = "Lưu báo cáo chi tiết đơn hàng";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						using (var workbook = new XLWorkbook())
						{
							var worksheet = workbook.Worksheets.Add("ChiTietDonHang");

							// --- PHẦN THIẾT KẾ FILE EXCEL ---
							// Tiêu đề lớn
							worksheet.Cell("A1").Value = "THÔNG TIN CHI TIẾT ĐƠN ĐẶT PHÒNG #" + maDP;
							worksheet.Range("A1:E1").Merge().Style
								.Font.SetBold()
								.Font.SetFontSize(16)
								.Font.SetFontColor(XLColor.DarkBlue)
								.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

							// Header bảng
							string[] headers = { "STT", "Tên Phòng", "Ngày Nhận", "Ngày Trả", "Giá Thực Tế" };
							for (int i = 0; i < headers.Length; i++)
							{
								var cell = worksheet.Cell(3, i + 1);
								cell.Value = headers[i];
								cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#1E3A8A");
								cell.Style.Font.FontColor = XLColor.White;
								cell.Style.Font.Bold = true;
								cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
								cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
							}

							// Đổ dữ liệu từ lưới dgvChiTiet
							int rowIndex = 4;
							int stt = 1;
							foreach (DataGridViewRow row in dgvChiTiet.Rows)
							{
								if (row.IsNewRow) continue;

								worksheet.Cell(rowIndex, 1).Value = stt++;
								worksheet.Cell(rowIndex, 2).Value = row.Cells["Phong"].Value?.ToString() ?? "";
								worksheet.Cell(rowIndex, 3).Value = row.Cells["NgayNhanDk"].Value?.ToString() ?? "";
								worksheet.Cell(rowIndex, 4).Value = row.Cells["NgayTraDk"].Value?.ToString() ?? "";

								var giaCell = worksheet.Cell(rowIndex, 5);
								if (row.Cells["GiaThucTe"].Value != null)
									giaCell.Value = Convert.ToDouble(row.Cells["GiaThucTe"].Value);
								else
									giaCell.Value = 0;

								giaCell.Style.NumberFormat.Format = "#,##0 \"VND\"";
								worksheet.Range(rowIndex, 1, rowIndex, 5).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
								rowIndex++;
							}

							worksheet.Columns().AdjustToContents();
							workbook.SaveAs(sfd.FileName);
						}
						MessageBox.Show($"Lưu file đơn hàng #{maDP} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
					}
				}
			}
		}

		// --- PHẦN IN ẤN VÀ QR CODE ---

		private void btnIn_Click(object sender, EventArgs e)
		{
			if (dgvDonDatPhong.CurrentRow == null)
			{
				MessageBox.Show("Chọn đơn hàng để in hóa đơn!", "Thông báo");
				return;
			}

			// Thực hiện tính toán tổng tiền (Phòng + Dịch vụ) giống logic bạn đã viết
			int maDP_int = Convert.ToInt32(dgvDonDatPhong.CurrentRow.Cells["MaDP"].Value);
			double tongTien = TinhTongTienHoaDon(maDP_int);

			// Tạo nội dung QR
			string qrContent = $"HOTEL_NHOM10_HD{maDP_int}\nTong: {tongTien:N0} VND";
			qrCodeTemp = TaoMaQR(qrContent);

			PrintDocument doc = new PrintDocument();
			doc.PrintPage += Doc_PrintPage;
			PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
			ppd.ShowDialog();
		}

		private double TinhTongTienHoaDon(int maDP)
		{
			double tong = 0;
			// Tiền phòng
			var chiTietPhong = context.ChitietDps.Where(c => c.MaDp == maDP).ToList();
			foreach (var cp in chiTietPhong)
			{
				int soNgay = (int)Math.Ceiling(((cp.NgayTraDk ?? DateTime.Now) - (cp.NgayNhanDk ?? DateTime.Now)).TotalDays);
				if (soNgay <= 0) soNgay = 1;
				tong += (double)(cp.GiaThucTe ?? 0) * soNgay;
			}
			// Tiền dịch vụ
			var dsDichVu = context.SudungDvs.Include(s => s.MaCtdpNavigation)
							.Where(s => s.MaCtdpNavigation.MaDp == maDP).ToList();
			foreach (var dv in dsDichVu)
			{
				tong += (double)(dv.DonGiaThucTe ?? 0) * (dv.SoLuong ?? 0);
			}
			return tong;
		}

		private Bitmap TaoMaQR(string data)
		{
			using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
			{
				QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
				using (QRCode qrCode = new QRCode(qrCodeData))
				{
					return qrCode.GetGraphic(20);
				}
			}
		}
		private void Doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			int x = e.MarginBounds.Left;
			int y = e.MarginBounds.Top;
			int width = e.MarginBounds.Width;

			// --- KHỞI TẠO FONT CHỮ & MÀU SẮC ---
			Font fTitle = new Font("Segoe UI", 24, FontStyle.Bold);
			Font fHotelName = new Font("Segoe UI", 16, FontStyle.Bold);
			Font fNormal = new Font("Segoe UI", 11, FontStyle.Regular);
			Font fBold = new Font("Segoe UI", 11, FontStyle.Bold);
			Font fItalic = new Font("Segoe UI", 10, FontStyle.Italic);
			Font fTableHeader = new Font("Segoe UI", 11, FontStyle.Bold);
			Font fTotal = new Font("Segoe UI", 14, FontStyle.Bold);

			Brush bDarkBlue = new SolidBrush(Color.FromArgb(30, 58, 138));
			Brush bGray = new SolidBrush(Color.FromArgb(100, 116, 139));
			Brush bBlack = Brushes.Black;
			Brush bRowAlt = new SolidBrush(Color.FromArgb(241, 245, 249));

			Pen pLine = new Pen(Color.FromArgb(203, 213, 225), 1);
			Pen pDark = new Pen(Color.FromArgb(30, 58, 138), 2);

			// =========================================================
			// 1. PHẦN HEADER & THÔNG TIN CHUNG
			// =========================================================
			g.DrawString("KHÁCH SẠN NHÓM 10", fHotelName, bDarkBlue, x, y);
			g.DrawString("Địa chỉ: 123 Phố Phần Mềm, Q.Công Nghệ, TP.Code", fNormal, bGray, x, y + 30);
			g.DrawString("Điện thoại: 0123 456 789  |  Web: booking-nhom10.com", fNormal, bGray, x, y + 50);

			if (qrCodeTemp != null)
			{
				int qrSize = 90;
				g.DrawImage(qrCodeTemp, x + width - qrSize, y, qrSize, qrSize);
			}

			y += 95;
			g.DrawLine(pDark, x, y, x + width, y);
			y += 25;

			StringFormat sfCenter = new StringFormat() { Alignment = StringAlignment.Center };
			StringFormat sfRight = new StringFormat() { Alignment = StringAlignment.Far };

			g.DrawString("HÓA ĐƠN THANH TOÁN", fTitle, bDarkBlue, x + width / 2, y, sfCenter);
			y += 55;

			int maDP_int = Convert.ToInt32(dgvDonDatPhong.CurrentRow.Cells["MaDP"].Value);
			string khachHang = dgvDonDatPhong.CurrentRow.Cells["KhachHang"].Value?.ToString();
			string nhanVien = dgvDonDatPhong.CurrentRow.Cells["NhanVien"].Value?.ToString();
			DateTime dtNgayDat = Convert.ToDateTime(dgvDonDatPhong.CurrentRow.Cells["NgayDat"].Value);

			g.DrawString($"Khách hàng: {khachHang}", fBold, bBlack, x, y);
			g.DrawString($"Thu ngân: {nhanVien}", fNormal, bBlack, x, y + 25);
			g.DrawString($"Mã HĐ: #{maDP_int}", fBold, bDarkBlue, x + width, y, sfRight);
			g.DrawString($"Ngày đặt: {dtNgayDat:dd/MM/yyyy HH:mm}", fNormal, bBlack, x + width, y + 25, sfRight);
			g.DrawString($"Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}", fItalic, bGray, x + width, y + 45, sfRight);

			y += 85;

			// =========================================================
			// 2. BẢNG CHI TIẾT LƯU TRÚ (PHÒNG)
			// =========================================================
			g.DrawString("CHI TIẾT LƯU TRÚ", fBold, bDarkBlue, x, y);
			y += 25;

			int[] cols = { (int)(width * 0.4), 90, 130, width - (int)(width * 0.4) - 90 - 130 };
			string[] headers = { "Phòng", "Số ngày", "Đơn giá", "Thành tiền" };
			int currentX = x;
			int rowHeight = 35;

			g.FillRectangle(bDarkBlue, new RectangleF(x, y, width, rowHeight));
			StringFormat sfVCenter = new StringFormat() { LineAlignment = StringAlignment.Center };
			StringFormat sfRightVCenter = new StringFormat() { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

			for (int i = 0; i < headers.Length; i++)
			{
				StringFormat format = (i >= 2) ? sfRightVCenter : sfVCenter;
				RectangleF textCell = new RectangleF(currentX + 5, y, cols[i] - 10, rowHeight);
				g.DrawString(headers[i], fTableHeader, Brushes.White, textCell, format);
				currentX += cols[i];
			}
			y += rowHeight;

			double tongTien = 0; // Biến này sẽ cộng dồn cả Phòng và Dịch vụ
			bool isAltRow = false;

			foreach (DataGridViewRow row in dgvChiTiet.Rows)
			{
				if (row.IsNewRow || row.Cells["NgayNhanDk"].Value == null) continue;

				string tenPhong = row.Cells["Phong"].Value?.ToString();
				DateTime ngayNhan = Convert.ToDateTime(row.Cells["NgayNhanDk"].Value);
				DateTime ngayTra = Convert.ToDateTime(row.Cells["NgayTraDk"].Value);
				double gia = Convert.ToDouble(row.Cells["GiaThucTe"].Value ?? 0);

				int soNgay = (int)Math.Ceiling((ngayTra - ngayNhan).TotalDays);
				if (soNgay <= 0) soNgay = 1;
				double thanhTienPhong = gia * soNgay;

				// --- CẬP NHẬT: Cộng dồn tiền phòng vào tổng hóa đơn ---
				tongTien += thanhTienPhong;

				if (isAltRow) g.FillRectangle(bRowAlt, x, y, width, rowHeight);
				isAltRow = !isAltRow;

				g.DrawString(tenPhong, fNormal, bBlack, new RectangleF(x + 5, y, cols[0] - 10, rowHeight), sfVCenter);
				g.DrawString(soNgay.ToString(), fNormal, bBlack, new RectangleF(x + cols[0] + 5, y, cols[1] - 10, rowHeight), sfVCenter);
				g.DrawString(gia.ToString("N0"), fNormal, bBlack, new RectangleF(x + cols[0] + cols[1] + 5, y, cols[2] - 10, rowHeight), sfRightVCenter);
				g.DrawString(thanhTienPhong.ToString("N0"), fNormal, bBlack, new RectangleF(x + cols[0] + cols[1] + cols[2] + 5, y, cols[3] - 10, rowHeight), sfRightVCenter);

				g.DrawLine(pLine, x, y + rowHeight, x + width, y + rowHeight);
				y += rowHeight;
			}

			// =========================================================
			// 3. BẢNG CHI TIẾT DỊCH VỤ SỬ DỤNG
			// =========================================================
			var dsDV = context.SudungDvs
				.Include(sd => sd.MaCtdpNavigation).ThenInclude(ct => ct.MaPhongNavigation)
				.Include(sd => sd.MaDvNavigation)
				.Where(sd => sd.MaCtdpNavigation.MaDp == maDP_int)
				.Select(sd => new
				{
					TenPhong = sd.MaCtdpNavigation.MaPhongNavigation.TenPhong,
					TenDV = sd.MaDvNavigation.TenDv,
					SoLuong = sd.SoLuong ?? 0,
					DonGia = Convert.ToDouble(sd.DonGiaThucTe ?? 0),
					ThanhTien = (sd.SoLuong ?? 0) * Convert.ToDouble(sd.DonGiaThucTe ?? 0)
				}).ToList();

			if (dsDV.Any())
			{
				y += 30;
				g.DrawString("CHI TIẾT DỊCH VỤ", fBold, bDarkBlue, x, y);
				y += 25;

				g.FillRectangle(bDarkBlue, new RectangleF(x, y, width, rowHeight));
				string[] dvHeaders = { "Tên Dịch vụ", "Phòng", "SL x Đơn giá", "Thành tiền" };
				int currentX_DV = x;

				for (int i = 0; i < dvHeaders.Length; i++)
				{
					StringFormat format = (i >= 2) ? sfRightVCenter : sfVCenter;
					RectangleF textCell = new RectangleF(currentX_DV + 5, y, cols[i] - 10, rowHeight);
					g.DrawString(dvHeaders[i], fTableHeader, Brushes.White, textCell, format);
					currentX_DV += cols[i];
				}
				y += rowHeight;

				isAltRow = false;
				foreach (var dv in dsDV)
				{
					// --- CẬP NHẬT: Cộng dồn tiền dịch vụ vào tổng hóa đơn ---
					tongTien += dv.ThanhTien;

					if (isAltRow) g.FillRectangle(bRowAlt, x, y, width, rowHeight);
					isAltRow = !isAltRow;

					string slGia = $"{dv.SoLuong} x {dv.DonGia:N0}";

					g.DrawString(dv.TenDV, fNormal, bBlack, new RectangleF(x + 5, y, cols[0] - 10, rowHeight), sfVCenter);
					g.DrawString(dv.TenPhong, fNormal, bBlack, new RectangleF(x + cols[0] + 5, y, cols[1] - 10, rowHeight), sfVCenter);
					g.DrawString(slGia, fNormal, bBlack, new RectangleF(x + cols[0] + cols[1] + 5, y, cols[2] - 10, rowHeight), sfRightVCenter);
					g.DrawString(dv.ThanhTien.ToString("N0"), fNormal, bBlack, new RectangleF(x + cols[0] + cols[1] + cols[2] + 5, y, cols[3] - 10, rowHeight), sfRightVCenter);

					g.DrawLine(pLine, x, y + rowHeight, x + width, y + rowHeight);
					y += rowHeight;
				}
			}

			y += 30;

			// =========================================================
			// 4. PHẦN TỔNG KẾT & THANH TOÁN
			// =========================================================
			double tienCoc = 0;
			if (dgvDonDatPhong.CurrentRow.Cells["TienCoc"].Value != null)
			{
				tienCoc = Convert.ToDouble(dgvDonDatPhong.CurrentRow.Cells["TienCoc"].Value);
			}

			// Con lại = (Tổng phòng + Tổng DV) - Tiền cọc
			double conLai = tongTien - tienCoc;
			if (conLai < 0) conLai = 0;

			int sumLabelsX = x + width - 350;
			int sumValuesX = x + width;

			g.DrawString("Tổng tiền (Phòng + DV):", fNormal, bGray, sumLabelsX, y);
			g.DrawString(tongTien.ToString("N0") + " VNĐ", fNormal, bBlack, sumValuesX, y, sfRight);
			y += 25;

			g.DrawString("Tiền cọc (Đã thanh toán):", fNormal, bGray, sumLabelsX, y);
			g.DrawString("- " + tienCoc.ToString("N0") + " VNĐ", fNormal, bBlack, sumValuesX, y, sfRight);
			y += 25;

			g.DrawLine(pDark, sumLabelsX, y, sumValuesX, y);
			y += 15;

			g.DrawString("CẦN THANH TOÁN:", fTotal, bDarkBlue, sumLabelsX, y);
			g.DrawString(conLai.ToString("N0") + " VNĐ", fTotal, new SolidBrush(Color.DarkRed), sumValuesX, y, sfRight);

			// =========================================================
			// 5. CHỮ KÝ
			// =========================================================
			y += 80;
			g.DrawString("Khách hàng", fBold, bBlack, x + 60, y);
			g.DrawString("Nhân viên thu ngân", fBold, bBlack, x + width - 220, y);

			y += 20;
			g.DrawString("(Ký & ghi rõ họ tên)", fItalic, bGray, x + 40, y);
			g.DrawString("(Ký & ghi rõ họ tên)", fItalic, bGray, x + width - 215, y);

			y += 130;
			g.DrawLine(pLine, x, y, x + width, y);
			y += 15;
			g.DrawString("Cảm ơn quý khách đã tin tưởng và sử dụng dịch vụ của chúng tôi. Hẹn gặp lại!", fItalic, bDarkBlue, x + width / 2, y, sfCenter);
		}

		private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

