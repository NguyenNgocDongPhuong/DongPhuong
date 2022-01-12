using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class StandFan:Fan
    {
        public override void EnterInformation()
        {
            base.EnterInformation();
        }

        public override string ExportInformation()
        {
            return base.ExportInformation() + "\n\t\tLoai may quat: Quat dung" + "\n\t\tĐơn giá: " + Price;
        }
        public override void CalPrice()
        {
            Price = 500;
        }
    }
}
