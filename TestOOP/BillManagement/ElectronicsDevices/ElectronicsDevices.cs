using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace TestOOP
{
    abstract class ElectronicsDevices
    {
        protected string Id;
        protected string ProductName;
        protected string Original;
        public long Price;
        public ElectronicsDevices()
        {
            Id = "";
            ProductName = "";
            Original = "";
        }
        public virtual void EnterInformation()
        {
            Console.Write("\t\t\tMa san pham: ");
            GeneralFunctions.EnterId(ref Id, "san pham", "\t\t\t");

            Console.Write("\t\t\tTen san pham: ");
            GeneralFunctions.EnterString(out ProductName, "Ten san pham", "\t\t\t");

            Console.Write("\t\t\tNoi san xuat: ");
            GeneralFunctions.EnterString(out Original, "Noi san xuat", "\t\t\t");
        }
        public virtual string ExportInformation()
        {
            CalPrice();
            return "\n\t\tMa san pham: " + Id + "\n\t\tTen san pham: " + ProductName + "\n\t\tNoi san xuat: " + Original;
        }
        public abstract void CalPrice();
    }
}
