using System;
using System.Collections.Generic;

namespace Lab9_QuanLyThuVien.Models;

public partial class Sach
{
    public int MaSach { get; set; }

    public string? TenSach { get; set; }

    public string? TacGia { get; set; }

    public int? NamXuatBan { get; set; }

    public string? NhaXuatBan { get; set; }

    public double? TriGia { get; set; }

    public DateTime? NgayNhap { get; set; }

    public virtual ICollection<Phieumuonsach> MaPhieuMuons { get; set; } = new List<Phieumuonsach>();
}
