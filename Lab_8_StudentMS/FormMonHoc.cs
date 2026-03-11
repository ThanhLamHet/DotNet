using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab_8_StudentMS
{
	public partial class FormMonHoc : Form
	{
		SqlConnection conn = new SqlConnection(
		"Data Source=THANHLAMHET\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True");

		SqlDataAdapter da;
		DataTable dtMonHoc = new DataTable();
		BindingSource bs = new BindingSource();

		public FormMonHoc()
		{
			InitializeComponent();
		}

		// ================= LOAD =================
		private void FormMonHoc_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		void LoadData()
		{
			try
			{
				da = new SqlDataAdapter("SELECT * FROM Mon", conn);
				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				dtMonHoc.Clear();
				da.Fill(dtMonHoc);

				bs.DataSource = dtMonHoc;
				dataGridViewMonHoc.DataSource = bs;

				// Clear binding
				txtMaMon.DataBindings.Clear();
				txtTenMon.DataBindings.Clear();
				txtSoTiet.DataBindings.Clear();

				// Binding
				txtMaMon.DataBindings.Add("Text", bs, "MaMH", true);
				txtTenMon.DataBindings.Add("Text", bs, "TenMH", true);
				txtSoTiet.DataBindings.Add("Text", bs, "SoTiet", true);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		// ================= THÊM =================
		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				bs.AddNew();

				txtMaMon.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi thêm: " + ex.Message);
			}
		}

		// ================= LƯU =================
		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();
				bs.EndEdit();

				da.Update(dtMonHoc);

				MessageBox.Show("Lưu thành công!");
				LoadData(); // refresh lại
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi CSDL: " + ex.Message);
				LoadData();
			}
		}

		// ================= XÓA =================
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (bs.Current == null)
			{
				MessageBox.Show("Không có dữ liệu để xóa!");
				return;
			}

			DialogResult result = MessageBox.Show(
				"Bạn có chắc muốn xóa?",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				try
				{
					bs.RemoveCurrent();
					da.Update(dtMonHoc);

					MessageBox.Show("Đã xóa thành công!");
					LoadData();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Không thể xóa: " + ex.Message);
					LoadData();
				}
			}
		}
	}
}