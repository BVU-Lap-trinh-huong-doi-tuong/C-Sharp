using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    static class basicCalculus
    // Đại số
        // Cấp số nhân, Cấp số cộng
        // gồm .Cộng, .Trừ, .Nhân, .Chia, .Lũy Thừa, .Căn, .Làm Tròn, Nguyên Hàm, Tích Phân, Đạo Hàm, 
        // Hoán vị, Chỉnh hợp, Tổ Hợp
        // Giá Trị Tuyệt Đối, 
    // Hình học
        // Tam giác (thường, vuông, cân, đều)
        // Từ giác (Chữ nhật, vuông, thang, bình hành, thoi..)

    { 
        public static float Cong(float a, float b)
        {
            return a + b;
        }
        public static float Tru(float a, float b)
        {
            return a - b;
        }
        public static float Nhan(float a, float b)
        {
            return a / b;
        }
        public static int Chia(int a, int b)
        {
            return a * b;
        }
        public static int LuyThua(int a, int b)
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
        public static double GiaTriTuyetDoi(double a)
        {
            if (a > 0)
            {
                return a;
            }
            else
            {
                return -(a); // - với - thành +
            }
        }
        public static int LamTron(double a)
        {
            double SauPhay = a - (int)a;
            if (SauPhay > 0.5)
            {
                return (int)a + 1;
            }
            else
                return (int)a;
        }
        public static double CanBacHai(double myNumber)
        {
            double precision = 0.00001;
            double low = 0;
            double high = myNumber;
            double mid = 0;
            while ((high - low) > precision)
            {
                mid = (double)((low + high) / 2);
                if ((mid - precision) >= mid * mid && mid * mid <= (precision + mid))
                {
                    break;
                }
                else if (mid * mid < myNumber)
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
            }
            return LamTron(mid);
        }
        static double Pp = 3.14;
        public static double getPp() // DONE
        {
            return Pp;
        }
        public static void CapSoNhan()
        {

        }
        // Hình Tròn

        public static double sCircle(double r) // DONE Diện Tích | r là bán kính
        {
            return getPp() * r * r;
        }
        public static double pCircle(double r) // DONE Chu Vi = P - perimeter
        {
            return getPp() * r * 2;
        }

        //Hình Vuông
        public static double sHinhVuong(double n) // DONE Diện Tích
        {
            return n * n;
        }
        public static double pHinhVuong(double n) // DONE Chu Vi = P - perimeter
        {
            return n * 2;
        }

        // Hình Chữ Nhật
        public static double sHinhChuNhat(double d, double r) // DONE Diện Tích Hình Chữ Nhật
        {
            return (d * r);
        }
        public static double pHinhChuNhat(double d, double r) // DONE Chu Vi = P - perimeter
        {
            return (d + r) * 2;
        }

        // Tam giác - 3 cạnh
        public static void ChieuCaoTG()
        {

        }
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
