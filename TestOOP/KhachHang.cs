using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TestOOP
{
    class KhachHang
    {
        private string _maKH;
        private string _ten;
        private string _soDienThoai;
        private string _diaChi;
        public KhachHang()
        {
            _maKH = "";
            _ten = "";
            _soDienThoai = "";
            _diaChi = "";
        }
        public bool KtMaKH(string maKH)
        {
            string pattern;
            // allow letter or number, length between 3 to 10.
            pattern = @"^[a-zA-Z0-9]{3,10}$" ;

            Regex regex = new Regex(pattern);
            return regex.IsMatch(maKH);
        }
        public void Nhap()
        {
            bool ktMaKH;
            do
            {
                Console.Write("Ma khach hang: ");
                _maKH = Console.ReadLine();
                ktMaKH = KtMaKH(_maKH);
                if (!ktMaKH)
                    Console.WriteLine("Ma khach hang chi bao gom chu hoac so, dai tu 3 den 10 ky tu. Xin vui long nhap lai!");
            } while (!ktMaKH);
            bool ktTenKH;
            do
            {
                Console.Write("Ten khach hang: ");
                _ten = Console.ReadLine();
                ktTenKH = Regex.Match(_ten, @"^[a-zA-Z]{1,30}$").Success;
                if (!ktTenKH)
                    Console.WriteLine("Ten vua nhap khong hop le. Xin vui long nhap lai!");
            } while (!ktTenKH);
            Console.Write("Dia chi: ");
            _diaChi = Console.ReadLine();
            bool ktSDT;
            do
            {
                Console.Write("So dien thoai: ");
                _soDienThoai = Console.ReadLine();
                ktSDT = Regex.Match(_soDienThoai, @"^[0-9]{10,11}$").Success;
                if (!ktSDT)
                    Console.WriteLine("So dien thoai khong hop le. Vui long nhap so dien thoai dung!");

            } while (!ktSDT);
        }
        public void Xuat()
        {
            Console.WriteLine(_maKH + " " + _ten + " " + _diaChi + " " + _soDienThoai);
        }
    }
}
