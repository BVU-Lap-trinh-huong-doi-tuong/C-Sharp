
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class XeOto:Xe
    {
        int SoChoNgoi;
        string LoaiXe;
        public XeOto():base()
        {
            this.SoChoNgoi = 0;
            this.LoaiXe = "";
        }
        public XeOto
(string SoXe, string MauXe, string NuocSanXuat, string HangSanXuat, int NamSanXuat, string SoBanhXe,
            int SoChoNgoi, string LoaiXe)
            : base (SoXe, MauXe, NuocSanXuat, HangSanXuat, NamSanXuat, SoBanhXe)
        {
            this.SoChoNgoi = SoChoNgoi;
            this.LoaiXe = LoaiXe;
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("SoChoNgoi la: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.WriteLine("LoaiXe la: ");
            LoaiXe = Console.ReadLine();
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("SoChoNgoi la: " + SoChoNgoi);
            Console.WriteLine("LoaiXe la: " + LoaiXe);
        }
        public void ThayDoiSoChoNgoi(int SoChoNgoi)
        {
            this.SoChoNgoi = SoChoNgoi;
        }
        public void CapNhatLoaiXe(string LoaiXe)
        {
            this.LoaiXe = LoaiXe;
        }
    }
}
