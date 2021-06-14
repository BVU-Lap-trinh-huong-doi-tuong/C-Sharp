using System;

namespace BT1
{
    class SinhVien
    {
        int MaSinhVien;
        string TenSinhVien;
        int Tuoi;
        public void NhapThongTinSV()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSinhVien = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten sinh vien: ");
            TenSinhVien = Console.ReadLine();
            Console.Write("Nhap tuoi sinh vien: ");
            Tuoi = int.Parse(Console.ReadLine());
        }
        public void XuatThongTinSV()
        {
            Console.WriteLine("Ma so sinh vien: " + MaSinhVien);
            Console.WriteLine("Ten sinh vien: " + TenSinhVien);
            Console.WriteLine("Tuoi cua sinh vien: " + Tuoi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SinhVien Thinh = new SinhVien();
            SinhVien Khoi = new SinhVien();
            Thinh.NhapThongTinSV();
            Console.WriteLine("-----------------");
            Thinh.XuatThongTinSV();
            Console.ReadKey();
        }
    }
}
