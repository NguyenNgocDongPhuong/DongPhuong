using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class MayLanhHaiChieu:MayLanh
    {
        protected bool KhuMui;
        protected bool KhangKhuan;
        public override void Nhap()
        {
            base.Nhap();

            string cnKhuMui;
            MayLanh.Nhap01(out cnKhuMui, "Cong nghe khu mui");

            if (cnKhuMui == "1")
                KhuMui = true;
            else
                KhuMui = false;

            string cnKhangKhuan;
            MayLanh.Nhap01(out cnKhangKhuan, "Cong nghe khang khuan");

            if (cnKhangKhuan == "1")
                KhangKhuan = true;
            else
                KhangKhuan = false;
        }
        public override string XuatString()
        {
            string res = base.XuatString() + "\n\t\tLoai may lanh: May lanh 2 chieu\n\t\tTen san pham: " + TenSP + "\n\t\tNoi san xuat: " + NoiSX + "\n\t\tDon gia: " + Gia();
            if (KhangKhuan)
            {
                res += "\n\t\tCo cong nghe khang khuan";
            }
            else
                res += "\n\t\tKhong co cong nghe khang khuan";
            if (KhuMui)
            {
                res += "\n\t\tCo cong nghe khu mui";
            }
            else
                res += "\n\t\tKhong co cong nghe khu mui";
            return res;
        }
        public override int Gia()
        {
            return 2000 + 500 * Convert.ToInt32(CNInverter) + 500 * Convert.ToInt32(KhuMui) + 500 * Convert.ToInt32(KhangKhuan);
        }
    }
}
