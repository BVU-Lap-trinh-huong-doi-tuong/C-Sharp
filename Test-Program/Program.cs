using System;

namespace Test_Program
{
    static class MyMath
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
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
        Console.WriteLine("S la:" + sTamGiacThuong(5.0, 3.0, 2.0));
        Console.ReadKey();
        }
    }
}
