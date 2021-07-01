using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager
{
    class Customer:Human
    {
        string LoaiKhachHang; 
        string MaKhachHang; //Mã khách hàng

        public Customer() : base()
        {
            LoaiKhachHang = "";
            MaKhachHang = "";
        }
        public Customer(string Ten, int Tuoi, string GioiTinh, string NgaySinh, int PhanLoai,
            string LoaiKhacHang, string MaKhachHang)
            : base (Ten, Tuoi, GioiTinh, NgaySinh, PhanLoai)
        {
            this.LoaiKhachHang = LoaiKhachHang;
            this.MaKhachHang = MaKhachHang;
        }
        public void setMaKH(string MaKhachHang)
        {
            this.MaKhachHang = MaKhachHang;
        }
        public string getMaKH()
        {
            return MaKhachHang;
        }
        public void setLoaiKH(string LoaiKhachHang)
        {
            this.LoaiKhachHang = LoaiKhachHang;
        }
        public string getLoaiKH()
        {
            return LoaiKhachHang;
        }

        public override void NhapThongTin()
        {
            Console.WriteLine("------------------------------");
            base.NhapThongTin();
            Console.Write("Loai Khach Hang:  ");
            LoaiKhachHang = (Console.ReadLine());
            Console.Write("Ma Khach Hang:  ");
            MaKhachHang = Console.ReadLine();
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Loai Khach Hang: " + LoaiKhachHang);
            Console.WriteLine("Ma Khach Hang: " + MaKhachHang);
            Console.WriteLine("------------------------------");
        }
    }
}
