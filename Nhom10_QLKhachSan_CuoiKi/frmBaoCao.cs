using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Nhom10_QLKhachSan_CuoiKi.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Nhom10_QLKhachSan_CuoiKi
{
	public partial class frmBaoCao : Form
	{
		private readonly QLKhachSanContext db = new QLKhachSanContext();

		public frmBaoCao()
		{
			InitializeComponent();


			this.Load += FrmBaoCao_Load;
			btnThongKe.Click += BtnThongKe_Click;
			btnXuatExcel.Click += BtnXuatExcel_Click;
			btnInPDF.Click += BtnInPDF_Click;
			cboLoaiBaoCao.SelectedIndexChanged += BtnThongKe_Click;
			cboNhanVien.SelectedIndexChanged += cboNhanVien_SelectedIndexChanged;
		}

		private void FrmBaoCao_Load(object sender, EventArgs e)
		{
			CauHinhGiaoDien();


			cboLoaiBaoCao.Items.Add("Doanh thu Hóa đơn");
			cboLoaiBaoCao.Items.Add("Mật độ sử dụng Phòng");
			cboLoaiBaoCao.Items.Add("Thống kê Dịch vụ");

			// Load danh sách nhân viên
			LoadDanhSachNhanVien();

			cboLoaiBaoCao.SelectedIndex = 0;


			DateTime today = DateTime.Now;
			dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
			dtpDenNgay.Value = today;
		}

		private void LoadDanhSachNhanVien()
		{
			try
			{
				var dsNhanVien = db.Nhanviens.AsNoTracking().Select(nv => nv.HoTen).ToList();
				dsNhanVien.Insert(0, "--- Tất cả nhân viên ---");
				cboNhanVien.DataSource = dsNhanVien;
				cboNhanVien.SelectedIndex = 0;
			}
			catch { }
		}


		private void CauHinhGiaoDien()
		{
			dgvBaoCao.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
			dgvBaoCao.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f);
			dgvBaoCao.EnableHeadersVisualStyles = false;
			dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
			dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgvBaoCao.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
			dgvBaoCao.ColumnHeadersHeight = 40;
			dgvBaoCao.RowTemplate.Height = 35;
			dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvBaoCao.AllowUserToAddRows = false;
			dgvBaoCao.ReadOnly = true;
			dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void BtnThongKe_Click(object sender, EventArgs e)
		{
			if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
			{
				MessageBox.Show("Khoảng thời gian không hợp lệ. Từ ngày không được lớn hơn Đến ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			LoadData();
		}

		private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadData(); // Tự động load lại khi đổi tên nhân viên
		}

		// --- 2. LẤY DỮ LIỆU CHUẨN XÁC VÀ VẼ BIỂU ĐỒ ---
		private void LoadData()
		{
			try
			{
				DateTime tuNgay = dtpTuNgay.Value.Date;
				DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);
				int loaiBaoCao = cboLoaiBaoCao.SelectedIndex;

				chartDoanhThu.Series.Clear(); // Xóa biểu đồ cũ
				chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

				if (loaiBaoCao == 0) // DOANH THU HÓA ĐƠN
				{
					var query = db.Hoadons.AsNoTracking()
								  .Include(hd => hd.MaDpNavigation).ThenInclude(dp => dp.MaKhNavigation)
								  .Include(hd => hd.MaNvNavigation)
								  .Where(hd => hd.NgayTt >= tuNgay && hd.NgayTt <= denNgay);

					// Lọc theo nhân viên
					if (cboNhanVien.SelectedIndex > 0)
					{
						string tenNV = cboNhanVien.Text;
						query = query.Where(hd => hd.MaNvNavigation.HoTen == tenNV);
					}

					var data = query.Select(hd => new
					{
						MaHd = hd.MaHd,
						KhachHang = (hd.MaDpNavigation != null && hd.MaDpNavigation.MaKhNavigation != null)
									? hd.MaDpNavigation.MaKhNavigation.HoTen : "Khách lẻ",
						NhanVien = hd.MaNvNavigation != null ? hd.MaNvNavigation.HoTen : "Không rõ",
						NgayTt = hd.NgayTt,
						ThanhTien = hd.ThanhTien
					}).OrderByDescending(x => x.NgayTt).ToList();

					dgvBaoCao.DataSource = data;

					if (dgvBaoCao.Columns.Count > 0)
					{
						dgvBaoCao.Columns["MaHd"].HeaderText = "Mã Hóa Đơn";
						dgvBaoCao.Columns["KhachHang"].HeaderText = "Tên Khách Hàng";
						dgvBaoCao.Columns["NhanVien"].HeaderText = "Nhân Viên Thu";
						dgvBaoCao.Columns["NgayTt"].HeaderText = "Ngày Thanh Toán";
						dgvBaoCao.Columns["NgayTt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
						dgvBaoCao.Columns["ThanhTien"].HeaderText = "Thành Tiền (VNĐ)";
						dgvBaoCao.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
						dgvBaoCao.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					}

					decimal tongDoanhThu = data.Sum(x => x.ThanhTien) ?? 0;
					lblSoDon.Text = $"Tổng số hóa đơn: {data.Count}";
					lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tongDoanhThu:N0} VNĐ";

					// Vẽ biểu đồ
					var chartData = query.ToList().Where(hd => hd.NgayTt.HasValue)
										 .GroupBy(hd => hd.NgayTt.Value.Date)
										 .Select(g => new { Ngay = g.Key, DoanhThu = g.Sum(hd => hd.ThanhTien ?? 0) })
										 .OrderBy(x => x.Ngay).ToList();

					chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày";
					var series = chartDoanhThu.Series.Add("DoanhThu");
					series.LegendText = "Doanh Thu Hóa Đơn";
					series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
					series.IsValueShownAsLabel = true; series.LabelFormat = "N0";
					foreach (var item in chartData) series.Points.AddXY(item.Ngay.ToString("dd/MM"), item.DoanhThu);
				}
				else if (loaiBaoCao == 1) // MẬT ĐỘ SỬ DỤNG PHÒNG
				{
					var query = db.ChitietDps.AsNoTracking()
								  .Include(ct => ct.MaPhongNavigation)
								  .Where(ct => ct.NgayNhanDk >= tuNgay && ct.NgayNhanDk <= denNgay)
								  .GroupBy(ct => ct.MaPhongNavigation.TenPhong)
								  .Select(g => new
								  {
									  TenPhong = g.Key ?? "Phòng xóa",
									  SoLanThue = g.Count(),
									  DoanhThuUocTinh = g.Sum(ct => ct.GiaThucTe) ?? 0
								  }).OrderByDescending(x => x.SoLanThue).ToList();

					dgvBaoCao.DataSource = query;

					if (dgvBaoCao.Columns.Count > 0)
					{
						dgvBaoCao.Columns["TenPhong"].HeaderText = "Tên Phòng";
						dgvBaoCao.Columns["SoLanThue"].HeaderText = "Số Lần Thuê";
						dgvBaoCao.Columns["DoanhThuUocTinh"].HeaderText = "Doanh Thu Ước Tính (VNĐ)";
						dgvBaoCao.Columns["DoanhThuUocTinh"].DefaultCellStyle.Format = "N0";
					}

					lblSoDon.Text = $"Tổng số phòng có khách: {query.Count} phòng";
					decimal tongTien = query.Sum(x => x.DoanhThuUocTinh);
					lblTongDoanhThu.Text = $"TỔNG TIỀN PHÒNG: {tongTien:N0} VNĐ";

					// Vẽ biểu đồ
					chartDoanhThu.ChartAreas[0].AxisX.Title = "Tên Phòng";
					var series = chartDoanhThu.Series.Add("Phong");
					series.LegendText = "Số lần thuê phòng";
					series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
					series.IsValueShownAsLabel = true;
					series.Color = Color.FromArgb(46, 204, 113);
					foreach (var item in query) series.Points.AddXY(item.TenPhong, item.SoLanThue);
				}
				else if (loaiBaoCao == 2) // THỐNG KÊ DỊCH VỤ
				{
					var query = db.SudungDvs.AsNoTracking()
								  .Include(sd => sd.MaDvNavigation)
								  .Where(sd => sd.ThoiGianGoi >= tuNgay && sd.ThoiGianGoi <= denNgay)
								  .GroupBy(sd => sd.MaDvNavigation.TenDv)
								  .Select(g => new
								  {
									  TenDichVu = g.Key ?? "Dịch vụ xóa",
									  SoLuongBan = g.Sum(sd => sd.SoLuong) ?? 0,
									  DoanhThu = g.Sum(sd => (sd.SoLuong ?? 0) * (sd.DonGiaThucTe ?? 0))
								  }).OrderByDescending(x => x.SoLuongBan).ToList();

					dgvBaoCao.DataSource = query;

					if (dgvBaoCao.Columns.Count > 0)
					{
						dgvBaoCao.Columns["TenDichVu"].HeaderText = "Tên Dịch Vụ";
						dgvBaoCao.Columns["SoLuongBan"].HeaderText = "Tổng Số Lượng Đã Bán";
						dgvBaoCao.Columns["DoanhThu"].HeaderText = "Tổng Thu (VNĐ)";
						dgvBaoCao.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
					}

					lblSoDon.Text = $"Các loại dịch vụ đã bán: {query.Count} loại";
					decimal tongTien = query.Sum(x => x.DoanhThu);
					lblTongDoanhThu.Text = $"TỔNG TIỀN DỊCH VỤ: {tongTien:N0} VNĐ";

					// Vẽ biểu đồ
					chartDoanhThu.ChartAreas[0].AxisX.Title = "Tên Dịch Vụ";
					var series = chartDoanhThu.Series.Add("DichVu");
					series.LegendText = "Số lượng đã bán";
					series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
					series.IsValueShownAsLabel = true;
					series.Color = Color.FromArgb(155, 89, 182);
					foreach (var item in query) series.Points.AddXY(item.TenDichVu, item.SoLuongBan);
				}


				// --- TÍNH CÔNG SUẤT PHÒNG ---
				int tongPhong = db.Phongs.Count();

				// Đếm số phòng có trạng thái "Có khách" trực tiếp từ database
				int dangThue = db.Phongs.Count(p => p.TrangThai == "Có khách");

				int congSuat = tongPhong > 0 ? (dangThue * 100 / tongPhong) : 0;

				if (lblCongSuat != null)
				{
					lblCongSuat.Text = $"Công suất phòng hiện tại: {congSuat}%";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// --- 3. XUẤT FILE EXCEL CSV ---
		private void BtnXuatExcel_Click(object sender, EventArgs e)
		{
			if (dgvBaoCao.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Excel (*.csv)|*.csv", FileName = "BaoCao_" + cboLoaiBaoCao.Text + "_" + DateTime.Now.ToString("ddMMyyyy") + ".csv" })
			{
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
						{
							for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
							{
								sw.Write(dgvBaoCao.Columns[i].HeaderText);
								if (i < dgvBaoCao.Columns.Count - 1) sw.Write(",");
							}
							sw.WriteLine();

							foreach (DataGridViewRow row in dgvBaoCao.Rows)
							{
								for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
								{
									string cellValue = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
									if (cellValue.Contains(",") || cellValue.Contains("\"") || cellValue.Contains("\n"))
									{
										cellValue = $"\"{cellValue.Replace("\"", "\"\"")}\"";
									}
									sw.Write(cellValue);
									if (i < dgvBaoCao.Columns.Count - 1) sw.Write(",");
								}
								sw.WriteLine();
							}
						}
						MessageBox.Show("Xuất file báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (IOException)
					{
						MessageBox.Show("Không thể lưu file! Hãy đảm bảo file đang không bị mở bởi Excel.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		// --- 4. IN BÁO CÁO PDF ---
		private void BtnInPDF_Click(object sender, EventArgs e)
		{
			if (dgvBaoCao.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu để in báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = $"BaoCao_{cboLoaiBaoCao.Text}_{DateTime.Now:yyyyMMdd_HHmm}.pdf" };
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 0f);
					PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
					pdfDoc.Open();

					BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
					iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
					iTextSharp.text.Font fontText = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
					iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);

					Paragraph title = new Paragraph($"BÁO CÁO: {cboLoaiBaoCao.Text.ToUpper()}", fontTitle);
					title.Alignment = Element.ALIGN_CENTER;
					pdfDoc.Add(title);

					Paragraph time = new Paragraph($"Thời gian: Từ {dtpTuNgay.Value:dd/MM/yyyy} đến {dtpDenNgay.Value:dd/MM/yyyy}\n\n", fontText);
					time.Alignment = Element.ALIGN_CENTER;
					pdfDoc.Add(time);

					PdfPTable table = new PdfPTable(dgvBaoCao.Columns.Count);
					table.WidthPercentage = 100;

					foreach (DataGridViewColumn col in dgvBaoCao.Columns)
					{
						PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, fontHeader));
						cell.BackgroundColor = new BaseColor(41, 128, 185);
						cell.HorizontalAlignment = Element.ALIGN_CENTER;
						cell.Padding = 5;
						table.AddCell(cell);
					}

					foreach (DataGridViewRow row in dgvBaoCao.Rows)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", fontText));
							pdfCell.Padding = 5;
							table.AddCell(pdfCell);
						}
					}

					pdfDoc.Add(table);

					// --- PHẦN HOÀN THIỆN ĐOẠN ĐANG DỞ ---
					Paragraph summary = new Paragraph($"\n{lblSoDon.Text}\n{lblTongDoanhThu.Text}", fontHeader);
					summary.Alignment = Element.ALIGN_RIGHT;
					pdfDoc.Add(summary);

					pdfDoc.Close();

					MessageBox.Show("Xuất file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void panelTop_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}