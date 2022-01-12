using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TestOOP
{
    class Customer
    {
        private string _id;
        private string _name;
        private string _phoneNumber;
        private string _address;
        //public static void NhapString(out string bienKieuString, string tenBien)
        //{
        //    do
        //    {
        //        bienKieuString = Console.ReadLine();
        //        if (bienKieuString == "")
        //            Console.WriteLine(tenBien + " khong duoc de trong. Vui long nhap lai");
        //    }
        //    while (bienKieuString == "");
        //}
        public Customer()
        {
            _id = "";
            _name = "";
            _phoneNumber = "";
            _address = "";
        }
        public void EnterInformation()
        {
            Console.Write("\tMa khach hang: ");
            GeneralFunctions.EnterId(ref _id, "khach hang", "\t");

            Console.Write("\tTen khach hang: ");
            GeneralFunctions.EnterString(out _name, "Ten khach hang", "\t");

            Console.Write("\tDia chi: ");
            GeneralFunctions.EnterString(out _address, "Dia chi", "\t");

            bool isValidPhoneNumber;
            do
            {
                Console.Write("\tSo dien thoai: ");
                _phoneNumber = Console.ReadLine();

                isValidPhoneNumber = Regex.Match(_phoneNumber, @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$").Success;
                if (!isValidPhoneNumber)
                    Console.WriteLine("\tSo dien thoai khong hop le. Vui long nhap so dien thoai dung!");

            } while (!isValidPhoneNumber);
        }
        public string ExportInformation()
        {
            return "Thong tin khach hang:\n\tMa khach hang: " + _id + "\n\tTen khach hang: " + _name + "\n\tDia chi: " + _address + "\n\tSo dien thoai: " + _phoneNumber + "\n\n";
        }
    }
}
