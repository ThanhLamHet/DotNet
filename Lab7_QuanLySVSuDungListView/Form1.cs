namespace Lab7_QuanLySVSuDungListView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 1; i <= 5; i++)
			{
				ListViewItem item = new ListViewItem();
				item.Text = "Nguyễn Văn " + i.ToString();
				item.SubItems.Add("01/01/200" + i);
				item.SubItems.Add("Địa chỉ " + i.ToString());
				item.SubItems.Add("012345678" + i.ToString());
				listDanhSach.Items.Add(item);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtHoten.Text.Trim().Length > 0)
			{
				ListViewItem item = new ListViewItem();
				item.Text = txtHoten.Text;
				item.SubItems.Add(dtNgaySinh.Value.ToShortDateString());
				item.SubItems.Add(txtDiaChi.Text);
				item.SubItems.Add(txtSDT.Text);

				// Lưu ý: Trong ảnh bị thiếu dòng này để hiển thị lên bảng:
				listDanhSach.Items.Add(item);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập họ và tên trước khi thêm");
			}
		}
		private void chonMotDong(object sender, EventArgs e)
		{
			// Kiểm tra xem có dòng nào đang được chọn không
			if (listDanhSach.SelectedItems.Count > 0)
			{
				// Lấy dữ liệu từ dòng đầu tiên trong danh sách đang chọn (vị trí [0])
				txtHoten.Text = listDanhSach.SelectedItems[0].SubItems[0].Text;

				// Dòng ngày sinh đang bị chú thích (comment), bạn có thể mở ra nếu cần
				//dtNgaySinh.Text = listDanhSach.SelectedItems[0].SubItems[1].Text; 

				txtDiaChi.Text = listDanhSach.SelectedItems[0].SubItems[2].Text;
				txtSDT.Text = listDanhSach.SelectedItems[0].SubItems[3].Text;
			}
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (listDanhSach.SelectedItems.Count > 0)
			{
				// Hiển thị dialog xác nhận
				DialogResult result = MessageBox.Show(
					"Bạn có chắc chắn muốn xóa nhân viên này?",
					"Xác nhận xóa",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				// Nếu người dùng nhấn "Yes" mới xóa
				if (result == DialogResult.Yes)
				{
					listDanhSach.Items.Remove(listDanhSach.SelectedItems[0]);
					// Xóa dữ liệu trên form
					txtHoten.Text = "";
					dtNgaySinh.Value = DateTime.Now;
					txtDiaChi.Text = "";
					txtSDT.Text = "";
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một nhân viên để xóa", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
			"Bạn có chắc chắn muốn thoát ứng dụng?",
			"Xác nhận thoát",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question,
			MessageBoxDefaultButton.Button2  // Mặc định chọn "No"
);

			if (result == DialogResult.Yes)
			{
				Close();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (listDanhSach.SelectedItems.Count > 0)
			{
				listDanhSach.SelectedItems[0].SubItems[0].Text = txtHoten.Text;
				listDanhSach.SelectedItems[0].SubItems[1].Text = dtNgaySinh.Value.ToString("dd/MM/yyyy");
				listDanhSach.SelectedItems[0].SubItems[2].Text = txtDiaChi.Text;
				listDanhSach.SelectedItems[0].SubItems[3].Text = txtSDT.Text;
			}
		}
	}
}
