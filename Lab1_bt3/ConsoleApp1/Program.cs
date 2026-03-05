using System;
using System.Collections.Generic;

namespace Lab_01_bt3
{

	class Person
	{
		public string FullName { get; set; }
		public int BirthYear { get; set; }
		public string Degree { get; set; }

		public Person()
		{
			FullName = "NO NAME";
			BirthYear = 1900;
			Degree = "Dai hoc";
		}

		public Person(string fullName, int birthYear, string degree)
		{
			FullName = fullName;
			BirthYear = birthYear;
			Degree = degree;
		}

		public virtual void Display()
		{
			Console.WriteLine($"Ho ten: {FullName}");
			Console.WriteLine($"Nam sinh: {BirthYear}");
			Console.WriteLine($"Bang cap: {Degree}");
		}
	}


	class Student : Person
	{
		public int StudentID { get; set; }
		public string Faculty { get; set; }
		public float Mark { get; set; }

		public Student() : base()
		{
			StudentID = 0;
			Faculty = "CNTT";
			Mark = 0;
		}

		public Student(int id, string fullName, int birthYear, string degree,
					   string faculty, float mark)
			: base(fullName, birthYear, degree)
		{
			StudentID = id;
			Faculty = faculty;
			Mark = mark;
		}

		public void InputData()
		{
			Console.Write("  MSSV: ");
			StudentID = int.Parse(Console.ReadLine());

			Console.Write("  Ho ten: ");
			FullName = Console.ReadLine();

			Console.Write("  Nam sinh: ");
			BirthYear = int.Parse(Console.ReadLine());

			Console.Write("  Bang cap: ");
			Degree = Console.ReadLine();

			Console.Write("  Khoa: ");
			Faculty = Console.ReadLine();

			Console.Write("  Diem TB: ");
			Mark = float.Parse(Console.ReadLine());
		}

		public override void Display()
		{
			Console.WriteLine("=================================");
			Console.WriteLine($"MSSV: {StudentID}");
			base.Display();
			Console.WriteLine($"Khoa: {Faculty}");
			Console.WriteLine($"Diem TB: {Mark}");
			Console.WriteLine("=================================");
		}
	}

	class Tester
	{
		// Nhập 1 sinh viên
		private static Student InputOneStudent(int index)
		{
			Console.WriteLine($"\n--- Nhap thong tin sinh vien thu {index + 1} ---");
			Student st = new Student();
			st.InputData();
			return st;
		}

		private static List<Student> InputStudentList(int n)
		{
			List<Student> students = new List<Student>();
			for (int i = 0; i < n; i++)
			{
				students.Add(InputOneStudent(i));
			}
			return students;
		}


		private static void DisplayStudentList(List<Student> students)
		{
			Console.WriteLine("\n===== DANH SACH SINH VIEN =====");
			int i = 1;
			foreach (Student st in students)
			{
				Console.WriteLine($"\n--- Sinh vien thu {i++} ---");
				st.Display();
			}
		}


		private static float CalculateAverageMark(List<Student> students)
		{
			float sum = 0;
			foreach (Student st in students)
			{
				sum += st.Mark;
			}
			return students.Count > 0 ? sum / students.Count : 0;
		}


		private static Student FindStudentByName(List<Student> students, string name)
		{
			foreach (Student st in students)
			{
				if (st.FullName.ToLower().Contains(name.ToLower()))
				{
					return st;
				}
			}
			return null;
		}
		public static void Main(string[] args)
		{
			Console.Write("Nhap vao so luong SV: ");
			int n = int.Parse(Console.ReadLine());

			// Nhập & xuất danh sách
			List<Student> DSSV = InputStudentList(n);
			DisplayStudentList(DSSV);

			// Điểm trung bình
			float avg = CalculateAverageMark(DSSV);
			Console.WriteLine($"\nDiem trung binh tat ca sinh vien: {avg}");

			// Tìm sinh viên
			Console.Write("\nNhap ten sinh vien can tim: ");
			string searchName = Console.ReadLine();

			Student svFound = FindStudentByName(DSSV, searchName);

			if (svFound != null)
			{
				Console.WriteLine("\n--- Thong tin sinh vien tim thay ---");
				svFound.Display();
			}
			else
			{
				Console.WriteLine("\nKhong tim thay sinh vien!");
			}

			Console.ReadLine();
		}
	}
}
