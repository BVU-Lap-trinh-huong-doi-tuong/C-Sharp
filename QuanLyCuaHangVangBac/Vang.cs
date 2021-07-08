using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangVangBac
{
	class Vang : VangBac
	{
		int tuoiVang;
		string loai;
		int soLuong;

		public Vang() : base()
		{
			tuoiVang = 0;
			loai = "";
			soLuong = 0;
		}
		public Vang(string maSP, string tenSP, string hangSX, int donGia, int tuoiVang, string loai, int soLuong) : base(maSP, tenSP, hangSX, donGia)
		{
			this.tuoiVang = tuoiVang;
			this.loai = loai;
			this.soLuong = soLuong;
		}

		public void setTuoivang(int tuoiVang)
		{
			this.tuoiVang = tuoiVang;
		}

		public void setLoai(string loai)
		{
			this.loai = loai;
		}

		public void setSoluong(int soLuong)
		{
			this.soLuong = soLuong;
		}

		public int getTuoivang()
		{
			return tuoiVang;
		}

		public string getLoai()
		{
			return loai;
		}

		public int getSoluong()
		{
			return soLuong;
		}

		public void NhapThongTin()
		{
			Console.WriteLine("--------------------------------");
			base.NhapThongTin();
			Console.Write("Nhap Tuoi Vang: ");
			tuoiVang = int.Parse(Console.ReadLine());
			Console.Write("Nhap Loai: ");
			loai = Console.ReadLine();
			Console.Write("Nhap So Luong: ");
			soLuong = int.Parse(Console.ReadLine());
		}

		public void XuatThongTin()
		{
			base.XuatThongTin();
			Console.WriteLine("Tuoi Vang la: " + tuoiVang);
			Console.WriteLine("Loai Vang la: " + loai);
			Console.WriteLine("So luong la: " + soLuong);
			Console.WriteLine("--------------------------------");
		}
	}
}
