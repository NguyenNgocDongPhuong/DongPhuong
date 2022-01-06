using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    abstract class MayLanh:ThietBiDien
    {
        protected bool CNInverter;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t\t\tCong nghe Inverter?\n\t\t\t 0. Khong co  1. Co: ");

            string cnInverter;
            bool ktCNI;
            do
            {
                cnInverter = Console.ReadLine();

                ktCNI = (cnInverter == "1" || cnInverter == "0");
                if (!ktCNI)
                    Console.WriteLine("Hay nhap '1' hoac '0' tuong ung co hoac khong co CN Inverter");

            } while (!ktCNI);

            if (cnInverter == "1")
                CNInverter = true;
            else
                CNInverter = false;
        }
        public override string XuatString()
        {
            return base.XuatString();
        }
        public abstract override int Gia();
    }
}
