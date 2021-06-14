using System;

namespace _15_Mar_21_Chung_minh_tam_giac_deu_can_vuong_thuong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nguoi dung nhap Do dai cac canh a, b, c
            double a, b, c;
            Console.Write("Nhap do dai canh a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap do dai canh b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap do dai canh c: ");
            c = Convert.ToDouble(Console.ReadLine());

            double a2, b2, c2;
            a2 = a * a;
            b2 = b * b;
            c2 = c * c;

            if (a == b && b == c && c == a)
            {
                Console.WriteLine("Tam giac nay la tam giac deu");
            }
            else if (a == b|| b == c || c == a)
            {
                Console.WriteLine("Tam giac nay la tam giac can");
                }
            else if (a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2 )
                    {
                Console.WriteLine("Tam giac nay la tam giac vuong");
            }
            else { Console.WriteLine("Tam giac nay la tam giac thuong"); }
            Console.ReadKey();
        }
    }
}
