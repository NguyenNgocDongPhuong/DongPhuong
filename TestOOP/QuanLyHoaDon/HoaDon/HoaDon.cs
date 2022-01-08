using System;
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
        public static void NhapSoNguyenDuong(ref int sl, string tenBien)
        {
            string slTmp;
            bool ktSL;
            do
            {
                slTmp = Console.ReadLine();
                while (slTmp.Length>1 && slTmp[0] == '0')
                {
                    slTmp = slTmp.Substring(1);
                }
                ktSL = Regex.Match(slTmp, @"^[0-9]{1,10}$").Success && slTmp!="0";
                if (ktSL == false)
                    Console.WriteLine("Vui long nhap " + tenBien + " la mot so nguyen duong");

            } while (ktSL == false);
            sl = Int32.Parse(slTmp);
        }
        public static void NhapMa(ref string ma, string tenBien)
        {
            bool ktMaHD;
            do
            {
                ma = Console.ReadLine();
                ktMaHD = Regex.Match(ma, @"^[a-zA-Z0-9]{3,10}$").Success;
                if (!ktMaHD)
                    Console.WriteLine("Ma " + tenBien + " chi bao gom chu hoac so, dai tu 3 den 10 ky tu. Xin vui long nhap lai!");
            } while (!ktMaHD);
        }
        public void Nhap()
        {
            Console.Write("Ma hoa don: ");
            NhapMa(ref _maHD, "hoa don");

            bool checkFormat;
            bool checkValid;
            do
            {
                Console.Write("Ngay lap hoa don: ");
                _ngayHDstring = Console.ReadLine();
                checkFormat = Regex.Match(_ngayHDstring, @"(([0-9]{2})\/([0-9]{2})\/([0-9]{4}))$").Success;
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
            NhapSoNguyenDuong(ref _slCTHD, "so luong");

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
