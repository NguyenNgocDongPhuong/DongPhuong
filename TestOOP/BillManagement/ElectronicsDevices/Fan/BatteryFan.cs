using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class BatteryFan:Fan
    {
        protected int _batteryCapacity;
        public override void EnterInformation()
        {
            base.EnterInformation();
            Console.Write("\t\t\tDung luong pin: ");
            GeneralFunctions.EnterPositiveInteger(ref _batteryCapacity, "dung luong pin", "\t\t\t");
        }

        public override string ExportInformation()
        {
            return base.ExportInformation() + "\n\t\tLoai may quat: Quat dien\n\t\tDung luong pin: " + _batteryCapacity + "\n\t\tĐơn giá: " + Price;
        }
        public override void CalPrice()
        {
            Price = 500 * _batteryCapacity;
        }
    }
}
