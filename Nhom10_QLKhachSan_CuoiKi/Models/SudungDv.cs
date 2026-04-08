using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class SudungDv
{
    public int MaSd { get; set; }

    public int? MaCtdp { get; set; }

    public int? MaDv { get; set; }

    public int? SoLuong { get; set; }

    public decimal? DonGiaThucTe { get; set; }

    public DateTime? ThoiGianGoi { get; set; }

    public virtual ChitietDp? MaCtdpNavigation { get; set; }

    public virtual Dichvu? MaDvNavigation { get; set; }
}
