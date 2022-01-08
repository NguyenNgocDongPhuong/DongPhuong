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
            bool ktMaKH;
            do
            {
                Console.Write("\t\t\tMa san pham: ");
                MaSP = Console.ReadLine();

                ktMaKH = Regex.Match(MaSP, @"^[a-zA-Z0-9]{3,10}$").Success;
                if (!ktMaKH)
                    Console.WriteLine("Ma san pham chi bao gom chu hoac so, dai tu 3 den 10 ky tu. Xin vui long nhap lai!");

            } while (!ktMaKH);

            Console.Write("\t\t\tTen san pham: ");
            TenSP = Console.ReadLine();

            Console.Write("\t\t\tNoi san xuat: ");
            NoiSX = Console.ReadLine();
        }
        public virtual string XuatString()
        {
            return "\n\t\tMa san pham: " + MaSP;
        }
        public abstract int Gia();
    }
}
