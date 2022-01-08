using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    abstract class MayLanh:ThietBiDien
    {
        protected bool CNInverter;
        public static void Nhap01(out string bien01, string tenBien)
        {
            Console.Write("\t\t\t"+tenBien+"?\n\t\t\t 0. Khong co  1. Co: ");
            bool kt;
            do
            {
                bien01 = Console.ReadLine();

                kt = (bien01 == "1" || bien01 == "0");
                if (kt == false)
                    Console.WriteLine("Hay nhap '1' hoac '0' tuong ung co hoac khong co " + tenBien);

            } while (kt == false);
        }
        public override void Nhap()
        {
            base.Nhap();
            
            string cnInverter;
            Nhap01(out cnInverter, "Cong nghe Inverter");

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
