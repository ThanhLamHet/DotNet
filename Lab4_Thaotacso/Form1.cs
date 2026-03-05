namespace Lab4_Thaotacso
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void frmThaotactrenListbox_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
	 MessageBoxIcon.Question) == DialogResult.No)
				e.Cancel = true;
		}
		private void txtSonguyen_TextChanged(object sender, EventArgs e)
		{
			Control ctrSonguyen = (Control)sender;
			if (ctrSonguyen.Text.Length > 0)
				if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
					this.errSonguyen.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
				else
					this.errSonguyen.Clear();
		}

		private void btCapnhat_Click(object sender, EventArgs e)
		{
			lstKetQua.Items.Add(txtSonguyen.Text);
			txtSonguyen.Text = "";
			txtSonguyen.Focus();
		}

		private void btTang2_Click(object sender, EventArgs e)
		{
			int n = lstKetQua.Items.Count; //Số mục trong lst 
			for (int i = 0; i < n; i++)
			{
				int tam = int.Parse(lstKetQua.Items[i].ToString()) + 2;
				lstKetQua.Items.RemoveAt(i);
				lstKetQua.Items.Insert(i, tam.ToString());
			}
		}

		private void btChonchandau_Click(object sender, EventArgs e)
		{
			int n = lstKetQua.Items.Count; //Số mục trong lst 
			for (int i = 0; i < n - 1; i++)
			{
				if (int.Parse(lstKetQua.Items[i].ToString()) % 2 == 0)
				{
					string s = lstKetQua.Items[i].ToString();//Lay gia tri muc gia tri chan 
					lstKetQua.SelectedItem = s;//Chon muc co gia tri chan 
					break; //Thuc hien duoc so chn dau thi ket thuc vong lap 
				}
			}
		}

		private void btLecuoi_Click(object sender, EventArgs e)
		{
			int n = lstKetQua.Items.Count; //Số mục trong lst 
			for (int i = n - 1; i >= 0; i--)
			{
				if (int.Parse(lstKetQua.Items[i].ToString()) % 2 == 1)
				{
					string s = lstKetQua.Items[i].ToString();//Lay gia tri muc gia tri lẻ 
					lstKetQua.SelectedItem = s;//Chon muc co gia tri le 
					break; //Thuc hien duoc so le dau (tu duoi len) thi ket thuc vong lap 
				}
			}
		}

		private void btXoaphantudangchon_Click(object sender, EventArgs e)
		{
			int n = lstKetQua.SelectedItems.Count; //Số mục dang duoc chon trong lstKetQua 
			for (int i = n - 1; i >= 0; i--)
				lstKetQua.Items.Remove(lstKetQua.SelectedItems[i].ToString());
		}

		private void btXoaphantudau_Click(object sender, EventArgs e)
		{
			lstKetQua.Items.Remove(lstKetQua.Items[0].ToString());
		}

		private void btXoaphantucuoi_Click(object sender, EventArgs e)
		{
			int n = lstKetQua.Items.Count;
			lstKetQua.Items.Remove(lstKetQua.Items[n - 1].ToString());
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
