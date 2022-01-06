using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class QuatDung:MayQuat
    {
        public override void Nhap()
        {
            base.Nhap();
        }

        public override string XuatString()
        {
            return base.XuatString() + "Quat dung " + TenSP + " " + NoiSX + " " + Gia();
        }
        public override int Gia()
        {
            return 500;
        }
    }
}
