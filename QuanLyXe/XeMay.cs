using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class XeMay:Xe
    {
        // properties
        int PhanKhoi;
        // Constructor
        public XeMay():base()
        {
            this.PhanKhoi = 0;
        }
        public XeMay
(string SoXe, string MauXe, string NuocSanXuat, string HangSanXuat, int NamSanXuat, string SoBanhXe,
            int PhanKhoi)
            : base(SoXe, MauXe, NuocSanXuat, HangSanXuat, NamSanXuat, SoBanhXe)
        {
            this.PhanKhoi = PhanKhoi;
        }
        // Methods
        public void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("PhanKhoi la: ");
            PhanKhoi = int.Parse(Console.ReadLine());
        }
        public void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("PhanKhoi la: " + PhanKhoi);
        }
        public void CapNhatPhanKhoi()
        {
            Console.WriteLine("PhanKhoi cu la: " + this.PhanKhoi);
            Console.WriteLine("Nhap PhanKhoi moi: ");
            this.PhanKhoi = int.Parse(Console.ReadLine());
        }
        public void CapNhatPhanKhoi(int PhanKhoi)
        {
            this.PhanKhoi = PhanKhoi;
        }
    }
}
