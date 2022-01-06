using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    abstract class MayQuat : ThietBiDien
    {
        public override void Nhap()
        {
            base.Nhap();
        }

        public override string XuatString()
        {
            return base.XuatString();
        }
        public abstract override int Gia();
    }
}
