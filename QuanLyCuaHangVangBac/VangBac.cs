using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangVangBac
{
	class VangBac
	{
		protected string maSP;
		protected string tenSP;
		protected string hangSX;
		protected int donGia; // Đơn Giá

		public VangBac()
		{//Ham Khoi Tao
			maSP = "";
			tenSP = "";
			hangSX = "";
			donGia = 0;
		}
		public VangBac(string maSP, string tenSP, string hangSX, int donGia)
		{
			this.maSP = maSP;
			this.tenSP = tenSP;
			this.hangSX = hangSX;
			this.donGia = donGia;
		}
		public void setMaSP(string maSP)
		{
			this.maSP = maSP;
		}
		public void setTenSP(string tenSP)
		{
			this.tenSP = tenSP;
		}
		public void setHangSX(string hangSX)
		{
			this.hangSX = hangSX;
		}
		public void setDonGia(int donGia)
		{
			this.donGia = donGia;
		}
		public string getMasp()
		{
			return maSP;
		}
		public string getTensp()
		{
			return tenSP;
		}
		public string getHangsx()
		{
			return hangSX;
		}
		public int getDongia()
		{
			return donGia;
		}
		public void NhapThongTin()
		{
			Console.Write("Nhap ma san pham: ");
			maSP = Console.ReadLine();
			Console.Write("Nhap ma Ten san pham: ");
			tenSP = Console.ReadLine();
			Console.Write("Nhap hang san xuat: ");
			hangSX = Console.ReadLine();
			Console.Write("Nhap dong gia: ");
			donGia = int.Parse(Console.ReadLine());
		}
		public void XuatThongTin()
		{
			Console.WriteLine("--------------------------------");
			Console.WriteLine("Nhap ma san pham: " + maSP);
			Console.WriteLine("Nhap ten san pham: " + tenSP);
			Console.WriteLine("Nhap hang san xuat: " + hangSX);
			Console.WriteLine("Nhap don gia: " + donGia);
		}
	}
}	
