using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    abstract class Fan : ElectronicsDevices
    {
        public override void EnterInformation()
        {
            base.EnterInformation();
        }

        public override string ExportInformation()
        {
            return base.ExportInformation();
        }
        public abstract override void CalPrice();
    }
}
