using System;

namespace Danh_gia_hoc_sinh_qua_diem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Diem;
            Console.Write("Nhap vao diem cua hoc sinh: ");
            Diem = int.Parse(Console.ReadLine());

            switch (Diem)
            {
                case 10:
                    {
                        Console.WriteLine("Ban la hoc sinh Xuat sac");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Ban la hoc sinh Xuat sac");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Ban la hoc sinh Gioi");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Ban la hoc sinh Kha");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Ban la hoc sinh Trung Binh");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Ban la hoc sinh Trung Binh");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Ban la hoc sinh Yeu");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ban la hoc sinh Yeu");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Ban la hoc sinh Yeu");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Ban la hoc sinh Yeu");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ban chua nhap diem");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
