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
            return base.XuatString() + "\n\t\tLoai may lanh: May lanh 1 chieu\n\t\tTen san pham: " + TenSP + "\n\t\tNoi san xuat:" + NoiSX + "\n\t\tDon gia" + Gia();
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
