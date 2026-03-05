using System;

namespace Lab01
{
	// ================= LỚP NHÂN VIÊN (CHA) =================
	class NhanVien
	{
		private string HoTen;
		private int NamSinh;
		private string BangCap;

		public string Name
		{
			get { return HoTen; }
			set { HoTen = value; }
		}

		public int BirthYear
		{
			get { return NamSinh; }
			set { NamSinh = value; }
		}

		public string Degree
		{
			get { return BangCap; }
			set { BangCap = value; }
		}

		public NhanVien() { }

		public NhanVien(string ten, int ns, string bc)
		{
			HoTen = ten;
			NamSinh = ns;
			BangCap = bc;
		}

		public virtual float TinhLuong()
		{
			return 0;
		}

		public virtual void Show()
		{
			Console.WriteLine("Ho ten:{0}", HoTen);
			Console.WriteLine("Nam sinh:{0}", NamSinh);
			Console.WriteLine("Bang cap:{0}", BangCap);
		}
	}

	// ================= LỚP NHÀ QUẢN LÝ =================
	class NhaQuanLy : NhanVien
	{
		private string ChucVu;
		private int SoNgayCong;
		private float BacLuong;

		public string Position
		{
			get { return ChucVu; }
			set { ChucVu = value; }
		}

		public int WorkDays
		{
			get { return SoNgayCong; }
			set { SoNgayCong = value; }
		}

		public float SalaryLevel
		{
			get { return BacLuong; }
			set { BacLuong = value; }
		}

		public override float TinhLuong()
		{
			return SoNgayCong * BacLuong;
		}

		public override void Show()
		{
			base.Show();
			Console.WriteLine("Chuc vu:{0}", ChucVu);
			Console.WriteLine("So ngay cong:{0}", SoNgayCong);
			Console.WriteLine("Bac luong:{0}", BacLuong);
			Console.WriteLine("Luong:{0}", TinhLuong());
		}
	}

	// ================= LỚP NHÀ KHOA HỌC =================
	class NhaKhoaHoc : NhaQuanLy
	{
		private int SoBaiBao;

		public int PaperCount
		{
			get { return SoBaiBao; }
			set { SoBaiBao = value; }
		}

		public override void Show()
		{
			base.Show();
			Console.WriteLine("So bai bao da cong bo:{0}", SoBaiBao);
		}
	}

	// ================= NHÂN VIÊN PHÒNG THÍ NGHIỆM =================
	class NhanVienPTN : NhanVien
	{
		private float LuongKhoan;

		public float FixedSalary
		{
			get { return LuongKhoan; }
			set { LuongKhoan = value; }
		}

		public override float TinhLuong()
		{
			return LuongKhoan;
		}

		public override void Show()
		{
			base.Show();
			Console.WriteLine("Luong khoan:{0}", LuongKhoan);
		}
	}

	// ================= TESTER =================
	class Tester
	{
		public static void Main()
		{
			NhanVien[] DSNV;
			int n;

			Console.Write("Nhap so luong nhan vien:");
			n = int.Parse(Console.ReadLine());

			DSNV = new NhanVien[n];

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("\n1. Nha quan ly");
				Console.WriteLine("2. Nha khoa hoc");
				Console.WriteLine("3. Nhan vien phong thi nghiem");
				Console.Write("Chon loai nhan vien:");
				int chon = int.Parse(Console.ReadLine());

				if (chon == 1)
				{
					NhaQuanLy nv = new NhaQuanLy();
					Console.Write("Ho ten:");
					nv.Name = Console.ReadLine();
					Console.Write("Nam sinh:");
					nv.BirthYear = int.Parse(Console.ReadLine());
					Console.Write("Bang cap:");
					nv.Degree = Console.ReadLine();
					Console.Write("Chuc vu:");
					nv.Position = Console.ReadLine();
					Console.Write("So ngay cong:");
					nv.WorkDays = int.Parse(Console.ReadLine());
					Console.Write("Bac luong:");
					nv.SalaryLevel = float.Parse(Console.ReadLine());
					DSNV[i] = nv;
				}
				else if (chon == 2)
				{
					NhaKhoaHoc nv = new NhaKhoaHoc();
					Console.Write("Ho ten:");
					nv.Name = Console.ReadLine();
					Console.Write("Nam sinh:");
					nv.BirthYear = int.Parse(Console.ReadLine());
					Console.Write("Bang cap:");
					nv.Degree = Console.ReadLine();
					Console.Write("Chuc vu:");
					nv.Position = Console.ReadLine();
					Console.Write("So ngay cong:");
					nv.WorkDays = int.Parse(Console.ReadLine());
					Console.Write("Bac luong:");
					nv.SalaryLevel = float.Parse(Console.ReadLine());
					Console.Write("So bai bao:");
					nv.PaperCount = int.Parse(Console.ReadLine());
					DSNV[i] = nv;
				}
				else
				{
					NhanVienPTN nv = new NhanVienPTN();
					Console.Write("Ho ten:");
					nv.Name = Console.ReadLine();
					Console.Write("Nam sinh:");
					nv.BirthYear = int.Parse(Console.ReadLine());
					Console.Write("Bang cap:");
					nv.Degree = Console.ReadLine();
					Console.Write("Luong khoan:");
					nv.FixedSalary = float.Parse(Console.ReadLine());
					DSNV[i] = nv;
				}
			}

			Console.WriteLine("\n===== DANH SACH NHAN VIEN =====");
			float tongLuongQL = 0, tongLuongKH = 0, tongLuongPTN = 0;

			foreach (NhanVien nv in DSNV)
			{
				nv.Show();
				Console.WriteLine("----------------------------");

				if (nv is NhaKhoaHoc)
					tongLuongKH += nv.TinhLuong();
				else if (nv is NhaQuanLy)
					tongLuongQL += nv.TinhLuong();
				else
					tongLuongPTN += nv.TinhLuong();
			}

			Console.WriteLine("\nTong luong Nha quan ly: {0}", tongLuongQL);
			Console.WriteLine("Tong luong Nha khoa hoc: {0}", tongLuongKH);
			Console.WriteLine("Tong luong Nhan vien PTN: {0}", tongLuongPTN);

			Console.ReadLine();
		}
	}
}
