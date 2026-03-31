using Lab9_QuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab9_QuanLyThuVien
{
	public partial class frmBaoCao : Form
	{
		private QLThuVienContext _db = new QLThuVienContext();
		public frmBaoCao()
		{
			InitializeComponent();
		}

		private void frmBaoCao_Load(object sender, EventArgs e)
		{
			// Nạp danh sách các loại báo cáo vào ComboBox
			cbLoaiBaoCao.Items.Add("Sách đang được mượn");
			cbLoaiBaoCao.Items.Add("Độc giả còn nợ tiền");
			cbLoaiBaoCao.Items.Add("Thống kê sách mượn nhiều nhất (Top 10)");
			cbLoaiBaoCao.Items.Add("Độc giả sắp hết hạn thẻ (30 ngày)");
			cbLoaiBaoCao.SelectedIndex = 0;
		}

		private void btnThongKe_Click(object sender, EventArgs e)
		{
			int index = cbLoaiBaoCao.SelectedIndex;

			switch (index)
			{
				case 0: BaoCaoSachDangMuon(); break;
				case 1: BaoCaoDocGiaNo(); break;
				case 2: ThongKeTop10Sach(); break;
				case 3: BaoCaoHetHanThe(); break;
			}
		}
		private void BaoCaoSachDangMuon()
		{
			var data = _db.Phieumuonsaches
		.SelectMany(p => p.MaSaches, (p, s) => new
		{
			TenSach = s.TenSach,
			TacGia = s.TacGia,
			TenDocGia = p.MaDocGiaNavigation.HoTenDocGia,
			NgayMuon = p.NgayMuon
		})
		.OrderByDescending(x => x.NgayMuon)
		.ToList();

			dgvBaoCao.DataSource = data;
		}

		// 2. Độc giả còn nợ tiền (TienNo > 0)
		private void BaoCaoDocGiaNo()
		{
			var data = _db.Docgia
		.Where(d => d.TienNo > 0)
		.OrderByDescending(d => d.TienNo)
		.Select(d => new
		{
			d.HoTenDocGia,
			d.Email, // Bảng DOCGIA không có số điện thoại, dùng Email
			NgayHetHan = d.NgayHetHan.HasValue ? d.NgayHetHan.Value.ToString("dd/MM/yyyy") : "",
			TienNo = d.TienNo.ToString("N0") + " VNĐ"
		})
		.ToList();

			dgvBaoCao.DataSource = data;
		}

		// 3. Thống kê sách mượn nhiều nhất (Top 10)
		private void ThongKeTop10Sach()
		{
			var data = _db.Saches
		.Select(s => new
		{
			TenSach = s.TenSach,
			SoLanMuon = s.MaPhieuMuons.Count()
		})
		.OrderByDescending(x => x.SoLanMuon)
		.Take(10)
		.ToList();

			dgvBaoCao.DataSource = data;
		}

		// 4. Độc giả hết hạn thẻ trong 30 ngày
		private void BaoCaoHetHanThe()
		{
			DateTime today = DateTime.Now;
			DateTime next30Days = today.AddDays(30);

			var data = _db.Docgia
				.Where(d => d.NgayHetHan >= today && d.NgayHetHan <= next30Days)
				.Select(d => new
				{
					d.HoTenDocGia,
					NgayHetHan = d.NgayHetHan.HasValue ? d.NgayHetHan.Value.ToString("dd/MM/yyyy") : "",
					d.Email
				})
				.ToList();

			dgvBaoCao.DataSource = data;
		}
	}
}

