using System;

namespace Tinh_tien_dien_voi_du_lieu_vao_la_chi_so_moi_va_chi_so_cu
{
    class Program
    {
        static void Main(string[] args)
        {
            int Moi, Cu;
            int T1 = 1400; // Luong KW tu 1 -> 100
            int T2 = 1600; // Luong KW tu 101 -> 150
            int T3 = 1800; // Luong KW tu 151 -> 200
            int T4 = 2200; // Luong KW tu 201 -> 300
            int T5 = 3000; // Luong KW tu >300
            

            Console.Write("Nhap chi so dien cu: ");
            Cu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chi so dien moi: ");
            Moi = Convert.ToInt32(Console.ReadLine());

            int LuongDienTieuThu = Moi - Cu;
            int TienDien;
            Console.WriteLine("Vay Luong dien tieu thu trong thang cua ban la: " + LuongDienTieuThu);

             
            if (LuongDienTieuThu < 100)
            {
                   TienDien = LuongDienTieuThu * T1;
                    Console.WriteLine("Tien dien thang nay la: " + TienDien);
            }
                else if (LuongDienTieuThu > 100 && LuongDienTieuThu < 50)
                {
                    TienDien = 100 * T1 + (150 - 100) * T2;
                    Console.WriteLine("Tien dien thang nay la: " + TienDien);
                }
                    else if (LuongDienTieuThu > 150 && LuongDienTieuThu < 200)
                    {
                        TienDien = 100 * T1 + 50 * T2 + (200 - 150) * T3;
                        Console.WriteLine("Tien dien thang nay la: " + TienDien);
                    }
                        else if (LuongDienTieuThu > 200 && LuongDienTieuThu < 300)
                        {
                            TienDien = 100 * T1 + 50 * T2 + 50 * T3 + (300 - 200) * T4;
                            Console.WriteLine("Tien dien thang nay la: " + TienDien);
                        }
                            else if (LuongDienTieuThu > 300)
                            {
                                TienDien = 100 * T1 + 50 * T2 + 50 * T3 + 100 * T4 + (LuongDienTieuThu - 300) * T5;
                                Console.WriteLine("Tien dien thang nay la: " + TienDien);
                            }
        }
    }
}
