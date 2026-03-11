using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab_8_StudentMS
{
	public partial class frmKhoa : Form
	{
		SqlConnection conn = new SqlConnection(
	"Data Source=THANHLAMHET\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

		SqlDataAdapter da;
		DataTable dtKhoa = new DataTable();
		BindingSource bs = new BindingSource();

		public frmKhoa()
		{
			InitializeComponent();
		}

		private void Khoa_Load(object sender, EventArgs e)
		{
			try
			{
				da = new SqlDataAdapter("SELECT * FROM Khoa", conn);

				// TỰ ĐỘNG INSERT / UPDATE / DELETE
				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				da.Fill(dtKhoa);

				bs.DataSource = dtKhoa;
				dataGridViewKhoa.DataSource = bs;

				txtMaKhoa.DataBindings.Clear();
				txtTenKhoa.DataBindings.Clear();

				txtMaKhoa.DataBindings.Add("Text", bs, "MaKhoa", true);
				txtTenKhoa.DataBindings.Add("Text", bs, "TenKhoa", true);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải khoa: " + ex.Message);
			}
		}



		// ================= LƯU =================
		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();
				bs.EndEdit();

				SqlCommandBuilder builder = new SqlCommandBuilder(da);
				da.Update(dtKhoa);

				MessageBox.Show("Lưu khoa thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi lưu: " + ex.Message);
				dtKhoa.Clear();
				da.Fill(dtKhoa);
			}
		}


		// ================= XÓA =================
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (bs.Count == 0 || bs.Current == null)
			{
				MessageBox.Show("Không có khoa để xóa");
				return;
			}

			DataRowView row = (DataRowView)bs.Current;
			string tenKhoa = row["TenKhoa"].ToString();

			DialogResult rs = MessageBox.Show(
				$"Bạn có chắc muốn xóa khoa {tenKhoa}?",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (rs == DialogResult.Yes)
			{
				try
				{
					bs.RemoveCurrent();

					SqlCommandBuilder builder = new SqlCommandBuilder(da);
					da.Update(dtKhoa);

					MessageBox.Show("Đã xóa khoa");
				}
				catch
				{
					MessageBox.Show("Không thể xóa khoa vì đang có sinh viên thuộc khoa này");
					dtKhoa.Clear();
					da.Fill(dtKhoa);
				}
			}
		}

		private void btnLuu_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.Validate();
				bs.EndEdit();

				SqlCommandBuilder builder = new SqlCommandBuilder(da);
				da.Update(dtKhoa);

				MessageBox.Show("Lưu khoa thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi lưu: " + ex.Message);
				dtKhoa.Clear();
				da.Fill(dtKhoa);
			}
		}

		private void dataGridViewKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			{
				try
				{
					this.Validate();
					bs.EndEdit();

					bs.AddNew();

					DataRowView row = (DataRowView)bs.Current;

					// Nếu MaKhoa là VARCHAR
					row["MaKhoa"] = "";
					row["TenKhoa"] = "";

					bs.MoveLast();
					txtMaKhoa.Focus();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi thêm khoa: " + ex.Message);
				}
			}
		}
	}
}
