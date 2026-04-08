using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Nhom10_QLKhachSan_CuoiKi.Models;

namespace Nhom10_QLKhachSan_CuoiKi
{
    public partial class frmBaoCao : Form
    {
        private readonly QLKhachSanContext db = new QLKhachSanContext();

        public frmBaoCao()
        {
            InitializeComponent();

            // Tự động gán sự kiện
            this.Load += FrmBaoCao_Load;
            btnThongKe.Click += BtnThongKe_Click;
            btnXuatExcel.Click += BtnXuatExcel_Click;
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            CauHinhGiaoDien();

            // UX: Mặc định chọn mốc từ đầu tháng đến ngày hiện tại
            DateTime today = DateTime.Now;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = today;

            LoadData();
        }

        // --- 1. TỐI ƯU GIAO DIỆN BẢNG DỮ LIỆU ---
        private void CauHinhGiaoDien()
        {
            dgvBaoCao.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgvBaoCao.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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

        // --- 2. LẤY DỮ LIỆU CHUẨN XÁC VÀ VẼ BIỂU ĐỒ ---
        private void LoadData()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

                // Truy vấn CSDL chuẩn theo Database (NgayTt, ThanhTien)
                var query = db.Hoadons.AsNoTracking()
                              .Include(hd => hd.MaDpNavigation)
                                .ThenInclude(dp => dp.MaKhNavigation)
                              .Include(hd => hd.MaNvNavigation)
                              .Where(hd => hd.NgayTt >= tuNgay && hd.NgayTt <= denNgay);

                // Lấy dữ liệu ra danh sách bộ nhớ (Grid)
                var data = query.Select(hd => new
                {
                    MaHd = hd.MaHd,
                    KhachHang = (hd.MaDpNavigation != null && hd.MaDpNavigation.MaKhNavigation != null)
                                ? hd.MaDpNavigation.MaKhNavigation.HoTen
                                : "Khách lẻ",
                    NhanVien = hd.MaNvNavigation != null ? hd.MaNvNavigation.HoTen : "Không rõ",
                    NgayTt = hd.NgayTt,
                    ThanhTien = hd.ThanhTien
                }).OrderByDescending(x => x.NgayTt).ToList();

                dgvBaoCao.DataSource = data;

                // Tối ưu các Cột và Format Tiền Tệ
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

                // Cập nhật Nhãn Tổng Kết
                decimal tongDoanhThu = data.Sum(x => x.ThanhTien) ?? 0;
                lblSoDon.Text = $"Tổng số hóa đơn: {data.Count}";
                lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tongDoanhThu:N0} VNĐ";

                // === VẼ BIỂU ĐỒ ===
                var chartData = query.ToList()
                                     .Where(hd => hd.NgayTt.HasValue)
                                     .GroupBy(hd => hd.NgayTt.Value.Date)
                                     .Select(g => new
                                     {
                                         Ngay = g.Key,
                                         DoanhThuTrongNgay = g.Sum(hd => hd.ThanhTien ?? 0)
                                     })
                                     .OrderBy(x => x.Ngay)
                                     .ToList();

                chartDoanhThu.Series.Clear();
                chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày";
                chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
                chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

                var series = chartDoanhThu.Series.Add("DoanhThu");
                series.LegendText = "Doanh Thu";
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "N0";
                series.Color = Color.FromArgb(41, 128, 185);

                foreach (var item in chartData)
                {
                    series.Points.AddXY(item.Ngay.ToString("dd/MM"), item.DoanhThuTrongNgay);
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

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Excel (*.csv)|*.csv", FileName = "BaoCaoDoanhThu_" + DateTime.Now.ToString("ddMMyyyy") + ".csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                        {
                            // 1. Tiêu đề
                            for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                            {
                                sw.Write(dgvBaoCao.Columns[i].HeaderText);
                                if (i < dgvBaoCao.Columns.Count - 1) sw.Write(",");
                            }
                            sw.WriteLine();

                            // 2. Dữ liệu
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
                        MessageBox.Show("Không thể lưu file! Hãy đảm bảo file đang không bị mở bởi Excel.", "Lỗi Lưu File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void chartDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}