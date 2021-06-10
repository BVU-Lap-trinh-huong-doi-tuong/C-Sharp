using System;
using System.Text;

namespace DiemHocSinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            HocSinh hs1 = new HocSinh();
            HocSinh hs2 = new HocSinh();
            hs1.Nhap();
            hs2.Nhap();
            float hs1dtb;
            hs1dtb = hs1.DiemTrungBinh();
            Console.WriteLine("Điểm Trung Bình của học sinh: " + hs1dtb);
            
            hs1.XepLoai(hs1dtb);
            // hs2.Nhap();
        }
    }
}
