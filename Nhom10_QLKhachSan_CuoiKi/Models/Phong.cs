using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class Phong
{
    public int MaPhong { get; set; }

    public int? MaLoai { get; set; }

    public string TenPhong { get; set; } = null!;

    public string? TrangThai { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<ChitietDp> ChitietDps { get; set; } = new List<ChitietDp>();

    public virtual Loaiphong? MaLoaiNavigation { get; set; }
}
