using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace TestOOP
{
    class QuanLyHoaDon
    {
        private int _slHD;
        private HoaDon[] _dsHD;
        public void Nhap()
        {
            Console.Clear();
            Console.Write("So luong hoa don muon nhap: ");
            string slTmp;
            bool ktSLHD;
            do
            {
                slTmp = Console.ReadLine();

                ktSLHD = Regex.Match(slTmp, @"^[0-9]{1,10}$").Success;
                if (!ktSLHD)
                    Console.WriteLine("Vui long nhap so luong la mot so nguyen");

            } while (!ktSLHD);
            _slHD = Int32.Parse(slTmp);

            _dsHD = new HoaDon[_slHD];

            for (int i=0;i<_slHD;i++)
            {
                Console.WriteLine("Nhap thong tin hoa don " + (i + 1));
                _dsHD[i] = new HoaDon();
                _dsHD[i].Nhap();
            }

            Console.WriteLine("Nhan phim bat ky de ve main menu");
            Console.ReadKey();
        }
        public void Xuat()
        {
            int currentHDIndex = 0;
            ConsoleKey key = ConsoleKey.A;
           
            while (key != ConsoleKey.E)
            {
                Console.Clear();
                if (_slHD ==0)
                {
                    Console.WriteLine("Khong co hoa don nao de hien thi. Nhan phim e de ve main menu");
                }
                else
                {
                    Console.WriteLine("Nhan phim -> hoac <- de di chuyen giua cac hoa don. Nhan phim e de ve main menu");
                    if (key == ConsoleKey.RightArrow)
                    {
                        if (currentHDIndex + 1 == _slHD)
                            currentHDIndex = 0;
                        else
                            currentHDIndex++;
                    }
                    if (key == ConsoleKey.LeftArrow)
                    {
                        if (currentHDIndex == 0)
                            currentHDIndex = _slHD - 1;
                        else
                            currentHDIndex--;
                    }

                    Console.WriteLine("Hoa don " + (currentHDIndex+1) + _dsHD[currentHDIndex].XuatString());
                }
                
                key = Console.ReadKey().Key;
            }
        }
        public char MainMenu()
        {
            Console.Clear();

            Console.WriteLine("Hay chon trong cac chuc nang sau");
            Console.WriteLine("1. Nhap hoa don\n2. Xuat hoa don ra man hinh\n3. Luu hoa don vao file text\ne. Dung chuong trinh");
            string key = Console.ReadLine();

            while (key != "1" && key != "2" && key != "3" && key != "e") 
            {
                Console.WriteLine("Khong ton tai chuc nang. Hay chon lai");
                key = Console.ReadLine();
            }
            return key[0];
        }
        public async Task Luu()
        {
            Console.Clear();
            string hoaDon = "";
            for (int i = 0; i < _slHD; i++)
            {
                hoaDon += _dsHD[i].XuatString();
                //chỉ là page break cho đẹp
                if (i < _slHD - 1)
                    hoaDon += "-------------------------------------------------------------------------------------------\n";
            }

            await File.WriteAllTextAsync("D:\\danh_sach_hoa_don.txt", hoaDon);
            Console.WriteLine("Hoa don da duoc luu vao file 'danh_sach_hoa_don' tai o D. Hay nhan phim bat ky de ve main menu");
            Console.ReadKey();
        }
        public void Run()
        {
            char key = 'a';
            while (key != 'e')
            {
                key = MainMenu();
                switch (key)
                {
                    case '1': Nhap(); break;
                    case '2': Xuat(); break;
                    case '3': Luu(); break;
                    default: return; break; 
                }
            }
        }
    }
}
