using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Arr2D
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
        static void input2DArr(double[,] Arr, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Arr[{0},{1}]=", i, j);
                    Arr[i, j] = double.Parse(Console.ReadLine());
                }
        }
        static void output2DArr(double[,] Arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(Arr[i, j] + "  ");
                Console.WriteLine();
            }
        }
        static double sumArrEle(double[,] Arr, int n)
        {
            double tong = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    tong = tong + Arr[i, j];
            return tong;

        }
        static void CountPosEleK()
        {

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
                        Console.WriteLine(Arr[i, j] + " ");
                        tong = tong + Arr[i, j];
                    }
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
        }
    }
}
