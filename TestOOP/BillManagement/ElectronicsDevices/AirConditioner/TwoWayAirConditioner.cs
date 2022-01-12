using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class TwoWayAirConditioner:AirConditioner
    {
        protected bool HasDeodorantTech;
        protected bool HasAntibacterialTech;
        public override void EnterInformation()
        {
            base.EnterInformation();

            string hasDeodorantTechAsString;
            GeneralFunctions.EnterBoolean(out hasDeodorantTechAsString, "Cong nghe khu mui", "\t\t\t");

            if (hasDeodorantTechAsString == "1")
                HasDeodorantTech = true;
            else
                HasDeodorantTech = false;

            string hasAntibacterialTechAsString;
            GeneralFunctions.EnterBoolean(out hasAntibacterialTechAsString, "Cong nghe khang khuan", "\t\t\t");

            if (hasAntibacterialTechAsString == "1")
                HasAntibacterialTech = true;
            else
                HasAntibacterialTech = false;
        }
        public override string ExportInformation()
        {
            string res = base.ExportInformation() + "\n\t\tLoai may lanh: May lanh 2 chieu" + "\n\t\tĐơn giá: " + Price;
            if (HasAntibacterialTech)
            {
                res += "\n\t\tCo cong nghe khang khuan";
            }
            if (HasDeodorantTech)
            {
                res += "\n\t\tCo cong nghe khu mui";
            }
            if (HasInverterTech)
            {
                res += "\n\t\tCo cong nghe Inverter";
            }
            return res;
        }
        public override void CalPrice()
        {
            Price = 2000 + 500 * Convert.ToInt32(HasInverterTech) + 500 * Convert.ToInt32(HasDeodorantTech) + 500 * Convert.ToInt32(HasAntibacterialTech);
        }
    }
}
