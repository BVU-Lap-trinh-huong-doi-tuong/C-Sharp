using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class Xe
    {
        protected string SoXe;
        protected string MauXe;
        protected string NuocSanXuat;
        protected string HangSanXuat;
        protected int NamSanXuat;
        protected string SoBanhXe;
        public Xe() // ()
        {
            this.SoXe = "";
            this.MauXe = "";
            this.NuocSanXuat = "";
            this.HangSanXuat = "";
            this.NamSanXuat = 0;
            this.SoBanhXe = "";
        }
        public Xe
(string SoXe, string MauXe, string NuocSanXuat, string HangSanXuat, int NamSanXuat, string SoBanhXe)
        { // (askjhdkhsakdnksan)
            this.SoXe = SoXe;
            this.MauXe = MauXe;
            this.NuocSanXuat = NuocSanXuat;
            this.HangSanXuat = HangSanXuat;
            this.SoBanhXe = SoBanhXe;
        }
        public void NhapThongTin()
        {
            Console.WriteLine("SoXe la: ");
            SoXe = Console.ReadLine();
            Console.WriteLine("MauXe la: ");
            MauXe = Console.ReadLine();
            Console.WriteLine("NuocSanXuat la: ");
            NuocSanXuat = Console.ReadLine();
            Console.WriteLine("HangSanXuat la: ");
            HangSanXuat = Console.ReadLine();
            Console.WriteLine("SoBanhXe la: ");
            SoBanhXe = Console.ReadLine();
        }
        public void XuatThongTin()
        {
            Console.WriteLine("SoXe la: " + SoXe);
            Console.WriteLine("MauXe la: " + MauXe);
            Console.WriteLine("NuocSanXuat la: " + NuocSanXuat);
            Console.WriteLine("HangSanXuat la: " + HangSanXuat);
            Console.WriteLine("SoBanhXe la: " + SoBanhXe);
        }
    }
}
