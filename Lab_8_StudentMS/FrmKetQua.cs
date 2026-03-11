using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab_8_StudentMS
{
	public partial class FrmKetQua : Form
	{
		SqlConnection conn = new SqlConnection("Data Source=THANHLAMHET\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True");

		SqlDataAdapter da;
		DataTable dtKetQua = new DataTable();
		BindingSource bs = new BindingSource();

		public FrmKetQua()
		{
			InitializeComponent();
		}

		// ================= LOAD =================

		private void FrmKetQua_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		void LoadData()
		{
			try
			{
				string sql = @"SELECT 
                                SinhVien.MaSo,
                                Mon.MaMH,
                                SinhVien.HoTen AS TenSinhVien,
                                Mon.TenMH AS TenMonHoc,
                                KetQua.Diem
                               FROM KetQua
                               JOIN SinhVien ON KetQua.MaSo = SinhVien.MaSo
                               JOIN Mon ON KetQua.MaMH = Mon.MaMH";

				da = new SqlDataAdapter(sql, conn);

				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				dtKetQua.Clear();
				da.Fill(dtKetQua);

				bs.DataSource = dtKetQua;
				dataGridViewDiem.DataSource = bs;

				// binding textbox
				txtMaSV.DataBindings.Clear();
				txtMaMH.DataBindings.Clear();
				txtDiem.DataBindings.Clear();

				txtMaSV.DataBindings.Add("Text", bs, "MaSo", true);
				txtMaMH.DataBindings.Add("Text", bs, "MaMH", true);
				txtDiem.DataBindings.Add("Text", bs, "Diem", true);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

		// kiểm tra sinh viên tồn tại
		bool KiemTraSinhVien(string maSV)
		{
			string sql = "SELECT COUNT(*) FROM SinhVien WHERE MaSo=@MaSo";

			SqlCommand cmd = new SqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@MaSo", maSV);

			int count = (int)cmd.ExecuteScalar();

			return count > 0;
		}

		// kiểm tra môn học tồn tại
		bool KiemTraMonHoc(string maMH)
		{
			string sql = "SELECT COUNT(*) FROM Mon WHERE MaMH=@MaMH";

			SqlCommand cmd = new SqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@MaMH", maMH);

			int count = (int)cmd.ExecuteScalar();

			return count > 0;
		}


		// ================= THÊM =================

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();
				bs.EndEdit();

				// tạo dòng mới
				bs.AddNew();

				DataRowView row = (DataRowView)bs.Current;

				row["MaSo"] = "";
				row["MaMH"] = "";
				row["Diem"] = 0;

				bs.MoveLast();

				txtMaSV.Focus();
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
				conn.Open();

				// kiểm tra sinh viên
				string sqlSV = "SELECT COUNT(*) FROM SinhVien WHERE MaSo=@MaSo";
				SqlCommand cmdSV = new SqlCommand(sqlSV, conn);
				cmdSV.Parameters.AddWithValue("@MaSo", txtMaSV.Text);

				int checkSV = (int)cmdSV.ExecuteScalar();

				if (checkSV == 0)
				{
					MessageBox.Show("Mã sinh viên không tồn tại!");
					conn.Close();
					return;
				}

				// kiểm tra môn học
				string sqlMH = "SELECT COUNT(*) FROM Mon WHERE MaMH=@MaMH";
				SqlCommand cmdMH = new SqlCommand(sqlMH, conn);
				cmdMH.Parameters.AddWithValue("@MaMH", txtMaMH.Text);

				int checkMH = (int)cmdMH.ExecuteScalar();

				if (checkMH == 0)
				{
					MessageBox.Show("Mã môn học không tồn tại!");
					conn.Close();
					return;
				}

				conn.Close();

				// nếu hợp lệ thì lưu
				this.Validate();
				bs.EndEdit();

				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				da.Update(dtKetQua);

				MessageBox.Show("Lưu thành công!");

				dtKetQua.Clear();
				da.Fill(dtKetQua);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi CSDL: " + ex.Message);

				dtKetQua.Clear();
				da.Fill(dtKetQua);
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

			DataRowView row = (DataRowView)bs.Current;

			DialogResult result = MessageBox.Show(
				"Bạn có chắc muốn xóa kết quả này?",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				try
				{
					bs.RemoveCurrent();

					SqlCommandBuilder builder = new SqlCommandBuilder(da);
					da.Update(dtKetQua);

					MessageBox.Show("Đã xóa thành công!");
				}
				catch
				{
					MessageBox.Show("Không thể xóa!");

					dtKetQua.Clear();
					da.Fill(dtKetQua);
				}
			}
		}

		private void FrmKetQua_Load_1(object sender, EventArgs e)
		{
			try
			{
				string sql = @"SELECT 
								KetQua.MaSo,
								KetQua.MaMH,
								SinhVien.HoTen AS TenSinhVien,
								Mon.TenMH AS TenMonHoc,
								KetQua.Diem
							   FROM KetQua
							   JOIN SinhVien ON KetQua.MaSo = SinhVien.MaSo
							   JOIN Mon ON KetQua.MaMH = Mon.MaMH";

				da = new SqlDataAdapter(sql, conn);

				SqlCommandBuilder builder = new SqlCommandBuilder(da);

				da.Fill(dtKetQua);

				bs.DataSource = dtKetQua;
				dataGridViewDiem.DataSource = bs;

				// binding textbox
				txtMaSV.DataBindings.Clear();
				txtMaMH.DataBindings.Clear();
				txtDiem.DataBindings.Clear();

				txtMaSV.DataBindings.Add("Text", bs, "MaSo", true);
				txtMaMH.DataBindings.Add("Text", bs, "MaMH", true);
				txtDiem.DataBindings.Add("Text", bs, "Diem", true);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
			}
		}

	}
}