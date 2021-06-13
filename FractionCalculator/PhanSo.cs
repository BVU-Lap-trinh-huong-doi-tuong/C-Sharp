﻿using System;
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

        public static int UocChungLonNhat(int a, int b) // Tìm ra ước chung sai rồi
        {
            if (a%b == 0)
            {
                return b;
            }
            else
            {
                return UocChungLonNhat(b, a%b);
            }
        }
        public void nhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
        }
        
        public void xuatPhanSo()
        {
            // Console.WriteLine("Phân số của bạn là:" );
            Console.WriteLine(TuSo);
            if (TuSo > 9 || MauSo > 9)
            {
                Console.WriteLine("---");
            }
            else
            {
                Console.WriteLine("--");
            }
            Console.WriteLine(MauSo);
        }
        public void xuatPhanSo(int a, int b)
        {
            Console.WriteLine(a);
            if (a > 9 || b > 9)
            {
                Console.WriteLine("---");
            }
            else
            {
                Console.WriteLine("--");
            }
            Console.WriteLine(b);
        }
        public int LayTuSo()
        {
            return TuSo;
        }
        public int LayMauSo()
        {
            return MauSo;
        }
        public void GanTuSo(int a) 
        {
            TuSo = a;
        }
        public void GanMauSo(int a)
        {
            MauSo = a;
        }
        public void NghichDao()
        {
            int TuSoDao = MauSo;
            int MauSoDao = TuSo;
            Console.WriteLine("Phân số nghịch đảo là: ");
            Console.WriteLine(TuSoDao);
            Console.WriteLine("--");
            Console.WriteLine(MauSoDao);
        }
        public void RutGon()
        {
            int UocChungLaGi;
            if (TuSo > MauSo)
            {
                UocChungLaGi = UocChungLonNhat(TuSo, MauSo);
            }
            else
            {
                UocChungLaGi = UocChungLonNhat(MauSo, TuSo); 
            }
            int TuSoSauRutGon = TuSo / UocChungLaGi;

            int MauSoSauRutGon = MauSo / UocChungLaGi;

            xuatPhanSo(TuSoSauRutGon, MauSoSauRutGon);
        }
        public void QuyDongMau(PhanSo psqdm)
        {
            int MauSoChung = this.LayMauSo() * psqdm.LayMauSo();
            PhanSo ps1m = new PhanSo();
            PhanSo ps2m = new PhanSo();
            ps2m.GanMauSo(MauSoChung);
            ps1m.GanMauSo(MauSoChung);
            ps1m.GanTuSo(this.LayTuSo() * psqdm.LayMauSo());
            ps2m.GanTuSo(psqdm.LayTuSo() * this.LayMauSo());
            ps1m.xuatPhanSo();
            ps2m.xuatPhanSo();
        }
        
        public void CongPhanSo(PhanSo ps)
        {
            int TuSoTong = this.LayTuSo()*ps.LayMauSo() + ps.LayTuSo()*this.LayMauSo();
            int MauSoTong = this.LayMauSo() * ps.LayMauSo();
            xuatPhanSo(TuSoTong, MauSoTong);
        }
        public void TruPhanSo()
        {

        }
        public void NhanPhanSo(PhanSo ps)
        {
            int TuSoTich = this.LayTuSo() * ps.LayTuSo();
            int MauSoTich = this.LayMauSo() * ps.LayMauSo();
            xuatPhanSo(TuSoTich, MauSoTich);
        }
        public void ChiaPhanSo()
        {
        }
        public bool SoSanhPhanSo()
        {
             return false;
        }
    }
}
