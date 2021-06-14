using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager
{
    class Staff
    {
        string TenNV;
        int MaNV;
        string ChucVu;
        int Luong;
        public void NhapInfoNV()
        {
            Console.Write("Nhap ma nhan vien: ");
            MaNV = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten nhan vien: ");
            TenNV = Console.ReadLine();
            Console.Write("Nhap chuc vu nhan vien: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap luong cua nhan vien: ");
            Luong = int.Parse(Console.ReadLine());
        }
        public void XuatInfoNV()
        {
            Console.WriteLine("Ma so nhan vien: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + TenNV);
            Console.WriteLine("Chuc vu cua nhan vien: " + ChucVu);
            Console.WriteLine("Luong cua nhan vien: " + Luong);
        }
        public void TangLuong()
        {
            if (ChucVu == "TruongPhong")
            {
                Luong = Luong + Luong * 20 / 100;
            }
            if (ChucVu == "PhoPhong")
            {
                Luong = Luong + Luong * 10 / 100;
            }
            
        }
    }
}
