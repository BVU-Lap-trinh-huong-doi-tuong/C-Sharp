using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangVangBac
{
    class Bac : VangBac
    {
		string kieuBac;
		string loaiBac;
		int soLuong;

		public Bac() : base()
		{
			tuoiVang = 0;
			loaiVang = "";
			soLuong = 0;
		}
		public Vang(string maSP, string tenSP, string hangSX, int donGia,
			int tuoiVang, string loaiVang, int soLuong)
			: base(maSP, tenSP, hangSX, donGia)
		{
			this.tuoiVang = tuoiVang;
			this.loaiVang = loaiVang;
			this.soLuong = soLuong;
		}
		public virtual void setTuoivang(int tuoiVang)
		{
			this.tuoiVang = tuoiVang;
		}
		public virtual void setLoai(string loaiVang)
		{
			this.loaiVang = loaiVang;
		}
		public virtual void setSoluong(int soLuong)
		{
			this.soLuong = soLuong;
		}
		public virtual int getTuoivang()
		{
			return tuoiVang;
		}
		public virtual string getLoai()
		{
			return loaiVang;
		}
		public virtual int getSoluong()
		{
			return soLuong;
		}
		public override void NhapThongTin()
		{
			Console.WriteLine("--------------------------------");
			base.NhapThongTin();
			Console.Write("Nhap Tuoi Vang: ");
			tuoiVang = int.Parse(Console.ReadLine());
			Console.Write("Nhap Loai: ");
			loaiVang = Console.ReadLine();
			Console.Write("Nhap So Luong: ");
			soLuong = int.Parse(Console.ReadLine());
		}
		public override void XuatThongTin()
		{
			base.XuatThongTin();
			Console.WriteLine("Tuoi Vang la: " + tuoiVang);
			Console.WriteLine("Loai Vang la: " + loaiVang);
			Console.WriteLine("So luong la: " + soLuong);
			Console.WriteLine("--------------------------------");
		}
	}
}
