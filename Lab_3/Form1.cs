namespace Lab_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCong_Click(object sender, EventArgs e)
		{
			double n = double.Parse(txtSoN.Text);
			double m = double.Parse(txtSoM.Text);
			double Tong = n + m;

			txtKetQua.Text = Tong.ToString();
		}

		private void btnTru_Click(object sender, EventArgs e)
		{
			double n = double.Parse(txtSoN.Text);
			double m = double.Parse(txtSoM.Text);
			double Hieu = n - m;

			txtKetQua.Text = Hieu.ToString();
		}

		private void btnNhan_Click(object sender, EventArgs e)
		{
			double n = double.Parse(txtSoN.Text);
			double m = double.Parse(txtSoM.Text);
			double Tich = n * m;

			txtKetQua.Text = Tich.ToString();
		}

		private void btnChia_Click(object sender, EventArgs e)
		{
			double n = double.Parse(txtSoN.Text);
			double m = double.Parse(txtSoM.Text);
			double Thuong = n / m;
			if (m == 0)
			{
				txtKetQua.Text = "Lỗi phép tính";
			}
			else
			{
				txtKetQua.Text = Thuong.ToString();
			}

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{

		}
	}
}
