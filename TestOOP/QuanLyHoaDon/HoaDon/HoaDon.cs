﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TestOOP
{
    class HoaDon
    {
        private string _maHD;
        private KhachHang _khach;
        private CTHD[] _dsSP;
        private int _slCTHD;
        private DateTime _ngayHD;
        private string _ngayHDstring;
        private double _gia;
        public void Nhap()
        {
            bool ktMaHD;
            do
            {
                Console.Write("Ma hoa don: ");
                _maHD = Console.ReadLine();
                ktMaHD = Regex.Match(_maHD, @"^[a-zA-Z0-9]{3,10}$").Success;
                if (!ktMaHD)
                    Console.WriteLine("Ma hoadon chi bao gom chu hoac so, dai tu 3 den 10 ky tu. Xin vui long nhap lai!");
            } while (!ktMaHD);

            bool checkFormat;
            bool checkValid;
            do
            {
                Console.Write("Ngay lap hoa don: ");
                _ngayHDstring = Console.ReadLine();

                checkFormat = Regex.Match(_ngayHDstring, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$").Success;
                checkValid = DateTime.TryParseExact(_ngayHDstring, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _ngayHD);
                
                DateTime today = DateTime.Now;

                if (!checkFormat)
                    Console.WriteLine("Hay nhap ngay lap hoa don chinh xac theo format dd/mm/yyyy");
                else
                    if (!checkValid || _ngayHD > today)
                        Console.WriteLine("Ngay lap hoa don khong ton tai.");
            } while (!(checkFormat && checkValid));

            Console.WriteLine("Thong tin khach hang: ");
            _khach = new KhachHang();
            _khach.Nhap();

            Console.WriteLine("Nhap danh sach cac chi tiet hoa don: ");
            Console.Write("\tSo luong chi tiet trong danh sach cac chi tiet hoa don: ");

            string slTmp;
            bool ktSLCTHD;
            do
            {
                slTmp = Console.ReadLine();
                ktSLCTHD = Regex.Match(slTmp, @"^[0-9]{1,10}$").Success;
                if (!ktSLCTHD)
                    Console.WriteLine("Vui long nhap so luong la mot so nguyen");

            } while (!ktSLCTHD);
            _slCTHD = Int32.Parse(slTmp);

            _dsSP = new CTHD[_slCTHD];

            for (int i = 0; i < _slCTHD; i++)
            {
                Console.WriteLine("\tNhap chi tiet hoa don thu " + (i + 1));
                _dsSP[i] = new CTHD();
                _dsSP[i].Nhap();
            }
        }
        private void TinhHoaDon()
        {
            _gia = 0;
            for (int i = 0; i < _slCTHD; i++)
                _gia += _dsSP[i].ThanhTien();
        }
        public string XuatString()
        {
            TinhHoaDon();

            string res = "\n\tMa hoa don: " + _maHD + "\n\tNgay lap hoa don: " + _ngayHDstring + "\n\tTong tien: " + _gia.ToString() + "\n\n";

            res += _khach.XuatString();

            res += "Danh sach cac chi tiet hoa don:\n\n";
            for (int i = 0; i < _slCTHD; i++)
                res += _dsSP[i].XuatString() + "\n";
            return res;
        }
    }
}
