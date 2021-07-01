using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager
{
    class Human
    {
        // Thuộc tính
        protected string Ten;
        protected int Tuoi;
        protected string GioiTinh;
        protected string NgaySinh;

        // Phương thức
        public void setTen(string Ten)
        {
            this.Ten = Ten;
        }
        public string getTen()
        {
            return Ten;
        }
        public void setTuoi(int Tuoi)
        {
            this.Tuoi = Tuoi;
        }
        public int getTuoi()
        {
            return Tuoi;
        }
        public void setGioiTinh(string GioiTinh)
        {
            this.GioiTinh = GioiTinh;
        }
        public string getGioiTinh()
        {
            return GioiTinh;
        }
        public void setNgaySinh(string NgaySinh)
        {
            this.NgaySinh = NgaySinh;
        }
        public string getNgaySinh()
        {
            return NgaySinh;
        }
        public Human() // Phương thức khởi tạo
        {
            Ten = "";
            Tuoi = 0;
            GioiTinh = "";
            NgaySinh = "";
        }
       public Human(string Ten, int Tuoi, string GioiTinh, string NgaySinh) // Phương thức khởi tạo
        { 
            this.Ten = Ten;
            this.Tuoi = Tuoi;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
        }
        public virtual void NhapThongTin()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ten la: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Tuoi la: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Gioi tinh la: ");
            GioiTinh = (Console.ReadLine());
            Console.WriteLine("Ngay sinh la: ");
            NgaySinh = Console.ReadLine();
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ten la: " + Ten);
            Console.WriteLine("Tuoi la: " + Tuoi);
            Console.WriteLine("Gioi tinh la: " + GioiTinh);
            Console.WriteLine("Ngay sinh la: " + NgaySinh);
        }
    }
}
