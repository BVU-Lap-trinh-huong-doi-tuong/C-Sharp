using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff Thinh = new Staff();
            Staff Khoi = new Staff();
            int i = 50;
            while (i < 50)
            {
                int SoNguyen;
                Console.WriteLine("1. Nhap Thong tin nhan vien");
                Console.WriteLine("2. Tang luong nhan vien");
                Console.WriteLine("3. Hien thong tin nhan vien");
                Console.WriteLine("4. Hien danh sach nhan vien");
                Console.WriteLine("5. Exit");
                Console.Write("Nhap chuc nang ban muon su dung: ");
                SoNguyen = int.Parse(Console.ReadLine());

                switch (SoNguyen)
                {
                    case 1:
                        {
                            Thinh.NhapInfoNV();
                            break;
                        }
                    case 2:
                        {
                            
                            Thinh.TangLuong();
                            break;
                        }
                    case 3:
                        {
                            Thinh.XuatInfoNV();
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
