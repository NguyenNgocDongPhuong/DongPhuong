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
            Console.Write("\t\t\tCong nghe khu mui?\n\t\t\t 0. Khong co  1. Co: ");

            string cnKhuMui;
            bool ktCNKM;
            do
            {
                cnKhuMui = Console.ReadLine();

                ktCNKM = (cnKhuMui == "1" || cnKhuMui == "0");
                if (!ktCNKM)
                    Console.WriteLine("Hay nhap '1' hoac '0' tuong ung co hoac khong co CN khu mui");

            } while (!ktCNKM);

            if (cnKhuMui == "1")
                KhuMui = true;
            else
                KhuMui = false;

            Console.Write("\t\t\tCong nghe khang khuan?\n\t\t\t 0. Khong co  1. Co: ");
            string cnKhangKhuan;
            bool ktCNKK;
            do
            {
                cnKhangKhuan = Console.ReadLine();

                ktCNKK = (cnKhangKhuan == "1" || cnKhangKhuan == "0");
                if (!ktCNKK)
                    Console.WriteLine("Hay nhap '1' hoac '0' tuong ung co hoac khong co CN khang khuan");

            } while (!ktCNKK);

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
