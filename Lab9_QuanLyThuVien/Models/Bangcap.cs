using System;
using System.Collections.Generic;

namespace Lab9_QuanLyThuVien.Models;

public partial class Bangcap
{
    public int MaBangCap { get; set; }

    public string? TenBangCap { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
