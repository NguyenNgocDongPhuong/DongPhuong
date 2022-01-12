using System;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.InputEncoding = Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            BillManagement DienMayXanh = new BillManagement();
            DienMayXanh.Run();
        }
    }
}
