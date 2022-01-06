using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class MayLanhMotChieu:MayLanh
    {
        public override string XuatString()
        {
            return base.XuatString() + "May lanh 1 chieu " + TenSP + " " + NoiSX + " " + Gia();
        }
        public override void Nhap()
        {
            base.Nhap();
        }
        public override int Gia()
        {
            return 1000 + 500 * Convert.ToInt32(CNInverter);
        }
    }
}
