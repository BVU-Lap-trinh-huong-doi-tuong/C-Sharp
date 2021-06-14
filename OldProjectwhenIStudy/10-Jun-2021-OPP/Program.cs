using System;
using System.Text;

namespace _10_Jun_2021_OPP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            SinhVien sv1 = new SinhVien();
            SinhVien sv2 = new SinhVien();
            sv1.NhapThongTinSV();
            sv2.NhapThongTinSV(); */

            SoNguyen so1 = new SoNguyen();
            Console.Write(so1.Xuat());
            //SoNguyen so2 = new SoNguyen();
            //SoNguyen so3 = new SoNguyen();
            //SoNguyen K = new SoNguyen();

            //so1.Nhap();
            // so2.Nhap();
            // so3.Nhap();

            // int T = so1.Cong(7);
            // Console.Write(T);

            /*SoNguyen sn1 = new SoNguyen();
            sn1.Nhap();
            K = so1.Cong(sn1);
            K.Xuat();
            Console.ReadKey();*/
        }
    }
}
