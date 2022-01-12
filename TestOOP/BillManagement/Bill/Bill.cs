using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TestOOP
{
    class Bill
    {
        private string _id;
        private Customer _customer;
        private BillDetail[] _items;
        private int _numberOfDifferentItem;
        private DateTime _date;
        private string _dateAsString;
        private double _totalCharge;
        public void EnterInformation()
        {
            Console.Write("Ma hoa don: ");
            GeneralFunctions.EnterId(ref _id, "hoa don");

            bool checkFormat;
            bool checkValid;
            do
            {
                Console.Write("Ngay lap hoa don: ");
                _dateAsString = Console.ReadLine();
                checkFormat = Regex.Match(_dateAsString, @"(([0-9]{2})\/([0-9]{2})\/([0-9]{4}))$").Success;
                checkValid = DateTime.TryParseExact(_dateAsString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _date) && _date<=DateTime.Today;
                
                if (!checkFormat)
                    Console.WriteLine("Hay nhap ngay lap hoa don chinh xac theo format dd/mm/yyyy");
                else
                    if (!checkValid)
                        Console.WriteLine("Ngay lap hoa don khong ton tai.");
            } while (!(checkFormat && checkValid));

            Console.WriteLine("Thong tin khach hang: ");
            _customer = new Customer();
            _customer.EnterInformation();

            Console.WriteLine("Nhap danh sach cac chi tiet hoa don: ");
            Console.Write("\tSo luong chi tiet trong danh sach cac chi tiet hoa don: ");
            GeneralFunctions.EnterPositiveInteger(ref _numberOfDifferentItem, "so luong", "\t");

            _items = new BillDetail[_numberOfDifferentItem];

            for (int i = 0; i < _numberOfDifferentItem; i++)
            {
                Console.WriteLine("\tNhap chi tiet hoa don thu " + (i + 1));
                _items[i] = new BillDetail();
                _items[i].EnterInformation();
            }
        }
        private void CalBill()
        {
            _totalCharge = 0;
            for (int i = 0; i < _numberOfDifferentItem; i++)
                _totalCharge += _items[i].money();
        }
        public string ExportInformation()
        {
            CalBill();

            string res = "\n\tMa hoa don: " + _id + "\n\tNgay lap hoa don: " + _dateAsString + "\n\tTong tien: " + _totalCharge.ToString() + "\n\n";

            res += _customer.ExportInformation();

            res += "Danh sach cac chi tiet hoa don:\n\n";
            for (int i = 0; i < _numberOfDifferentItem; i++)
                res += _items[i].ExportInformation() + "\n";
            return res;
        }
    }
}
