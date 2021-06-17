using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Math;

namespace SinhVienDH20LT
{
    static class MyMath
    {
        public static int SoMu(int a, int b)
        {
            int ketqua = a;
            int i = 1;
            while (i < b)
            {
                ketqua = ketqua * a;
                i++;
            }
            return ketqua;
        }
        public static int Tich(int a, int b)
        {
            return a * b;
        }
        //static double epsilon = 0.0001f;
        //public static double GiaTriTuyetDoi(double a)
        //{
        //    if (a > 0)
        //    {
        //        return a;
        //    }
        //    else
        //    {
        //        return -(a); // - với - thành +
        //    }
        //}
        //public static double CanBacHai(double a)
        //{
        //    double ketqua = 1;
        //    while (GiaTriTuyetDoi(ketqua * ketqua - a) / a >= epsilon)
        //    {
        //        ketqua = (a / ketqua - ketqua) / 2 + ketqua;
        //    }
        //    return ketqua;
        //}
        //static double Pp = 3.14;
        //public static double getPp() // DONE
        //{
        //    return Pp;
        //}
        //// Hình Tròn

        //public static double sCircle(double r ) // DONE Diện Tích | r là bán kính
        //{
        //    return getPp() * r * r;
        //}
        //public static double pCircle(double r) // DONE Chu Vi = P - perimeter
        //{
        //    return getPp() * r * 2;
        //}

        ////Hình Vuông
        //public static double sHinhVuong(double n) // DONE Diện Tích
        //{
        //    return n * n;
        //}
        //public static double pHinhVuong(double n) // DONE Chu Vi = P - perimeter
        //{
        //    return n * 2;
        //}

        //// Hình Chữ Nhật
        //public static double sHinhChuNhat(double d, double r) // DONE Diện Tích Hình Chữ Nhật
        //{
        //    return (d * r);
        //}
        //public static double pHinhChuNhat(double d, double r) // DONE Chu Vi = P - perimeter
        //{
        //    return (d + r) * 2;
        //}

        //// Tam giác - 3 cạnh
        //public static void ChieuCaoTG()
        //{

        //}
        public static double pTamGiacThuong(double a, double b, double c) // DONE Chu Vi = P - perimeter
        {
            return (a + b + c);
        }
        public static double sTamGiacThuong(double a, double b, double c) // Diện tích
        {
            // phải tìm h (chiều cao)
            // hoặc dùng công thức Heron

            double p = pTamGiacThuong(a, b, c) / 2; // p là nữa chu vi
            double trongCan = p * (p - a) * (p - b) * (p - c);
            return Math.Sqrt(trongCan);
        }

        // Sin Cos trong Tam giác vuông

    }
}
