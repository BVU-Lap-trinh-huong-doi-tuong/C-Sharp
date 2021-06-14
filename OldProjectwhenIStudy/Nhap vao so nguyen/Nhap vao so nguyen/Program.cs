using System;

namespace Nhap_vao_so_nguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            int SoNguyen;
            Console.Write("Nhap vao so nguyen: ");
            SoNguyen = int.Parse(Console.ReadLine());

            switch (SoNguyen)
            {
                case 1:
                    {
                        Console.WriteLine("Ban vua nhap vao so 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Ban vua nhap vao so 2");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ban vua nhap vao so 3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ban vua nhap mot so khac 1, 2, 3");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
