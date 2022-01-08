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
        public void Nhap()
        {
            Console.Write("\tMa khach hang: ");
            HoaDon.NhapMa(ref _maKH, "khach hang");

            Console.Write("\tTen khach hang: ");
             _ten = Console.ReadLine();

            Console.Write("\tDia chi: ");
            _diaChi = Console.ReadLine();

            bool ktSDT;
            do
            {
                Console.Write("\tSo dien thoai: ");
                _soDienThoai = Console.ReadLine();

                ktSDT = Regex.Match(_soDienThoai, @"^[0-9]{9,11}$").Success;
                if (!ktSDT)
                    Console.WriteLine("So dien thoai khong hop le. Vui long nhap so dien thoai dung!");

            } while (!ktSDT);
        }
        public string XuatString()
        {
            return "Thong tin khach hang:\n\tMa khach hang: " + _maKH + "\n\tTen khach hang: " + _ten + "\n\tDia chi: " + _diaChi + "\n\tSo dien thoai: " + _soDienThoai + "\n\n";
        }
    }
}
