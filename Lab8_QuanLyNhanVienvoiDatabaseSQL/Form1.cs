<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab8_QuanLyNhanVienvoiDatabaseSQL
{
	public partial class Form1 : Form
	{


		SqlConnection conn = new SqlConnection("Data Source=THANHLAMHET\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
		SqlDataAdapter da;
		DataTable dt = new DataTable();
		BindingSource bs = new BindingSource();
		public Form1()
		{
			InitializeComponent();
		}

		private void frmSinhVien_Load(object sender, EventArgs e)
		{
			// Doc data tu SQL
			da = new SqlDataAdapter("SELECT * FROM SINHVIEN", conn);
			da.Fill(dt);

			// Gan data vao BS
			bs.DataSource = dt;

			// Lien ket BS voi DataGridView va Navigator
			dgvSinhVien.DataSource = bs;

			// Lien ket tung textbox voi cac cot tuong ung
			txtMSSV.DataBindings.Add("Text", bs, "MaSo");
			txtTen.DataBindings.Add("Text", bs, "HoTen");
			dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
			txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");
			txtSDT.DataBindings.Add("Text", bs, "DienThoai");
			txtMaKhoa.DataBindings.Add("Text", bs, "Makhoa");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			using SqlConnection conn = new SqlConnection(connectionString);
			string sql = "SELECT * FROM SinhVien";

			SqlDataAdapter da = new SqlDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);


			BindingSource.DataSource = dt;
			dgvSinhVien.DataSource = BindingSource;
		}

		private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void txtHoten_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
=======
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab8_QuanLyNhanVienvoiDatabaseSQL
{
	public partial class Form1 : Form
	{


		SqlConnection conn = new SqlConnection("Data Source=THANHLAMHET\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
		SqlDataAdapter da;
		DataTable dt = new DataTable();
		BindingSource bs = new BindingSource();
		public Form1()
		{
			InitializeComponent();
		}

		private void frmSinhVien_Load(object sender, EventArgs e)
		{
			// Doc data tu SQL
			da = new SqlDataAdapter("SELECT * FROM SINHVIEN", conn);
			da.Fill(dt);

			// Gan data vao BS
			bs.DataSource = dt;

			// Lien ket BS voi DataGridView va Navigator
			dgvSinhVien.DataSource = bs;

			// Lien ket tung textbox voi cac cot tuong ung
			txtMSSV.DataBindings.Add("Text", bs, "MaSo");
			txtTen.DataBindings.Add("Text", bs, "HoTen");
			dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
			txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");
			txtSDT.DataBindings.Add("Text", bs, "DienThoai");
			txtMaKhoa.DataBindings.Add("Text", bs, "Makhoa");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			using SqlConnection conn = new SqlConnection(connectionString);
			string sql = "SELECT * FROM SinhVien";

			SqlDataAdapter da = new SqlDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);


			BindingSource.DataSource = dt;
			dgvSinhVien.DataSource = BindingSource;
		}

		private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void txtHoten_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
>>>>>>> 2a18ad26c5e5ca62758f0f1000e1b8543bcff917
