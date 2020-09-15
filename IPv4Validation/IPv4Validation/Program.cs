using System;
using System.Text.RegularExpressions;

namespace IPv4Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "123.45.67.89";
            Console.WriteLine(IsValidIP(ip));
        }
        public static bool IsValidIP(string IP)
        {
            return Regex.IsMatch(IP, @"^((1|2)?\d?\d.){3}(1|2)?\d?\d$");
        }
    }
}
