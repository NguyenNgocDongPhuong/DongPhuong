using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TestOOP
{
    class GeneralFunctions
    {
        public static void EnterString(out string stringVar, string textToShow, string tab = "")
        {
            do
            {
                stringVar = Console.ReadLine();
                if (stringVar == "")
                    Console.Write(tab + textToShow + " khong duoc de trong. Vui long nhap lai "+textToShow + ": ");
            }
            while (stringVar == "");
        }
        public static void EnterId(ref string id, string textToShow, string tab = "")
        {
            bool isValidId;
            do
            {
                id = Console.ReadLine();
                isValidId = Regex.Match(id, @"^[a-zA-Z0-9]{3,10}$").Success;
                if (!isValidId)
                    Console.Write(tab + "Xin vui long nhap ma " + textToShow + " chi bao gom chu hoac so, dai tu 3 den 10 ky tu: ");
            } while (!isValidId);
        }
        public static void EnterPositiveInteger(ref int intVar, string textToShow, string tab = "")
        {
            string intVarAsString;
            bool IsAPositiveInteger;
            do
            {
                intVarAsString = Console.ReadLine();
                while (intVarAsString.Length > 1 && intVarAsString[0] == '0')
                {
                    intVarAsString = intVarAsString.Substring(1);
                }
                IsAPositiveInteger = Regex.Match(intVarAsString, @"^[0-9]{1,10}$").Success && intVarAsString != "0";
                
                if (IsAPositiveInteger == false)
                {
                    Console.Write(tab + "Vui long nhap " + textToShow + " la mot so nguyen duong: ");
                }    
                      

            } while (IsAPositiveInteger == false);
            intVar = Int32.Parse(intVarAsString);
        }
        public static void EnterPositiveIntegerWithRange(ref int intVar, string textToShow, int range, string tab = "")
        {
            
            bool IsInRange;
            do
            {
                EnterPositiveInteger(ref intVar, textToShow);
                IsInRange = intVar <= range;
                if (IsInRange == false)
                    Console.Write(tab + "Vui long nhap " + textToShow + " la mot so nguyen duong va <= {0}: ", range);
            } while (IsInRange == false);
        }
        public static void EnterPhoneNumber(ref string phoneNumberVar, string textToShow)
        {
            bool IsValid;
            do
            {
                Console.Write("\tSo dien thoai: ");
                phoneNumberVar = Console.ReadLine();

                IsValid = Regex.Match(phoneNumberVar, @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$").Success;
                if (!IsValid)
                    Console.Write(textToShow + "khong ton tai. Vui long nhap so dien thoai dung: ");

            } while (!IsValid);
        }
        public static void EnterBoolean(out string booleanAsString, string textToShow, string tab = "")
        {
            Console.Write("\t\t\t" + textToShow + "?\n\t\t\t 0. Khong co  1. Co: ");
            bool isBoolean;
            do
            {
                booleanAsString = Console.ReadLine();

                isBoolean = (booleanAsString == "1" || booleanAsString == "0");
                if (isBoolean == false)
                    Console.Write(tab + "Hay nhap '1' hoac '0' tuong ung co hoac khong co " + textToShow + ": ");

            } while (isBoolean == false);
        }
        public static void EnterChoice(out string chosen, string choicesAsString, string textToShow, string tab = "")
        {
            bool isChoice = false;
            do
            {
                chosen = Console.ReadLine();

                for (int i = 0; i < choicesAsString.Length; i++)
                    isChoice = isChoice || (chosen.Length == 1 && chosen[0] == choicesAsString[i]);
                if (isChoice == false)
                    Console.Write(tab + textToShow);

            } while (isChoice == false);
        }
    }
}
