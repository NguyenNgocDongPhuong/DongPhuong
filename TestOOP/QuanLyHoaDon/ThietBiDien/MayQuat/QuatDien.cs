using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class QuatDien:MayQuat
    {
        protected int _dungLuongPin;
        public override void Nhap()
        {
            base.Nhap();
            string dlString;
            bool ktDL;
            do
            {
                Console.Write("\t\t\tDung luong pin: ");
                dlString = Console.ReadLine();

                ktDL = Regex.Match(dlString, @"^[0-9]{1,10}$").Success;
                if (!ktDL)
                    Console.WriteLine("Vui long nhap dung luong la mot so nguyen");

            } while (!ktDL);
            _dungLuongPin = Int32.Parse(dlString);
        }

        public override string XuatString()
        {
            return base.XuatString() + "Quat dien " + TenSP + " " + NoiSX + " " + Gia() + " " + _dungLuongPin;
        }
        public override int Gia()
        {
            return 500 * _dungLuongPin;
        }
    }
}
