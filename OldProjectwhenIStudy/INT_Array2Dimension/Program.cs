using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INT_Array2Dimension
{
    class Program
    {
        static void inputIntNum(out int n)
        {
            Console.Write("Nhap vao so nguyen duong n: ");
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n > 200)
                    Console.WriteLine("Nhap lai so nguyen duong");
            } while (n <= 0);
        }
        static void input2DArr(int[,] Arr, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Arr[{0},{1}]=", i, j);
                    Arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }
        static void output2DArr(int[,] Arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(Arr[i, j] + "  ");
                Console.WriteLine();
            }
        }
        static int sumArrEle(int[,] Arr, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    tong = tong + Arr[i, j];
            return tong;

        }
        static void outputArrEle(int[,] Arr, int n)
        {
            int x;
            Console.WriteLine("Nhap x (de tim cac phan tu nho hon x): ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Cac phan tu nho hon x trong Arr la: ");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (Arr[i, j] > 1 && Arr[i, j] < x)
                        Console.Write(Arr[i, j] + ", ");
            Console.WriteLine();
        }
        static bool SoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }
        static void ListSoNguyenTo(int[,] Arr, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (SoNguyenTo(Arr[i, j]))
                    {
                        Console.Write(Arr[i, j] + " ");
                        tong = tong + Arr[i, j];
                    }
            Console.WriteLine();
            Console.WriteLine("Tong cua cac so nguyen to: " + tong);
        }
        static void DuongCheoChinh(int[,] Arr, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i == j) Console.WriteLine(Arr[i, j] + " ");

        }
        static void DuongCheoPhu(int[,] Arr, int n)
        {
            for (int i = 1; i < n; i++)
                for (int j = n; j < n; j--)
                    Console.WriteLine(Arr[i, j] + " ");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int n;
            inputIntNum(out n);

            int[,] integer_Array = new int[n, n];

            Console.WriteLine("Nhap Arr hai chieu");
            input2DArr(integer_Array, n);
            Console.WriteLine("Xuat Arr hai chieu");
            output2DArr(integer_Array, n);
            Console.WriteLine("Tong phan tu cua Arr la " + sumArrEle(integer_Array, n));
            Console.WriteLine("Xuat cac phan tu theo yeu cau");
            outputArrEle(integer_Array, n);
            Console.Write("Cac so nguyen to trong Arr: ");
            ListSoNguyenTo(integer_Array, n);
            Console.WriteLine("Cac phan tu tren duong cheo chinh la");
            DuongCheoChinh(integer_Array, n);
            Console.WriteLine("Cac phan tu tren duong cheo phu la");
            DuongCheoPhu(integer_Array, n);
            Console.ReadLine();
        }

    }
}
