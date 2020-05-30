using System;

namespace Csharp_with_Microsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my friends");
            string aF1 = "ThanhSon";
            string aF2 = "KhacThinh";
            Console.WriteLine($"My friends are {aF1} and {aF2}");
            Console.WriteLine($"the name {aF1} has {aF1.Length} words");
            Console.WriteLine($"the name {aF2} has {aF2.Length} words");

            string whatisL = "    She is NGOC    ";
            Console.WriteLine($"[{whatisL}]");
        }
    }
}
