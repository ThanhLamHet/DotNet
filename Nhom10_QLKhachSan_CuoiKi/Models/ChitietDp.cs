using System;
using System.Collections.Generic;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class ChitietDp
{
    public int MaCtdp { get; set; }

    public int? MaDp { get; set; }

    public int? MaPhong { get; set; }

    public DateTime? NgayNhanDk { get; set; }

    public DateTime? NgayTraDk { get; set; }

    public decimal? GiaThucTe { get; set; }

    public virtual Datphong? MaDpNavigation { get; set; }

    public virtual Phong? MaPhongNavigation { get; set; }

    public virtual ICollection<SudungDv> SudungDvs { get; set; } = new List<SudungDv>();
}
