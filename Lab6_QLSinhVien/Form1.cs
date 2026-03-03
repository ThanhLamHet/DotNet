using static System.Net.Mime.MediaTypeNames;

namespace Lab6_QLSinhVien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		bool kiemTraMaSV(string ma)
		{
			// Kiểm tra trong danh sách sinh viên tổng
			for (int i = 0; i < lvDanhSachSV.Items.Count; i++)
			{
				if (lvDanhSachSV.Items[i].Text == ma)
				{
					return false;
				}
			}

			// Kiểm tra trong danh sách đã chọn
			for (int i = 0; i < lvDachon.Items.Count; i++)
			{
				if (lvDachon.Items[i].Text == ma)
				{
					return false;
				}
			}

			return true;
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			// Lấy dữ liệu và xóa khoảng trắng thừa
			string maSV = txtMaSV.Text.Trim();
			string hoTen = txtHoten.Text.Trim();

			// 1. Kiểm tra rỗng
			if (maSV == "" || hoTen == "")
			{
				MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
			}
			// 2. Kiểm tra trùng mã (Dựa theo logic trong ảnh của bạn)
			else if (kiemTraMaSV(maSV) == false)
			{
				MessageBox.Show("Mã số sinh viên đã tồn tại, vui lòng nhập lại!", "Thông báo");
				txtMaSV.SelectAll();
				txtMaSV.Focus();
			}
			// 3. Thêm vào ListView nếu hợp lệ
			else
			{
				int stt = lvDanhSachSV.Items.Count + 1;
				ListViewItem li = new ListViewItem(stt.ToString());
				li.SubItems.Add(maSV);
				li.SubItems.Add(hoTen);

				lvDanhSachSV.Items.Add(li);

				// Reset form để nhập tiếp
				txtMaSV.Text = "";
				txtHoten.Text = "";
				txtMaSV.Focus();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int i = 0;
			while (i < lvDanhSachSV.Items.Count)
			{
				if (lvDanhSachSV.Items[i].Selected == true)
				{
					lvDanhSachSV.Items.RemoveAt(i);
				}
				else
				{
					i++;
				}
				// Gọi hàm đánh số thứ tự ngay trong vòng lặp
				danhSoThuTu(lvDanhSachSV);
			}
		}
		private void danhSoThuTu(ListView lv)
		{
			for (int i = 0; i < lv.Items.Count; i++)
			{
				// Gán lại số thứ tự (bắt đầu từ 1) vào cột đầu tiên
				lv.Items[i].Text = (i + 1).ToString();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
		}
		private void tim(ListView lv, string text)
		{
			text = text.ToUpper();
			for (int i = 0; i < lv.Items.Count; i++)
			{
				// Lấy Mã SV ở cột 2 và Họ tên ở cột 3 để so sánh
				string maSV = lv.Items[i].SubItems[1].Text.ToUpper();
				string hoTen = lv.Items[i].SubItems[2].Text.ToUpper();

				if (maSV.Contains(text) || hoTen.Contains(text))
				{
					lv.Items[i].Selected = true;
					lv.Items[i].EnsureVisible(); // Cuộn đến dòng tìm thấy
					lv.Items[i].Focused = true;
				}
				else
				{
					lv.Items[i].Selected = false;
				}
			}
		}
		private void btntimKiem_Click(object sender, EventArgs e)
		{
			thucHienTim();
		}
		private void thucHienTim()
		{
			tim(lvDanhSachSV, txtTimKiem.Text);
			txtTimKiem.SelectAll();
			txtTimKiem.Focus();
		}

		private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
			{
				thucHienTim();
			}
		}

		private void btTraisangphai_Click(object sender, EventArgs e)
		{
			int i = 0;
			while (i < lvDanhSachSV.Items.Count)
			{
				if (lvDanhSachSV.Items[i].Selected == true)
				{
					ListViewItem li = lvDanhSachSV.Items[i];
					lvDanhSachSV.Items.RemoveAt(i);
					lvDachon.Items.Add(li);
				}
				else i++;
			}
			danhSoThuTu(lvDanhSachSV);
			danhSoThuTu(lvDachon);
		}

		private void btTravel_Click(object sender, EventArgs e)
		{
			int i = 0;
			while (i < lvDachon.Items.Count)
			{
				if (lvDachon.Items[i].Selected == true)
				{
					ListViewItem li = lvDachon.Items[i];
					lvDachon.Items.RemoveAt(i);
					lvDanhSachSV.Items.Add(li);
				}
				else i++;
			}
			danhSoThuTu(lvDanhSachSV);
			danhSoThuTu(lvDachon);
		}

		private void btChonDS_Click(object sender, EventArgs e)
		{
			while (lvDanhSachSV.Items.Count > 0)
			{
				ListViewItem li = lvDanhSachSV.Items[0];
				lvDanhSachSV.Items.RemoveAt(0);
				lvDachon.Items.Add(li);
			}
			danhSoThuTu(lvDachon);
		}

		private void btTravelDS_Click(object sender, EventArgs e)
		{
			while (lvDachon.Items.Count > 0)
			{
				ListViewItem li = lvDachon.Items[0];
				lvDachon.Items.RemoveAt(0);
				lvDanhSachSV.Items.Add(li);
			}
			danhSoThuTu(lvDanhSachSV);
		}
	}
}
