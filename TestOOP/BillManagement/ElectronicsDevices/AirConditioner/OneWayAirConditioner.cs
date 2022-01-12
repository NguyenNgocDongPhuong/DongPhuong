using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class OneWayAirConditioner:AirConditioner
    {
        public override string ExportInformation()
        {
            return base.ExportInformation() + "\n\t\tLoai may lanh: May lanh 1 chieu" + "\n\t\tĐơn giá: " + Price;
        }
        public override void EnterInformation()
        {
            base.EnterInformation();
        }
        public override void CalPrice()
        {
            Price = 1000 + 500 * Convert.ToInt32(HasInverterTech);
        }
    }
}
