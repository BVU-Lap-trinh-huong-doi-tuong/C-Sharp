using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Jun_2021_OPP
{
    class SinhVien
    {
        int MSV;
        string Name;
        int Tuoi;

        public void NhapThongTinSV()
        {
            Console.Write("Nhập mã số sinh viên: ");
            MSV = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên sinh viên: ");
            Name = Console.ReadLine();
            Console.Write("Nhập tuổi của sinh viên: ");
            Tuoi = int.Parse(Console.ReadLine());
        }
        
        public SinhVien MaxTuoi(SinhVien sv1)
        {
            /*Console.WriteLine("So sánh sinh viên này với một sinh viên khác được nhập vào");
            if (this.Tuoi > Tuoi)
            {

            }*/
            return this;
        }
        public SinhVien MaxTuoi(SinhVien sv1, SinhVien sv2) // hai nguoi
        {
            /* if ( int x > 1 )
            {
                Console.WriteLine("Sinh vien có số tuổi lớn nhất là: {0} (với tuổi là {1})");
            }
            else
            {
                Console.WriteLine("Sinh vien có số tuổi lớn nhất là: {0} (với tuổi là {1})");
            }*/
            return this;
        }
        public SinhVien MaxTuoi(SinhVien sv1, SinhVien sv2, SinhVien sv3)
        {

            return this;
        }

        public void XuatInfoSV()
        {
            Console.WriteLine("Mã số sinh viên: ", MSV);
            Console.WriteLine("Tên sinh viên: ", Name);
            Console.WriteLine("Tuổi sinh viên: ", Tuoi);
        }
    }
}
