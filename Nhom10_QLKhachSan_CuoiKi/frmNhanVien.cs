using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Nhom10_QLKhachSan_CuoiKi.Models;

namespace Nhom10_QLKhachSan_CuoiKi
{
	public partial class frmNhanVien : Form
	{
		private readonly QLKhachSanContext db = new QLKhachSanContext();
		private string currentImagePath = "";

		// Timer dùng để tối ưu tìm kiếm (Debounce Search)
		private System.Windows.Forms.Timer searchTimer = new System.Windows.Forms.Timer();

		public frmNhanVien()
		{
			InitializeComponent();

			// Gán các sự kiện
			this.Load += frmNhanVien_Load;
			dgvNhanVien.CellFormatting += DgvNhanVien_CellFormatting;
			dgvNhanVien.CellClick += dgvNhanVien_CellClick;

			btnThem.Click += btnThem_Click;
			btnSua.Click += btnSua_Click;
			btnXoa.Click += btnXoa_Click;
			btnLamMoi.Click += btnLamMoi_Click;
			btnChonAnh.Click += btnChonAnh_Click;

			// Cấu hình tính năng tìm kiếm thông minh (Debounce)
			searchTimer.Interval = 500; // Chờ 0.5s sau khi người dùng ngừng gõ mới tìm kiếm
			searchTimer.Tick += (s, ev) =>
			{
				searchTimer.Stop();
				LoadData();
			};

			txtTimKiem.TextChanged += (s, ev) =>
			{
				searchTimer.Stop();
				searchTimer.Start();
			};

			// Tìm kiếm nhanh qua ComboBox và Button
			cboLocTrangThai.SelectedIndexChanged += (s, ev) => LoadData();
			btnTimKiem.Click += (s, ev) => LoadData();
		}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			CauHinhGiaoDien();

			cboLocTrangThai.Items.AddRange(new[] { "Tất cả", "Đang làm việc", "Đã nghỉ việc" });
			cboLocTrangThai.SelectedIndex = 0;

			cboChucVu.Items.AddRange(new[] { "Lễ tân", "Quản lý", "Kế toán", "Buồng phòng" });
			cboTrangThai.Items.AddRange(new[] { "Đang làm việc", "Đã nghỉ việc" });

			LoadData();
		}

		// --- GIAO DIỆN HIỆN ĐẠI CHO DATAGRIDVIEW ---
		private void CauHinhGiaoDien()
		{
			dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
			dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
			dgvNhanVien.EnableHeadersVisualStyles = false;
			dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
			dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			dgvNhanVien.ColumnHeadersHeight = 40;
			dgvNhanVien.RowTemplate.Height = 35;
			dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvNhanVien.AllowUserToAddRows = false;
			dgvNhanVien.ReadOnly = true;
			dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void LoadData()
		{
			try
			{
				IQueryable<Nhanvien> query = db.Nhanviens.AsNoTracking();

				if (cboLocTrangThai.SelectedIndex > 0)
				{
					string loc = cboLocTrangThai.SelectedItem.ToString();
					query = query.Where(x => x.TrangThai == loc);
				}

				string tk = txtTimKiem.Text.Trim().ToLower();
				if (!string.IsNullOrEmpty(tk))
				{
					query = query.Where(x => x.HoTen.ToLower().Contains(tk) || x.SoDienThoai.Contains(tk));
				}

				var data = query.Select(x => new
				{
					x.MaNv,
					x.HoTen,
					x.SoDienThoai,
					x.ChucVu,
					x.TrangThai,
					x.HinhAnh
				}).ToList();

				dgvNhanVien.DataSource = data;

				if (dgvNhanVien.Columns.Count > 0)
				{
					dgvNhanVien.Columns["MaNv"].HeaderText = "Mã NV";
					dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
					dgvNhanVien.Columns["SoDienThoai"].HeaderText = "Điện Thoại";
					dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
					dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng Thái";
					dgvNhanVien.Columns["HinhAnh"].Visible = false;
				}

				int soNghiViec = data.Count(x => x.TrangThai == "Đã nghỉ việc");
				lblTongSo.Text = $"Tổng số: {data.Count} | Đã nghỉ: {soNghiViec}";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// --- XỬ LÝ HÌNH ẢNH ---
		private void btnChonAnh_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png" })
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					currentImagePath = ofd.FileName;
					picHinhAnh.ImageLocation = currentImagePath;
				}
			}
		}

		private string SaveImage()
		{
			if (string.IsNullOrEmpty(currentImagePath) || !File.Exists(currentImagePath)) return "";
			string folder = Path.Combine(Application.StartupPath, "Images");
			if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

			string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(currentImagePath);
			File.Copy(currentImagePath, Path.Combine(folder, newFileName), true);
			return newFileName;
		}

		// --- CHỨC NĂNG THÊM / SỬA ---
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtHoTen.Text))
			{
				MessageBox.Show("Vui lòng nhập họ tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var nv = new Nhanvien
			{
				HoTen = txtHoTen.Text.Trim(),
				SoDienThoai = txtSDT.Text.Trim(),
				ChucVu = cboChucVu.Text,
				TrangThai = string.IsNullOrEmpty(cboTrangThai.Text) ? "Đang làm việc" : cboTrangThai.Text,
				HinhAnh = SaveImage()
			};

			db.Nhanviens.Add(nv);
			db.SaveChanges();
			MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			btnLamMoi_Click(null, null);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaNV.Text)) return;
			int maNV = int.Parse(txtMaNV.Text);

			var nv = db.Nhanviens.Find(maNV);
			if (nv != null)
			{
				nv.HoTen = txtHoTen.Text.Trim();
				nv.SoDienThoai = txtSDT.Text.Trim();
				nv.ChucVu = cboChucVu.Text;
				nv.TrangThai = cboTrangThai.Text;

				if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
				{
					nv.HinhAnh = SaveImage();
				}

				db.SaveChanges();
				MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadData();
			}
		}

		// --- XÓA MỀM TỐI ƯU (SOFT DELETE) ---
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaNV.Text)) return;
			int maNV = int.Parse(txtMaNV.Text);

			var nv = db.Nhanviens.Find(maNV);
			if (nv == null) return;

			// Kiểm tra nhân viên này đã có hóa đơn/đặt phòng chưa
			bool isUsed = db.Datphongs.Any(dp => dp.MaNv == maNV);
			if (isUsed)
			{
				DialogResult result = MessageBox.Show(
					"Nhân viên này đã từng lập hóa đơn nên không thể xóa vĩnh viễn (để bảo toàn lịch sử).\n\nBạn có muốn tự động chuyển trạng thái thành 'Đã nghỉ việc' không?",
					"Gợi ý Xử lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					nv.TrangThai = "Đã nghỉ việc";
					db.SaveChanges();
					MessageBox.Show("Đã cập nhật trạng thái thành Đã nghỉ việc!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadData();
				}
				return;
			}

			// Nếu chưa có giao dịch nào, cho phép xóa hẳn
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa vĩnh viễn nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				db.Nhanviens.Remove(nv);
				db.SaveChanges();
				MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnLamMoi_Click(null, null);
			}
		}

		private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var row = dgvNhanVien.Rows[e.RowIndex];
				txtMaNV.Text = row.Cells["MaNv"].Value?.ToString();
				txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
				txtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString();
				cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
				cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();

				string imgName = row.Cells["HinhAnh"].Value?.ToString();
				currentImagePath = "";
				if (!string.IsNullOrEmpty(imgName))
				{
					string fullPath = Path.Combine(Application.StartupPath, "Images", imgName);
					picHinhAnh.ImageLocation = File.Exists(fullPath) ? fullPath : null;
				}
				else picHinhAnh.ImageLocation = null;
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtMaNV.Clear(); txtHoTen.Clear(); txtSDT.Clear(); txtTimKiem.Clear();
			cboChucVu.SelectedIndex = -1; cboTrangThai.SelectedIndex = -1; cboLocTrangThai.SelectedIndex = 0;
			picHinhAnh.ImageLocation = null; currentImagePath = "";
			LoadData();
		}

		// --- TỰ ĐỘNG TÔ MÀU NHÂN VIÊN NGHỈ VIỆC ---
		private void DgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && dgvNhanVien.Columns.Contains("TrangThai") && dgvNhanVien.Rows[e.RowIndex].Cells["TrangThai"].Value != null)
			{
				string trangThai = dgvNhanVien.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString().Trim();

				if (trangThai.Equals("Đã nghỉ việc", StringComparison.OrdinalIgnoreCase))
				{
					// Màu hồng nhạt, chữ đỏ
					dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 228, 225);
					dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
					dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightCoral;
				}
				else
				{
					// Màu bình thường
					dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
					dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
					dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
				}
			}
		}

		private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}