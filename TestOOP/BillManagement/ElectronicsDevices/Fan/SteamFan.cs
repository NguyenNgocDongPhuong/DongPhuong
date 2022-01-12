using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class SteamFan:Fan
    {
        protected int _waterCapacity;
        public override void EnterInformation()
        {
            base.EnterInformation();
            Console.Write("\t\t\tDung tich nuoc: ");
            GeneralFunctions.EnterPositiveInteger(ref _waterCapacity, "dung tich nuoc", "\t\t\t");
        }

        public override string ExportInformation()
        {
            return base.ExportInformation() + "\n\t\tLoai may quat: Quat dung\n\t\tDung tich nuoc: " + _waterCapacity + "\n\t\tĐơn giá: " + Price;
        }
        public override void CalPrice()
        {
            Price = 400 * _waterCapacity;
        }
    }
}
