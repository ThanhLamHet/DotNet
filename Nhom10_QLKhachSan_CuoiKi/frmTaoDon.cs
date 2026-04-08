using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nhom10_QLKhachSan_CuoiKi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;
using System.Linq;

namespace Nhom10_QLKhachSan_CuoiKi
{
	public partial class frmTaoDon : Form
	{
		QLKhachSanContext context = new QLKhachSanContext();
		BindingList<GioHangPhong> danhSachDatTam = new BindingList<GioHangPhong>();
		public frmTaoDon()
		{
			InitializeComponent();
		}

		private void frmTaoDon_Load(object sender, EventArgs e)
		{
			// Cài đặt giao diện tổng thể
			SetupVisualStyles();

			// Thiết lập DataGridView đẹp hơn
			StyleDataGridView(dgvDanhSachTam);

			dgvDanhSachTam.AutoGenerateColumns = true;
			dgvDanhSachTam.DataSource = danhSachDatTam;
			// Thiết lập DataGridView
			dgvDanhSachTam.AutoGenerateColumns = true;
			dgvDanhSachTam.DataSource = danhSachDatTam;
			dgvDanhSachTam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			LoadDuLieuDauVao();
			cbPhong.SelectedIndex = -1;
		}
		private void SetupVisualStyles()
		{
			// Tông màu chủ đạo
			Color primaryBlue = Color.FromArgb(30, 58, 138); // Xanh đậm
			Color lightBlue = Color.FromArgb(235, 245, 255); // Xanh nhạt nền

			this.BackColor = Color.White;
			this.Font = new Font("Segoe UI", 10); // Font hiện đại hơn Times New Roman

			// Style cho các GroupBox
			foreach (Control gb in this.Controls)
			{
				if (gb is GroupBox)
				{
					gb.ForeColor = primaryBlue;
					gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
					// Các control con bên trong GroupBox trả về Font bình thường
					foreach (Control child in gb.Controls)
					{
						child.Font = new Font("Segoe UI", 9, FontStyle.Regular);
						child.ForeColor = Color.Black;
					}
				}
			}

			// Style cho các nút bấm
			StyleButton(btnThem, Color.FromArgb(34, 197, 94), Color.White); // Màu xanh lá cho nút Thêm
			StyleButton(btnXoa, Color.FromArgb(239, 68, 68), Color.White);  // Màu đỏ cho nút Xóa
			StyleButton(btnDatPhong, primaryBlue, Color.White);             // Xanh đậm cho nút chốt đơn

			// Tổng tiền nổi bật
			lblTongTien.ForeColor = Color.FromArgb(185, 28, 28);
			lblTongTien.Font = new Font("Segoe UI", 14, FontStyle.Bold);
		}

		private void StyleButton(Button btn, Color backColor, Color foreColor)
		{
			btn.FlatStyle = FlatStyle.Flat;
			btn.BackColor = backColor;
			btn.ForeColor = foreColor;
			btn.FlatAppearance.BorderSize = 0;
			btn.Cursor = Cursors.Hand;
			btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
		}

		private void StyleDataGridView(DataGridView dgv)
		{
			// Màu sắc chủ đạo
			Color headerColor = Color.FromArgb(30, 58, 138); // Xanh Navy
			Color rowColor = Color.White;
			Color alternateRowColor = Color.FromArgb(245, 250, 255); // Xanh cực nhạt
			Color selectionColor = Color.FromArgb(191, 219, 254); // Màu khi chọn dòng

			dgv.BackgroundColor = Color.White;
			dgv.BorderStyle = BorderStyle.None;
			dgv.EnableHeadersVisualStyles = false; // Quan trọng để tùy chỉnh Header
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.MultiSelect = false;
			dgv.RowHeadersVisible = false; // Ẩn cột đầu tiên cho gọn

			// Header Style
			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
			dgv.ColumnHeadersHeight = 40;

			// Cell Style
			dgv.DefaultCellStyle.SelectionBackColor = selectionColor;
			dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
			dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
			dgv.DefaultCellStyle.BackColor = rowColor;
			dgv.AlternatingRowsDefaultCellStyle.BackColor = alternateRowColor;

			// Căn giữa nội dung
			dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dgv.GridColor = Color.FromArgb(229, 231, 235); // Màu đường kẻ mờ
		}

		private void LoadDuLieuDauVao()
		{

			cbNhanVien.DataSource = context.Nhanviens
				.AsNoTracking()
				.Where(nv => nv.TrangThai == "Đang làm việc")
				.ToList();
			cbNhanVien.DisplayMember = "HoTen";
			cbNhanVien.ValueMember = "MaNv";

			// Load Khách Hàng (Hiển thị Tên + SĐT cho dễ nhìn)
			var dsKhachHang = context.Khachhangs
				.AsNoTracking()
				.Select(kh => new
				{
					kh.MaKh,
					HienThi = kh.HoTen + " - " + kh.SoDienThoai
				}).ToList();
			cbKhachHang.DataSource = dsKhachHang;
			cbKhachHang.DisplayMember = "HienThi";
			cbKhachHang.ValueMember = "MaKh";

			// Load Phòng (Chỉ lấy phòng Trống)
			LoadDanhSachPhongTrong();
		}



		private void LoadDanhSachPhongTrong()
		{
			cbPhong.DataSource = context.Phongs
				.AsNoTracking()
				.Where(p => p.TrangThai == "Trống")
				.ToList();
			cbPhong.DisplayMember = "TenPhong";
			cbPhong.ValueMember = "MaPhong";

			// Xóa rỗng giá tiền khi mới load
			lblGiaTien.Text = "0 VND";
			lblGiaTien.Tag = 0m;
		}

		private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbPhong.SelectedValue is int maPhong)
			{
				var phong = context.Phongs
					.Include(p => p.MaLoaiNavigation)
					.AsNoTracking()
					.FirstOrDefault(p => p.MaPhong == maPhong);

				if (phong != null && phong.MaLoaiNavigation != null)
				{
					decimal giaMacDinh = phong.MaLoaiNavigation.GiaMacDinh ?? 0;
					lblGiaTien.Text = giaMacDinh.ToString("N0") + " VND";
					lblGiaTien.Tag = giaMacDinh; // Lưu giá gốc vào Tag để tính toán
				}
			}
		}


		private async void btnDatPhong_Click(object sender, EventArgs e)
		{
			if (danhSachDatTam.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn ít nhất 1 phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (var transaction = context.Database.BeginTransaction())
			{
				try
				{
					decimal tienCoc = 0;
					decimal.TryParse(txtTienCoc.Text, out tienCoc);

					// A. Tạo đối tượng DATPHONG
					Datphong donDat = new Datphong
					{
						MaKh = (int)cbKhachHang.SelectedValue,
						MaNv = (int)cbNhanVien.SelectedValue,
						NgayDat = DateTime.Now,
						TienCoc = tienCoc,
						TrangThai = "Đã đặt trước"
					};
					context.Datphongs.Add(donDat);

					// B. Tạo CHITIET_DP & Cập nhật PHONG
					decimal tongTienPhieu = 0; // Biến tính tổng tiền để gửi mail
					foreach (var item in danhSachDatTam)
					{
						ChitietDp chiTiet = new ChitietDp
						{
							MaDpNavigation = donDat,
							MaPhong = item.MaPhong,
							NgayNhanDk = item.NgayNhan,
							NgayTraDk = item.NgayTra,
							GiaThucTe = item.GiaThucTe
						};
						context.ChitietDps.Add(chiTiet);

						tongTienPhieu += item.ThanhTien; // Cộng dồn tiền phòng

						var phongDb = context.Phongs.Find(item.MaPhong);
						if (phongDb != null) phongDb.TrangThai = "Đã đặt trước";
					}

					// C. Lưu tất cả thay đổi 
					context.SaveChanges();
					transaction.Commit();

					// =========================================================
					// D. GỬI EMAIL THÔNG BÁO CHO KHÁCH HÀNG
					// =========================================================
					this.Cursor = Cursors.WaitCursor; // Đổi con trỏ chuột thành biểu tượng chờ
					try
					{
						// Lấy thông tin khách hàng từ DB để lấy Email
						var khach = context.Khachhangs.Find(donDat.MaKh);
						if (khach != null && !string.IsNullOrEmpty(khach.Email))
						{
							await GuiEmailXacNhanDatPhong(khach.Email, khach.HoTen, donDat.MaDp, tienCoc, tongTienPhieu);
							MessageBox.Show("Đặt phòng thành công và Đã gửi Email xác nhận!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Đặt phòng thành công! (Khách hàng không có Email nên không gửi thông báo)", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					catch (Exception exMail)
					{
						// Nếu lỗi mạng/lỗi mail thì báo phụ, không làm rollback đơn hàng
						MessageBox.Show("Đặt phòng thành công nhưng lỗi gửi Mail: " + exMail.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					finally
					{
						this.Cursor = Cursors.Default; // Trả lại con trỏ chuột bình thường
					}

					// =========================================================
					// E. Reset Form
					// =========================================================
					danhSachDatTam.Clear();
					txtTienCoc.Clear();
					TinhTongTien(); // Hàm tính tiền trên Form của bạn
					LoadDanhSachPhongTrong(); // Nạp lại danh sách
				}
				catch (Exception ex)
				{
					transaction.Rollback();
					MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private async Task GuiEmailXacNhanDatPhong(string emailKhach, string tenKhach, int maDP, decimal tienCoc, decimal tongTien)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Khách sạn Nhóm 10", "1822041609@dntu.edu.vn")); // Sửa lại email của bạn
			message.To.Add(new MailboxAddress(tenKhach, emailKhach));
			message.Subject = $"[KHÁCH SẠN NHÓM 10] XÁC NHẬN ĐẶT PHÒNG #{maDP} THÀNH CÔNG";

			// Tạo danh sách phòng đã đặt dưới dạng HTML
			string dsPhongHtml = "";
			foreach (var item in danhSachDatTam)
			{
				dsPhongHtml += $@"
            <tr>
                <td style='border: 1px solid #ddd; padding: 8px;'>{item.TenPhong}</td>
                <td style='border: 1px solid #ddd; padding: 8px;'>{item.NgayNhan:dd/MM/yyyy}</td>
                <td style='border: 1px solid #ddd; padding: 8px;'>{item.NgayTra:dd/MM/yyyy}</td>
                <td style='border: 1px solid #ddd; padding: 8px;'>{item.GiaThucTe:N0} VNĐ</td>
            </tr>";
			}

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.HtmlBody = $@"
        <div style='font-family: Arial, sans-serif; line-height: 1.6; color: #333; max-width: 600px; margin: auto; border: 1px solid #eee; padding: 20px;'>
            <h2 style='color: #1e3a8a; text-align: center;'>XÁC NHẬN ĐẶT PHÒNG THÀNH CÔNG</h2>
            <p>Xin chào <b>{tenKhach}</b>,</p>
            <p>Cảm ơn quý khách đã lựa chọn Khách sạn Nhóm 10. Dưới đây là thông tin chi tiết đơn đặt phòng của quý khách:</p>
            
            <ul style='list-style-type: none; padding-left: 0;'>
                <li><b>Mã đơn đặt phòng:</b> #{maDP}</li>
                <li><b>Thời gian đặt:</b> {DateTime.Now:dd/MM/yyyy HH:mm}</li>
            </ul>

            <table style='width: 100%; border-collapse: collapse; margin-top: 15px;'>
                <thead>
                    <tr style='background-color: #1e3a8a; color: white;'>
                        <th style='padding: 8px; border: 1px solid #ddd;'>Tên Phòng</th>
                        <th style='padding: 8px; border: 1px solid #ddd;'>Ngày Nhận</th>
                        <th style='padding: 8px; border: 1px solid #ddd;'>Ngày Trả</th>
                        <th style='padding: 8px; border: 1px solid #ddd;'>Giá/Ngày</th>
                    </tr>
                </thead>
                <tbody>
                    {dsPhongHtml}
                </tbody>
            </table>

            <p style='margin-top: 20px; font-size: 16px;'><b>Tổng tiền dự kiến:</b> <span style='color: #b91c1c;'>{tongTien:N0} VNĐ</span></p>
            <p style='font-size: 16px;'><b>Tiền cọc đã thu:</b> <span style='color: #15803d;'>{tienCoc:N0} VNĐ</span></p>
            
            <hr style='border: 0; border-top: 1px solid #eee; margin: 20px 0;'/>
            <p style='font-style: italic; font-size: 13px; color: #666;'>Mọi thắc mắc xin vui lòng liên hệ Hotline: 0123 456 789. Hẹn gặp lại quý khách!</p>
        </div>";

			message.Body = bodyBuilder.ToMessageBody();

			using (var client = new SmtpClient())
			{
				// Nhớ thay Email và Mật khẩu ứng dụng Gmail của bạn vào đây
				await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
				await client.AuthenticateAsync("1822041609@dntu.edu.vn", "zeiqsxkthgznxgmp");
				await client.SendAsync(message);
				await client.DisconnectAsync(true);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Validate ngày
			if (dtpNgayTra.Value.Date < dtpNgayNhan.Value.Date)
			{
				MessageBox.Show("Ngày trả dự kiến không thể nhỏ hơn ngày nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (cbPhong.SelectedValue == null) return;
			int maPhong = (int)cbPhong.SelectedValue;

			// Kiểm tra trùng trong giỏ
			if (danhSachDatTam.Any(p => p.MaPhong == maPhong))
			{
				MessageBox.Show("Phòng này đã được chọn trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Thêm vào danh sách tạm
			danhSachDatTam.Add(new GioHangPhong
			{
				MaPhong = maPhong,
				TenPhong = cbPhong.Text,
				NgayNhan = dtpNgayNhan.Value,
				NgayTra = dtpNgayTra.Value,
				GiaThucTe = Convert.ToDecimal(lblGiaTien.Tag)
			});

			TinhTongTien();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (dgvDanhSachTam.CurrentRow != null)
			{
				var item = (GioHangPhong)dgvDanhSachTam.CurrentRow.DataBoundItem;
				danhSachDatTam.Remove(item);
				TinhTongTien();
			}
		}
		private void TinhTongTien()
		{
			decimal tongTien = danhSachDatTam.Sum(x => x.ThanhTien);
			lblTongTien.Text = tongTien.ToString("N0") + " VND";
		}

	}
}
