using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    abstract class ThietBiDien
    {
        private string _maSP;
        private string _tenSP;
        private string _noiSX;
        private double _gia;
        public virtual void Nhap()
        {
            bool ktMaKH;
            do
            {
                Console.Write("Ma san pham: ");
                _maSP = Console.ReadLine();
                ktMaKH = Regex.Match(_maSP, @"^[a-zA-Z0-9]{3,10}$").Success;
                if (!ktMaKH)
                    Console.WriteLine("Ma san pham chi bao gom chu hoac so, dai tu 3 den 10 ky tu. Xin vui long nhap lai!");
            } while (!ktMaKH);

            Console.Write("Ten san pham: ");
            _tenSP = Console.ReadLine();
            Console.Write("Noi san xuat: ");
            _noiSX = Console.ReadLine();
        }
        public virtual void Xuat()
        {

        }
        public abstract int Loai();
    }
}
