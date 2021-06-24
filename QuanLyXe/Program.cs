using System;

namespace QuanLyXe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chon chức năng bạn muốn sử dụng..!");
            int ChucNang = int.Parse(Console.ReadLine());
            switch(ChucNang)
            {
                case 1: // Tạo đối tượng xe
                    {
                        Xe xe1 = new Xe();
                        xe1.NhapThongTin();
                        xe1.XuatThongTin();
                        break;
                    }
                case 2: // Tạo đối tượng XeOto
                    {
                        XeOto oto1 = new XeOto();
                        oto1.NhapThongTin();
                        oto1.XuatThongTin();
                        break;
                    }
                case 3: // Tạo đối tượng XeTai
                    {
                        XeTai tai1 = new XeTai();
                        tai1.NhapThongTin();
                        tai1.XuatThongTin();
                        break;
                    }
                case 4: // Tạo đối tượng XeMay
                    {
                        XeMay may1 = new XeMay();
                        may1.NhapThongTin();
                        may1.XuatThongTin();
                        break;
                    }

            }
        }
    }
}
