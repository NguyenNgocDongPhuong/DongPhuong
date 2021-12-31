using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TestOOP
{
    class HoaDon
    {
        private string _maHD;
        private string _maSP;
        private KhachHang _khach;
        private CTHD[] _dsSP;
        private int _slCTHD;
        private string _ngayHD;
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

            bool ktNgayHD;
            do
            {
                Console.Write("Ngay lap hoa don: ");
                _ngayHD = Console.ReadLine();
                ktNgayHD = Regex.Match(_ngayHD, @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$").Success;
                if (!ktNgayHD)
                    Console.WriteLine("Ngay lap hoa don khong hop le.");
            } while (!ktNgayHD);
            Console.WriteLine("Thong tin khach hang: ");
            _khach = new KhachHang();
            _khach.Nhap();
            Console.WriteLine("Nhap danh sach cac chi tiet hoa don: ");
            Console.Write("So luong chi tiet trong danh sach cac chi tiet hoa don: ");
            string slTmp;
            bool ktSLCTHD;
            do
            {
                Console.Write("So luong ban ra: ");
                slTmp = Console.ReadLine();
                ktSLCTHD = Regex.Match(slTmp, @"^[0-9]{1,10}$").Success;
                if (!ktSLCTHD)
                    Console.WriteLine("Vui long nhap so luong la mot so nguyen");

            } while (!ktSLCTHD);
            _slCTHD = Int32.Parse(slTmp);
            for (int i = 0; i < _slCTHD; i++)
            {
                Console.WriteLine("Nhap chi tiet hoa don thu " + (i + 1));
                _dsSP[i] = new CTHD();
                _dsSP[i].Nhap();
            }
        }
    }
}
