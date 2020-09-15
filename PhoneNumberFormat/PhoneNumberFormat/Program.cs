using System;
using System.Text.RegularExpressions;

namespace PhoneNumberFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "(123) 456-7895";
            Console.WriteLine(IsValidPhoneNumber(str));
        }
        static bool IsValidPhoneNumber(string str)
        {
           return Regex.Match(str, @"^\(\d{3}\) \d{3}-\d{4}$").Success;
        }
    }
}
