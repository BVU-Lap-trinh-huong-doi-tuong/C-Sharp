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
        public SoPhuc(float PhanThuc, float PhanAo)
        {
            Console.WriteLine("Tạo constructor với 2 tham số");
            this.PhanThuc = PhanThuc;
            this.PhanAo = PhanAo;
        }
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
        public void HienSoPhuc(int ThuTu)
        {
            Console.WriteLine("Số phức thứ {0} của bạn là {1} + {2}i", ThuTu, PhanThuc, PhanAo);
        }
    }
}