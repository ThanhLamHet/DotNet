using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class Hoadon
{
    public int MaHd { get; set; }

    public int? MaDp { get; set; }

    public int? MaNv { get; set; }

    public int? MaKm { get; set; }

    public DateTime? NgayTt { get; set; }

    public decimal? TongTien { get; set; }

    public decimal? TienGiam { get; set; }

    public decimal? PhuThu { get; set; }

    public decimal? ThanhTien { get; set; }

    public virtual Datphong? MaDpNavigation { get; set; }

    public virtual Khuyenmai? MaKmNavigation { get; set; }

    public virtual Nhanvien? MaNvNavigation { get; set; }
}
