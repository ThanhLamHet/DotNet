using System.Reflection.Metadata;

namespace Lab4_BT5_QuanLySinhVien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btCapnhat_Click(object sender, EventArgs e)
		{
			lstLopA.Items.Add(txtHoten.Text);
			txtHoten.Text = "";
			txtHoten.Focus();
		}

		private void btTraisangphai_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < lstLopA.SelectedItems.Count; i++)
			{
				string n = lstLopA.SelectedItems[i].ToString();
				lstLopB.Items.Add(n);
				lstLopA.Items.Remove(n);
			}
		}

		private void btTatcasangphai_Click(object sender, EventArgs e)
		{
			int n = lstLopA.Items.Count;
			for (int i = 0; i <= n - 1; i++)
				lstLopB.Items.Add(lstLopA.Items[i].ToString());
			for (int j = n - 1; j >= 0; j--)
				lstLopA.Items.Clear();
		}

		private void btPhaisangtrai_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < lstLopB.SelectedItems.Count; i++)
			{
				string n = lstLopB.SelectedItems[i].ToString();
				lstLopA.Items.Add(n);
				lstLopB.Items.Remove(n);
			}
		}

		private void btTatcasangtrai_Click(object sender, EventArgs e)
		{
			int n = lstLopB.Items.Count;
			for (int i = 0; i <= n - 1; i++)
				lstLopA.Items.Add(lstLopB.Items[i].ToString());
			for (int j = n - 1; j >= 0; j--)
				lstLopB.Items.Clear();
		}

		private void btXoa_Click(object sender, EventArgs e)
		{
			int n = lstLopA.SelectedItems.Count; //Số mục dang duoc chon trong lstKetQua 
			for (int i = n - 1; i >= 0; i--)
				lstLopA.Items.Remove(lstLopA.SelectedItems[i].ToString());

			int j = lstLopB.SelectedItems.Count; //Số mục dang duoc chon trong lstKetQua 
			for (int i = j - 1; i >= 0; i--)
				lstLopB.Items.Remove(lstLopB.SelectedItems[i].ToString());
		}

		private void btKetthuc_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
