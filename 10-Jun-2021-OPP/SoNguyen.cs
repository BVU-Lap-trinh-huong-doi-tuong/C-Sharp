using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Jun_2021_OPP
{
    class SoNguyen
    {
        int x;
        public SoNguyen()
        {
            x = 10;
        }
        public void Nhap()
        {
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
        }

        public int Xuat()
        {
            return x;
        }

        public int Cong()
        {
            return this.x + x;
        }
        public SoNguyen Cong(SoNguyen sn1)
        {
            SoNguyen tam = new SoNguyen();
            tam.x = this.x + sn1.x;
            return tam;
        }
    }
}
