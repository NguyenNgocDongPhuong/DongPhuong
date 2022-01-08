using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    abstract class ThietBiDien
    {
        protected string MaSP;
        protected string TenSP;
        protected string NoiSX;
        public virtual void Nhap()
        {
            Console.Write("\t\t\tMa san pham: ");
            HoaDon.NhapMa(ref MaSP, "san pham");

            Console.Write("\t\t\tTen san pham: ");
            KhachHang.NhapString(out TenSP, "Ten san pham");

            Console.Write("\t\t\tNoi san xuat: ");
            KhachHang.NhapString(out NoiSX, "Noi san xuat");
        }
        public virtual string XuatString()
        {
            return "\n\t\tMa san pham: " + MaSP;
        }
        public abstract int Gia();
    }
}
