using System;


namespace _15_Mar_Bai2_Giai_pt_Bac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nguoi dung Nhap cac he so a, b, c
            double a, b, c;
            Console.Write("Nhap He So a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap He So b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap He So c: ");
            c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4*a*c;
            double x1, x2, xKep;

            // Pt co 2 nghiem
            if (delta > 0)
                {
                Console.WriteLine("Ta co delta = " + delta + "\n" + "Vi delta > 0, nen Phuong trinh co 2 nghiem phan biet la: ");
                x1 = (-b - Math.Sqrt(delta) / (2 * a));
                x2 = (-b + Math.Sqrt(delta) / (2 * a));
                Console.WriteLine(x1);
                Console.WriteLine(x2);
                
             }
            // Pt co nghiem kep
            else if (delta == 0)
                {
                Console.WriteLine("Ta co delta = " + delta + "\n" + "Nen Phuong trinh co nghiem kep la: ");
                    xKep = -b / (2 * a);
                Console.WriteLine(xKep);
            }
            // Pt vo nghiem
            else {
                Console.WriteLine("Ta co delta = " + delta + "\n" + "Vi delta < 0, Nen Phuong trinh vo nghiem");
             };
            Console.ReadKey();
        }
    }
}
