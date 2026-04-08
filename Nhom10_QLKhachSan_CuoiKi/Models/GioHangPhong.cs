using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Nhom10_QLKhachSan_CuoiKi.Models
{
	public class GioHangPhong
	{
		// Thuộc tính DisplayName sẽ tự động biến thành Tiêu đề cột (Header) khi nạp vào DataGridView
		[DisplayName("Mã Phòng")]
		public int MaPhong { get; set; }

		[DisplayName("Tên Phòng")]
		public string TenPhong { get; set; }

		[DisplayName("Ngày Nhận")]
		public DateTime NgayNhan { get; set; }

		[DisplayName("Ngày Trả")]
		public DateTime NgayTra { get; set; }

		[DisplayName("Giá Thực Tế (VND)")]
		public decimal GiaThucTe { get; set; }

		[DisplayName("Thành Tiền (VND)")]
		public decimal ThanhTien
		{
			get
			{
				// Công thức tính số ngày: (Ngày Trả - Ngày Nhận) làm tròn lên
				int soNgay = (int)Math.Ceiling((NgayTra - NgayNhan).TotalDays);

				// Nếu khách đặt và trả trong cùng 1 ngày (hoặc nhập sai giờ) thì mặc định tính 1 ngày
				if (soNgay <= 0)
				{
					soNgay = 1;
				}

				return soNgay * GiaThucTe;
			}
		}
	}
}
