using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    abstract class AirConditioner:ElectronicsDevices
    {
        protected bool HasInverterTech;
        //public static void Nhap01(out string bien01, string tenBien)
        //{
        //    Console.Write("\t\t\t"+tenBien+"?\n\t\t\t 0. Khong co  1. Co: ");
        //    bool kt;
        //    do
        //    {
        //        bien01 = Console.ReadLine();

        //        kt = (bien01 == "1" || bien01 == "0");
        //        if (kt == false)
        //            Console.WriteLine("Hay EnterInformation '1' hoac '0' tuong ung co hoac khong co " + tenBien);

        //    } while (kt == false);
        //}
        public override void EnterInformation()
        {
            base.EnterInformation();
            
            string hasInverterTechAsString;
            GeneralFunctions.EnterBoolean(out hasInverterTechAsString, "Cong nghe Inverter", "\t\t\t");

            if (hasInverterTechAsString == "1")
                HasInverterTech = true;
            else
                HasInverterTech = false;
        }
        public override string ExportInformation()
        {
            return base.ExportInformation();
        }
        public abstract override void CalPrice();
    }
}
