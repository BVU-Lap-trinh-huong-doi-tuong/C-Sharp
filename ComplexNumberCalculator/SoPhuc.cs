using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberCalculator
{
    class SoPhuc
    {
        float PhanThuc, PhanAo;
        public float getThuc()
        {
            return PhanThuc;
        }
        public float getAo()
        {
            return PhanAo;
        }
        public void setThuc(float a)
        {
            PhanThuc = a;
        }
        public void setAo(float a)
        {
            PhanAo = a;
        }
        public void NhapSoPhuc(int ThuTu)
        {
            Console.WriteLine("Nhập phần thực của số phức thứ {0} của bạn (a)", ThuTu);
            setAo(float.Parse(Console.ReadLine()));
            Console.WriteLine("Nhập phần ảo của số phức thứ {0} của bạn (b)", ThuTu);
            setThuc(float.Parse(Console.ReadLine()));
        }
    }
}