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
            return base.XuatString() + "\n\t\tLoai may quat: Quat dung\n\t\tTen san pham: " + TenSP + "\n\t\tNoi san xuat: " + NoiSX + "\n\t\tDon gia: " + Gia();
        }
        public override int Gia()
        {
            return 500;
        }
    }
}
