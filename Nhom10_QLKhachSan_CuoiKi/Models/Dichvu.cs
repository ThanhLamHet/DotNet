using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class Dichvu
{
    public int MaDv { get; set; }

    public string TenDv { get; set; } = null!;

    public decimal? GiaDv { get; set; }

    public string? DonViTinh { get; set; }

    public virtual ICollection<SudungDv> SudungDvs { get; set; } = new List<SudungDv>();
}
