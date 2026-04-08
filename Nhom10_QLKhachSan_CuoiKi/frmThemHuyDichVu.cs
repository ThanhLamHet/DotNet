using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nhom10_QLKhachSan_CuoiKi.Models;
using Microsoft.EntityFrameworkCore;


namespace Nhom10_QLKhachSan_CuoiKi;

public partial class frmThemHuyDichVu : Form
{
	private QLKhachSanContext db = new QLKhachSanContext();
	private Random rnd = new Random();
	public frmThemHuyDichVu()
	{
		InitializeComponent();
	}
	private void frmThemHuyDichVu_Load(object sender, EventArgs e)
	{
		ApplyModernUI();
		LoadCTDP();
		LoadDichVuCombo();
		LoadDSDichVu();
	}
	private void ApplyModernUI()
	{
		// Tông màu chủ đạo
		this.BackColor = Color.White;
		this.Font = new Font("Segoe UI", 10);

		// Style cho các nút bấm
		if (this.Controls.Find("btnThem", true).FirstOrDefault() is Button btnThem)
			StyleButton(btnThem, Color.FromArgb(34, 197, 94), Color.White);  // Xanh lá

		if (this.Controls.Find("btnHuy", true).FirstOrDefault() is Button btnHuy)
			StyleButton(btnHuy, Color.FromArgb(239, 68, 68), Color.White);   // Đỏ

		if (this.Controls.Find("btnLamMoi", true).FirstOrDefault() is Button btnLamMoi)
			StyleButton(btnLamMoi, Color.FromArgb(71, 85, 105), Color.White); // Xám đá

		// Chỉnh các ô nhập liệu
		SetupVisualStyles(this);

		// Định dạng bảng dữ liệu
		StyleDataGridView(dgvDSDichVu);
	}

	private void SetupVisualStyles(Control parent)
	{
		foreach (Control c in parent.Controls)
		{
			if (c is TextBox txt) txt.BorderStyle = BorderStyle.FixedSingle;
			if (c is ComboBox cbo) cbo.FlatStyle = FlatStyle.Flat;
			if (c is GroupBox gb)
			{
				gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
				gb.ForeColor = Color.FromArgb(30, 58, 138);
			}

			if (c.HasChildren)
			{
				SetupVisualStyles(c);
			}
		}
	}

	private void StyleButton(Button btn, Color backColor, Color foreColor)
	{
		btn.FlatStyle = FlatStyle.Flat;
		btn.BackColor = backColor;
		btn.ForeColor = foreColor;
		btn.FlatAppearance.BorderSize = 0;
		btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
		btn.Cursor = Cursors.Hand;
		btn.Height = 35;
	}

	private void StyleDataGridView(DataGridView dgv)
	{
		dgv.BackgroundColor = Color.White;
		dgv.BorderStyle = BorderStyle.None;
		dgv.EnableHeadersVisualStyles = false;
		dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgv.RowHeadersVisible = false;
		dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

		// Header
		dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
		dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
		dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
		dgv.ColumnHeadersHeight = 40;

		// Rows
		dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
		dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
		dgv.RowTemplate.Height = 35;
		dgv.GridColor = Color.FromArgb(241, 245, 249);
		dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
	}
	private void LoadCTDP()
	{
		var ds = db.ChitietDps
			.Include(x => x.MaPhongNavigation)
			// Lọc 1: Trạng thái phòng không phải là "Trống"
			// Lọc 2: Chỉ lấy các Chi tiết đặt phòng của đơn chưa được thanh toán (chưa có hóa đơn)
			.Where(x => x.MaPhongNavigation.TrangThai != "Trống" &&
						!db.Hoadons.Any(hd => hd.MaDp == x.MaDp))
			.Select(x => new
			{
				x.MaCtdp,
				HienThi = "CTDP " + x.MaCtdp + " - " + x.MaPhongNavigation.TenPhong
			})
			.ToList();

		cboCTDP.DataSource = ds;
		cboCTDP.DisplayMember = "HienThi";
		cboCTDP.ValueMember = "MaCtdp";
	}

	private void LoadDichVuCombo()
	{
		var ds = db.Dichvus.ToList();

		cboDichVu.DataSource = ds;
		cboDichVu.DisplayMember = "TenDv";
		cboDichVu.ValueMember = "MaDv";
	}
	private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboDichVu.SelectedValue != null && int.TryParse(cboDichVu.SelectedValue.ToString(), out int maDV))
		{
			var dv = db.Dichvus.FirstOrDefault(x => x.MaDv == maDV);
			if (dv != null)
			{
				txtDonGia.Text = dv.GiaDv?.ToString();
				TinhThanhTien();
			}
		}
	}

	private void txtSoLuong_TextChanged(object sender, EventArgs e)
	{
		TinhThanhTien();
	}

	private void TinhThanhTien()
	{
		if (decimal.TryParse(txtDonGia.Text, out decimal donGia) &&
			int.TryParse(txtSoLuong.Text, out int soLuong))
		{
			txtThanhTien.Text = (donGia * soLuong).ToString("N0");
		}
		else
		{
			txtThanhTien.Clear();
		}
	}

	private void btnThemDV_Click(object sender, EventArgs e)
	{
		if (cboCTDP.SelectedValue == null)
		{
			MessageBox.Show("Vui lòng chọn phòng/chi tiết đặt phòng.");
			return;
		}

		if (cboDichVu.SelectedValue == null)
		{
			MessageBox.Show("Vui lòng chọn dịch vụ.");
			return;
		}

		if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
		{
			MessageBox.Show("Số lượng phải lớn hơn 0.");
			txtSoLuong.Focus();
			return;
		}

		int maCTDP = Convert.ToInt32(cboCTDP.SelectedValue);
		int maDV = Convert.ToInt32(cboDichVu.SelectedValue);

		var dv = db.Dichvus.FirstOrDefault(x => x.MaDv == maDV);
		if (dv == null)
		{
			MessageBox.Show("Không tìm thấy dịch vụ.");
			return;
		}

		var sd = new SudungDv
		{
			MaCtdp = maCTDP,
			MaDv = maDV,
			SoLuong = soLuong,
			DonGiaThucTe = dv.GiaDv,
			ThoiGianGoi = DateTime.Now
		};

		db.SudungDvs.Add(sd);
		db.SaveChanges();

		MessageBox.Show("Thêm dịch vụ cho phòng thành công.");
		LoadDSDichVu();
		txtSoLuong.Clear();
		txtThanhTien.Clear();
	}
	private void LoadDSDichVu()
	{
		var ds = db.SudungDvs
			.Include(x => x.MaCtdpNavigation)
				.ThenInclude(ct => ct.MaPhongNavigation)
			.Include(x => x.MaDvNavigation)
			.Select(x => new
			{
				x.MaSd,
				MaCTDP = x.MaCtdp,
				TenPhong = x.MaCtdpNavigation.MaPhongNavigation.TenPhong,
				TenDichVu = x.MaDvNavigation.TenDv,
				x.SoLuong,
				x.DonGiaThucTe,
				ThanhTien = (x.SoLuong ?? 0) * (x.DonGiaThucTe ?? 0),
				x.ThoiGianGoi
			})
			.ToList();

		dgvDSDichVu.DataSource = ds;
	}

	private void btnHuyDV_Click(object sender, EventArgs e)
	{
		if (dgvDSDichVu.CurrentRow == null)
		{
			MessageBox.Show("Vui lòng chọn dịch vụ cần hủy.");
			return;
		}

		int maSD = Convert.ToInt32(dgvDSDichVu.CurrentRow.Cells["MaSd"].Value);

		var sd = db.SudungDvs.FirstOrDefault(x => x.MaSd == maSD);
		if (sd == null)
		{
			MessageBox.Show("Không tìm thấy dữ liệu dịch vụ.");
			return;
		}

		var hoi = MessageBox.Show("Bạn có chắc muốn hủy dịch vụ này?", "Xác nhận",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (hoi == DialogResult.Yes)
		{
			db.SudungDvs.Remove(sd);
			db.SaveChanges();

			MessageBox.Show("Hủy dịch vụ thành công.");
			LoadDSDichVu();
		}
	}

	private void cboCTDP_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cboCTDP.SelectedValue != null && int.TryParse(cboCTDP.SelectedValue.ToString(), out int maCTDP))
		{
			var ds = db.SudungDvs
				.Include(x => x.MaDvNavigation)
				.Where(x => x.MaCtdp == maCTDP)
				.Select(x => new
				{
					x.MaSd,
					x.MaCtdp,
					TenDichVu = x.MaDvNavigation.TenDv,
					x.SoLuong,
					x.DonGiaThucTe,
					ThanhTien = (x.SoLuong ?? 0) * (x.DonGiaThucTe ?? 0),
					x.ThoiGianGoi
				})
				.ToList();

			dgvDSDichVu.DataSource = ds;
		}
	}

	


}
