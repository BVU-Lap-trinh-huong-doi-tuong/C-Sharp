using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class Program
    {
        static bool YesNo()
        {
            if (Console.ReadLine() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void DiTiep()
        {
            Console.WriteLine("Bạn có muốn tiếp tục dùng chức năng khác? ( nhấn 1 và Enter để tiếp tục)");
            bool TiepTuc = YesNo();
            
            if (TiepTuc == true)
            {
                Console.Clear();
            }
        }
        static int UocChungLonNhat()
        {
            int UCLN;
            return UCLN;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            int VongLap = 1;
            while (VongLap < 100)
            {
                Console.WriteLine("Máy tình Phân số Đơn Giản ({0})",VongLap);
                Console.WriteLine("   1. Nhập phân số của bạn");
                Console.WriteLine("   2. Hiện các phân số mà tôi vừa nhập");
                Console.WriteLine("   3. Rút gọn phân số");
                Console.WriteLine("   4. Quy đồng mẫu hai phân số");
                Console.WriteLine("   5. Cộng hai phân số");
                Console.WriteLine("   6. Trừ hai phân số");
                Console.WriteLine("   7. Nhân hai phân số");
                Console.WriteLine("   8. Chia hai phân số");
                Console.Write("Chọn chức năng bạn muốn sử dụng..! --> ");
                int ChucNang = int.Parse(Console.ReadLine());
                switch(ChucNang){
                    case 1: //Nhập phân số của bạn
                        {
                            ps1.nhapPhanSo();
                            Console.Write("Bạn có muốn nhập phân số thứ hai không? (Phím 1 và Enter để đồng ý) --> ");
                            if (YesNo() == true)
                            {
                                ps2.nhapPhanSo();
                            }
                            Console.Clear();
                            break;
                        }
                    case 2: //Hiện các phân số mà tôi vừa nhập
                        {
                            ps1.xuatPhanSo();
                            Console.WriteLine("------------");
                            ps2.xuatPhanSo();
                            DiTiep();
                            break;
                        }
                    case 3: // Rút gọn phân sớ
                        {

                        }
                    case 4: // Quy đồng mẩu hai phân số
                        {
                            int MauSoChung = ps1.MauSo * ps2.MauSo;
                            int TuSo1 = ps1.LayTuSo() * ps2.LayMauSo();
                            int TuSo2 = ps2.LayTuSo() * ps1.LayMauSo();
                            PhanSo ps1m = new PhanSo();
                            PhanSo ps2m = new PhanSo();
                            ps1.xuatPhanSo();
                            ps2.xuatPhanSo();
                            break;
                        }
                    default:
                        Console.Write("Bạn chọn mã chức năng không tồn tại..!");
                        break;
                }
                
                VongLap++;
            }
            Console.ReadKey();
        }
    }
}
