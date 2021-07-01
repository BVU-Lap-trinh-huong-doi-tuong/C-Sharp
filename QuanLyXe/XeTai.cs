using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class XeTai:Xe
    {
        int TaiTrong;
        public XeTai():base()
        {
            this.TaiTrong = 0;
        }
        public XeTai
(string SoXe, string MauXe, string NuocSanXuat, string HangSanXuat, int NamSanXuat, string SoBanhXe,
            int TaiTrong)
            : base(SoXe, MauXe, NuocSanXuat, HangSanXuat, NamSanXuat, SoBanhXe)
        {
            this.TaiTrong = TaiTrong;
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("TaiTrong la: ");
            TaiTrong = int.Parse(Console.ReadLine());
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("TaiTrong la: " + TaiTrong);
        }
        public void ThayDoiTaiTrong()
        {
            Console.WriteLine("TaiTrong cu la: " + this.TaiTrong);
            Console.WriteLine("Nhap TaiTrong moi: ");
            this.TaiTrong = int.Parse(Console.ReadLine());
        }
    }
}
