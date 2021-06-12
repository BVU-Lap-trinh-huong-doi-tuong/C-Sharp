using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemHocSinh
{
    class HocSinh
    {
        string HoTen;
        float DiemVan, DiemToan;

        public HocSinh() // Hàm khởi tạo
        {
            HoTen = "NoName";
            DiemVan = 0;
            DiemToan= 0;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhập tên sinh viên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập điểm Văn: ");
            DiemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm Toán: ");
            DiemToan = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write("Tên: " + HoTen);
            Console.Write("Điểm Văn: " + DiemVan);
            Console.Write("Điểm Toán: " + DiemToan);
        }
        public string LayTen()
        {
            return HoTen;
        }
        public float LayVan()
        {
            return DiemVan;
        }
        public float LayToan()
        {
            return DiemToan;
        }
        public void GanTen()
        {

        }
        public float DiemTrungBinh()
        {
            float diemTB = (DiemVan + DiemToan) / 2;
            return diemTB; // quyết định kiểu dữ liệu của phương thức..
        }
        public void XepLoai(float diemgiua)
        {
            if (diemgiua >= 8)
            {
                Console.Write("Sinh viên xếp loại: Giỏi");
            }
            else if (diemgiua >= 7)
            {
                Console.Write("Sinh viên xếp loại: Khá");
            }
            else if (diemgiua >= 5)
            {
                Console.Write("Sinh viên xếp loại: Trung Bình");
            }
            else
            {
                Console.Write("Sinh viên xếp loại: Yếu");
            }
        }
    }
}
