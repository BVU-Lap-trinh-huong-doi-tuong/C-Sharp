using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class PhanSo
    {
        int TuSo;
        int MauSo;
        void NhieuPhanSo()
        {

        }
        public void NhapPhanSo()
        {
            Console.Write("Nhap tu so:");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            MauSo = int.Parse(Console.ReadLine());
        }
        void XuatPhanSo()
        {
            Console.Write("Tu so la: " + TuSo);
            Console.Write("Mau so la: " + MauSo);
        }
        int LayTuSo()
        {
            return TuSo;
        }
        int LayMauSo()
        {
            return MauSo;
        }
        void GanTuSo() {TuSo = int.Parse(Console.ReadLine());}
        void GanMauSo(){MauSo = int.Parse(Console.ReadLine());}
        void NghichDao()
        {
            TuSo = MauSo;
            MauSo = TuSo;
            Console.WriteLine("Phan so nghich dao la: ");
            Console.WriteLine(TuSo);
            Console.WriteLine("--");
            Console.WriteLine(MauSo);
        }
        void RutGon()
        {
            if (MauSo > TuSo)
            {
                if (MauSo % TuSo != 0)
                {
                    MauSo = MauSo / TuSo;
                }
                else
                {

                }
            }
        }
        void CongPhanSo()
        {
            int TuSo2;
            int MauSo2;
            Console.Write("Nhap tu so cua phan so ban muon cong them: ");
            TuSo2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so cua phan so ban muon cong them: ");
            MauSo2 = int.Parse(Console.ReadLine());
            //Quy dong mau va cong
            if ( MauSo == MauSo2)
            {
                TuSo = TuSo + TuSo2;
                MauSo = MauSo + MauSo2;
            }
            else
            {
                MauSo = MauSo * MauSo2;
                TuSo = TuSo * MauSo2 + MauSo * TuSo2;
            }
            Console.WriteLine("Phan so moi la: " + TuSo + "/" + MauSo);
        }
        void TruPhanSo()
        {

        }
        void NhanPhanSo()
        {

        }
        void ChiaPhanSo()
        {

        }
        bool SoSanhPhanSo()
        {
             return false;
        }
    }
}
