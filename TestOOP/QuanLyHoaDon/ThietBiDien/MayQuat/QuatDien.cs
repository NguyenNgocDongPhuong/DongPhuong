using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class QuatDien:MayQuat
    {
        protected int _dungLuongPin;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t\t\tDung luong pin: ");
            HoaDon.NhapSoNguyenDuong(ref _dungLuongPin, "dung luong pin");
        }

        public override string XuatString()
        {
            return base.XuatString() + "\n\t\tLoai may quat: Quat dien\n\t\tTen san pham: " + TenSP + "\n\t\tNoi san xuat: " + NoiSX + "\n\t\tDon gia: " + Gia() + "\n\t\tDung luong pin: " + _dungLuongPin;
        }
        public override int Gia()
        {
            return 500 * _dungLuongPin;
        }
    }
}
