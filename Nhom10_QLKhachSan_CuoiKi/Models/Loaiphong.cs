using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class Loaiphong
{
    public int MaLoai { get; set; }

    public string TenLoai { get; set; } = null!;

    public int? SoNguoiToiDa { get; set; }

    public decimal? GiaMacDinh { get; set; }

    public virtual ICollection<Phong> Phongs { get; set; } = new List<Phong>();
}
