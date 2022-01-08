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
        public static void NhapString(out string bienKieuString, string tenBien)
        {
            do
            {
                bienKieuString = Console.ReadLine();
                if (bienKieuString == "")
                    Console.WriteLine(tenBien + " khong duoc de trong. Vui long nhap lai");
            }
            while (bienKieuString == "");
        }
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
            NhapString(out _ten, "Ten khach hang");

            Console.Write("\tDia chi: ");
            NhapString(out _diaChi, "Dia chi");

            bool ktSDT;
            do
            {
                Console.Write("\tSo dien thoai: ");
                _soDienThoai = Console.ReadLine();

                ktSDT = Regex.Match(_soDienThoai, @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$").Success;
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
