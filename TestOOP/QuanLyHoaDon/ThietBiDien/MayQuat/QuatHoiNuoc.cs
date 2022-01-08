using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class QuatHoiNuoc:MayQuat
    {
        protected int _dungTichNuoc;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t\t\tDung tich nuoc: ");
            HoaDon.NhapSoNguyenDuong(ref _dungTichNuoc, "dung tich nuoc");
        }

        public override string XuatString()
        {
            return base.XuatString() + "\n\t\tLoai may quat: Quat dung\n\t\tTen san pham: " + TenSP + "\n\t\tNoi san xuat: " + NoiSX + "\n\t\tDon gia: " + Gia() + "\n\t\tDung tich nuoc: " + _dungTichNuoc;
        }
        public override int Gia()
        {
            return 400 * _dungTichNuoc;
        }
    }
}
