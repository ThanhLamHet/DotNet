using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class Khachhang
{
    public int MaKh { get; set; }

    public string HoTen { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public string? Cccd { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Datphong> Datphongs { get; set; } = new List<Datphong>();
}
