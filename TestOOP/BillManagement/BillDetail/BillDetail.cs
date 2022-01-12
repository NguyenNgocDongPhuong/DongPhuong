using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class BillDetail
    {
        private ElectronicsDevices _product;
        private int _quantity;
        public void EnterInformation()
        {
            string loai; 
            Console.Write("\t\tChon loai thiet bi dien (1-May quat, 2-Maylanh): ");
            GeneralFunctions.EnterChoice(out loai, "12", "Hay nhap '1' tuong ung May quat hoac '2' tuong ung May lanh: ", "\t\t");

            //bool ktLoai;
            //do
            //{
            //    Console.Write("\t\tChon loai thiet bi dien (1-May quat, 2-Maylanh): ");
            //    GeneralFunctions.EnterChoice(out loai, "12", "Hay nhap '1' tuong ung May quat hoac '2' tuong ung May lanh ");
            //    loai = Console.ReadLine();

            //    ktLoai = (loai == "1" || loai == "2");
            //    if (!ktLoai)
            //        Console.WriteLine("Hay nhap '1' tuong ung May quat hoac '2' tuong ung May lanh ");

            //} while (!ktLoai);
            if (loai == "1")
            {
                string loaiMQ;
                Console.Write("\t\t\tChon loai may quat (1-May quat dung, 2-May quat hoi nuoc, 3-May quat sac dien): ");
                GeneralFunctions.EnterChoice(out loaiMQ, "123", "Hay nhap '1' hoac '2' hoac '3' theo menu: ", "\t\t\t");

                //bool ktLoaiMQ;
                //do
                //{
                //    Console.Write("\t\t\tChon loai may quat (1-May quat dung, 2-May quat hoi nuoc, 3-May quat sac dien): ");
                //    loaiMQ = Console.ReadLine();

                //    ktLoaiMQ = (loaiMQ == "1" || loaiMQ == "2" || loaiMQ == "3");
                //    if (!ktLoaiMQ)
                //        Console.WriteLine("Hay nhap '1' hoac '2' hoac '3' theo menu");

                //} while (!ktLoaiMQ);

                switch (loaiMQ)
                {
                    case "1": _product = new StandFan(); break;
                    case "2": _product = new SteamFan(); break;
                    case "3": _product = new BatteryFan(); break;
                }
            }
            else
            {
                string loaiML;
                Console.Write("\t\t\tChon loai may lanh (1-Mot chieu, 2-Hai chieu): ");
                GeneralFunctions.EnterChoice(out loaiML, "12", "Hay nhap '1' hoac '2' tuong ung so chieu cua may lanh: ", "\t\t\t");
                //bool ktLoaiML;
                //do
                //{
                //    Console.Write("\t\t\tChon loai may lanh (1-Mot chieu, 2-Hai chieu): ");
                //    loaiML = Console.ReadLine();

                //    ktLoaiML = (loaiML == "1" || loaiML == "2");
                //    if (!ktLoaiML)
                //        Console.WriteLine("Hay nhap '1' hoac '2' tuong ung so chieu cua may lanh");

                //} while (!ktLoaiML);
                if (loaiML == "1")
                    _product = new OneWayAirConditioner();
                else 
                    _product = new TwoWayAirConditioner();
            }

            _product.EnterInformation();

            Console.Write("\t\tSo luong ban ra: ");
            GeneralFunctions.EnterPositiveInteger(ref _quantity, "so luong", "\t\t");
        }
        public string ExportInformation()
        {
            string res;
            if (_product is Fan)
            {
                res = "\tMay quat: ";
            }
            else
                res = "\tMay lanh: ";
            res += _product.ExportInformation() + "\n\tSo luong ban ra: " + _quantity + "\n";
            return res;
        }
        public long money()
        {
            return _quantity * _product.Price;
        }
    }
}
