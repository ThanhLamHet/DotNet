using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class Nhanvien
{
    public int MaNv { get; set; }

    public string HoTen { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public string? HinhAnh { get; set; }

    public string? ChucVu { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<Datphong> Datphongs { get; set; } = new List<Datphong>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
