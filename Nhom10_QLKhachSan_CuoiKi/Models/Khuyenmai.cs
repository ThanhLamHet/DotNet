using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class Khuyenmai
{
    public int MaKm { get; set; }

    public string TenKm { get; set; } = null!;

    public decimal? PhanTramGiam { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
