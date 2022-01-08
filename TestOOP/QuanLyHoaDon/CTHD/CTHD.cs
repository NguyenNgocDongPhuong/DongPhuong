using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class CTHD
    {
        private ThietBiDien _sp;
        private int _sl;
        public void Nhap()
        {
            string loai;
            bool ktLoai;
            do
            {
                Console.Write("\t\tChon loai thiet bi dien (1-May quat, 2-Maylanh): ");
                loai = Console.ReadLine();

                ktLoai = (loai == "1" || loai == "2");
                if (!ktLoai)
                    Console.WriteLine("Hay nhap '1' tuong ung May quat hoac '2' tuong ung May lanh ");

            } while (!ktLoai);
            if (loai == "1")
            {
                bool ktLoaiMQ;
                string loaiMQ;
                do
                {
                    Console.Write("\t\t\tChon loai may quat (1-May quat dung, 2-May quat hoi nuoc, 3-May quat sac dien): ");
                    loaiMQ = Console.ReadLine();

                    ktLoaiMQ = (loaiMQ == "1" || loaiMQ == "2" || loaiMQ == "3");
                    if (!ktLoaiMQ)
                        Console.WriteLine("Hay nhap '1' hoac '2' hoac '3' theo menu");

                } while (!ktLoaiMQ);

                switch (loaiMQ)
                {
                    case "1": _sp = new QuatDung(); break;
                    case "2": _sp = new QuatHoiNuoc(); break;
                    case "3": _sp = new QuatDien(); break;
                }
            }
            else
            {
                string loaiML;
                bool ktLoaiML;
                do
                {
                    Console.Write("Chon loai may lanh (1-Mot chieu, 2-Hai chieu): ");
                    loaiML = Console.ReadLine();

                    ktLoaiML = (loaiML == "1" || loaiML == "2");
                    if (!ktLoaiML)
                        Console.WriteLine("Hay nhap '1' hoac '2' tuong ung so chieu cua may lanh");

                } while (!ktLoaiML);
                if (loaiML == "1")
                    _sp = new MayLanhMotChieu();
                else 
                    _sp = new MayLanhHaiChieu();
            }

            _sp.Nhap();

            //string slTmp;
            //bool ktSL;
            //do
            //{
            //    Console.Write("\t\tSo luong ban ra: ");
            //    slTmp = Console.ReadLine();

            //    ktSL = Regex.Match(slTmp, @"^[0-9]{1,10}$").Success;
            //    if (!ktSL)
            //        Console.WriteLine("Vui long nhap so luong la mot so nguyen");

            //} while (!ktSL);
            //_sl = Int32.Parse(slTmp);
            Console.Write("\t\tSo luong ban ra: ");
            HoaDon.NhapSoNguyenDuong(ref _sl, "so luong");
        }
        public string XuatString()
        {
            string res;
            if (_sp is MayQuat)
            {
                res = "\tMay quat: ";
            }
            else
                res = "\tMay lanh: ";
            res += _sp.XuatString() + "\n\tSo luong ban ra: " + _sl + "\n";
            return res;
        }
        public int ThanhTien()
        {
            return _sl * _sp.Gia();
        }
    }
}
