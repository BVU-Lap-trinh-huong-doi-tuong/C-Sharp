using System;

namespace QuanLyXe
{
    class Program
    {
        static void Main(string[] args)
        {
            Xe[] listVehicle = new Xe[20];
            int VongLap = 1;
            int iSoXe = 0;
            while (VongLap < 50)
            {
                Console.WriteLine("Chon chức năng bạn muốn sử dụng..!");
                Console.WriteLine("1. Tạo đối tượng xe");
                Console.WriteLine("2. Tạo đối tượng XeOto");
                Console.WriteLine("3. Tạo đối tượng XeTai");
                Console.WriteLine("4. Tạo đối tượng XeMay");
                Console.WriteLine("5. Xuất Cả Danh Sách Xe");
                int ChucNang = int.Parse(Console.ReadLine());
                switch (ChucNang)
                {
                    case 1: // Tạo đối tượng xe
                        {
                            listVehicle[iSoXe] = new Xe();
                            listVehicle[iSoXe].NhapThongTin();
                            iSoXe++;
                            break;
                        }
                    case 2: // Tạo đối tượng XeOto
                        {
                            listVehicle[iSoXe] = new XeOto();
                            listVehicle[iSoXe].NhapThongTin();
                            iSoXe++;
                            break;
                        }
                    case 3: // Tạo đối tượng XeTai
                        {
                            listVehicle[iSoXe] = new XeTai();
                            listVehicle[iSoXe].NhapThongTin();
                            iSoXe++;
                            break;
                        }
                    case 4: // Tạo đối tượng XeMay
                        {
                            listVehicle[iSoXe] = new XeMay();
                            listVehicle[iSoXe].NhapThongTin();
                            iSoXe++;
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Danh sách xe gồm: ");
                            int k = 1;
                            while (k < iSoXe)
                            {
                                listVehicle[k].XuatThongTin();
                                k++;
                            }
                        }
                    default:
                        Console.WriteLine("Làm gì có chức năng đó..!");
                        break;
                }
                VongLap++;
            }

            //Xe xe2 = new XeOto();
            //xe2.NhapThongTin();
            //xe2.XuatThongTin();

            Xe[] DanhSachXe = new Xe[10]; // kiểu dữ liệu đặt cho Array sẽ được apply to all elements..
            //DanhSachXe[0] = new Xe();

            DanhSachXe[1] = new XeOto();
            DanhSachXe[2] = new XeMay();
            DanhSachXe[3] = new XeTai();

            Console.WriteLine("Nhap XeOto..");
            DanhSachXe[1].NhapThongTin();
            DanhSachXe[1].XuatThongTin();

            Console.WriteLine("Nhap XeMay..");
            DanhSachXe[2].NhapThongTin();
            DanhSachXe[2].XuatThongTin();

            Console.WriteLine("Nhap XeTai..");
            DanhSachXe[3].NhapThongTin();
            DanhSachXe[3].XuatThongTin();
        }
    }
}
