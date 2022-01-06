using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class QuatHoiNuoc:MayQuat
    {
        protected int _dungTichNuoc;
        public override void Nhap()
        {
            base.Nhap();
            string dtString;
            bool ktDT;
            do
            {
                Console.Write("\t\t\tDung tich nuoc: ");
                dtString = Console.ReadLine();

                ktDT = Regex.Match(dtString, @"^[0-9]{1,10}$").Success;
                if (!ktDT)
                    Console.WriteLine("Vui long nhap dung tich la mot so nguyen");

            } while (!ktDT);
            _dungTichNuoc = Int32.Parse(dtString);
        }

        public override string XuatString()
        {
            return base.XuatString() + "Quat dung " + TenSP + " " + NoiSX + " " + Gia() + " " + _dungTichNuoc;
        }
        public override int Gia()
        {
            return 400 * _dungTichNuoc;
        }
    }
}
