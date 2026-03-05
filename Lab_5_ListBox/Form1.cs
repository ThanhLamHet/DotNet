using System.Xml.Linq;

namespace Lab_5_ListBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}



		private void GetPay()
		{
			// 1. Kiểm tra tên khách hàng (không được để trống)
			if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
			{
				MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtTenKhachHang.Focus();
				return;
			}

			// 2. Tính toán tổng tiền
			double total = 0;

			// Phí lấy cao răng: 100.000
			if (chkcaovoi.Checked)
				total += 100000;


			if (chkTayTrang.Checked)
				total += 1200000;

			// Phí chụp X-Quang: 200.000
			if (chkChupHinh.Checked)
				total += 200000;

			// Phí trám răng: Số lượng * 80.000
			// Lấy giá trị từ NumericUpDown và nhân với đơn giá
			total += ((int)numericUpDownFilling.Value * 80000);

			// 3. Hiển thị kết quả
			// Định dạng "N0" sẽ giúp hiển thị số có dấu phân cách hàng nghìn (VD: 1,500,000)
			txtTongTien.Text = total.ToString("N0");
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
		}

		private void btnTongTien_Click(object sender, EventArgs e)
		{
			GetPay();
		}

		private void btnThemDanhSach_Click(object sender, EventArgs e)
		{
			string info = txtTenKhachHang.Text + " : Tổng Tiền " + txtTongTien.Text + " đ";
			lbKhach.Items.Add(info);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (lbKhach.SelectedIndex != -1)
			{
				DialogResult dr = MessageBox.Show("dfghjkl");
			}
		}

		private void btnLuuFile_Click(object sender, EventArgs e)
		{
			try
			{
				// Khởi tạo StreamWriter để ghi vào tệp "database.txt"
				// Tệp này sẽ nằm cùng thư mục với file .exe của bạn
				using (StreamWriter writer = new StreamWriter("database.txt"))
				{
					// Duyệt qua từng mục trong ListBox (tên là listBoxCustomer)
					foreach (var item in lbKhach.Items)
					{
						writer.WriteLine(item.ToString());
					}
				}
				MessageBox.Show("Đã lưu danh sách vào tệp thành công!", "Thông báo");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
			}
		}

		private void btnTaiFile_Click(object sender, EventArgs e)
		{

		}
	}
}
