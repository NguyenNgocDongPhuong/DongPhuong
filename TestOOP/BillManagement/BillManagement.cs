using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace TestOOP
{
    class BillManagement
    {
        private int _numberOfBill;
        private Bill[] _listOfBill;
        List<Bill> _bills;
        public BillManagement()
        {
            _numberOfBill = 0;
            _bills = new List<Bill>();
        }
        private void EnterInformation()
        {
            Console.Clear();
            int numberOfBillEntering = 0;
            Console.Write("So luong hoa don muon nhap: ");
            GeneralFunctions.EnterPositiveInteger(ref numberOfBillEntering, "so luong");

            for (int i=0;i<numberOfBillEntering;i++)
            {
                Console.WriteLine("Nhap thong tin hoa don " + (i + _numberOfBill + 1));
                Bill bill = new Bill();
                bill.EnterInformation();
                _bills.Add(bill);
            }

            _numberOfBill += numberOfBillEntering;
            Console.WriteLine("Nhan phim bat ky de ve main menu");
            Console.ReadKey();
        }
        private void PrintToConsoleScreen()
        {
            int currentBillIndex = -1;
            ConsoleKey key = ConsoleKey.A;
           
            while (key != ConsoleKey.E)
            {
                Console.Clear();
                if (_numberOfBill ==0)
                {
                    Console.WriteLine("Khong co hoa don nao de hien thi. Nhan phim e de ve main menu");
                }
                else
                {
                    if (currentBillIndex == -1)
                    {
                        Console.WriteLine("Co tong cong {0} hoa don trong he thong. Ban muon xem hoa don thu may (1-{0})", _numberOfBill);
                        Console.WriteLine("Hoa don thu: ");
                        GeneralFunctions.EnterPositiveIntegerWithRange(ref currentBillIndex, "thu tu hoa don", _numberOfBill);
                        currentBillIndex--;
                    }
                    
                    Console.WriteLine("Nhan phim -> hoac <- de di chuyen giua cac hoa don. Nhan phim e de ve main menu");
                    if (key == ConsoleKey.RightArrow)
                    {
                        if (currentBillIndex + 1 == _numberOfBill)
                            currentBillIndex = 0;
                        else
                            currentBillIndex++;
                    }
                    if (key == ConsoleKey.LeftArrow)
                    {
                        if (currentBillIndex == 0)
                            currentBillIndex = _numberOfBill - 1;
                        else
                            currentBillIndex--;
                    }

                    Console.WriteLine("Hoa don " + (currentBillIndex+1) + _bills[currentBillIndex].ExportInformation());
                }
                
                key = Console.ReadKey().Key;
            }
        }
        public char MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hãy chọn trong các chức năng sau:");
            Console.WriteLine("1. Nhap hoa don\n2. Xuat hoa don ra man hinh\n3. Luu hoa don vao file text\ne. Dung chuong trinh");
            
            string key;
            GeneralFunctions.EnterChoice(out key, "123e", "Khong ton tai chuc nang. Hay chon lai: ");
            return key[0];
        }
        private async Task ExportToFileText()
        {
            Console.Clear();
            string Bill = "";
            for (int i = 0; i < _numberOfBill; i++)
            {
                Bill += "Hoa don " + (i + 1) + _bills[i].ExportInformation();
                //chỉ là page break cho đẹp
                if (i < _numberOfBill - 1)
                    Bill += "-------------------------------------------------------------------------------------------\n";
            }

            await File.WriteAllTextAsync(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt", Bill);
            Console.WriteLine("Hoa don da duoc luu vao file 'danh_sach_hoa_don' tai Desktop. Hay nhan phim bat ky de ve main menu");
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
                    case '1': EnterInformation(); break;
                    case '2': PrintToConsoleScreen(); break;
                    case '3': ExportToFileText(); break;
                    default: return; break; 
                }
            }
        }
    }
}
