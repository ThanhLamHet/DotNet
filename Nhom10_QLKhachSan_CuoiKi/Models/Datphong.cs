using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class Datphong
{
    public int MaDp { get; set; }

    public int? MaKh { get; set; }

    public int? MaNv { get; set; }

    public DateTime? NgayDat { get; set; }

    public decimal? TienCoc { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<ChitietDp> ChitietDps { get; set; } = new List<ChitietDp>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual Khachhang? MaKhNavigation { get; set; }

    public virtual Nhanvien? MaNvNavigation { get; set; }
}
