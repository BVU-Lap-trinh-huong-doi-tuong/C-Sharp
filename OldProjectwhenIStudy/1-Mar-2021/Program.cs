using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mar_2021
{
    class Program
    {
        static void Main(string[] args)
        {   // this is a comment
            Console.WriteLine("Hello DH20LT");

            int dauTien = 10;
            Console.WriteLine(dauTien);
            Console.ReadLine();

            int x1,x2,x3,x4;
            Console.WriteLine("Nhap a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b :");
            int b = Convert.ToInt32(Console.ReadLine());
            
            x1 = a^2 + b^2;
            x2 = 2 * (a - b + (3 * a * b) );
            x3 = a^2 + b ^ 2  - 2*a*b;
            x4 = a^3 - 3*a*b + 3 * b^2 * a + b^3;

            Console.WriteLine("Gia tri cau a: " + x1);
            Console.WriteLine("Gia tri cau b: " + x2);
            Console.WriteLine("Gia tri cau c: " + x3);
            Console.WriteLine("Gia tri cau d: " + x4);
            
            Console.ReadLine();


        }
    }
}
