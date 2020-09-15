using System;
using System.Text.RegularExpressions;
using System.Text;

namespace SameCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string key ="ad";
            Console.WriteLine(getHashCode(key));
        }
        public static bool SameCase(string str)
        {
            if (Regex.IsMatch(str, @"[A-Z]+") &&Regex.IsMatch(str, @"[a-z]+")) return false;
            return true;
        }
        public static string HackerSpeak(string str)
        {
            return str.Replace('a', '4').Replace('e', '3').Replace('i', '1').Replace('o', '0').Replace('s', '5');
        }
        public static bool IsValidHexCode(string str)
        {
            return Regex.IsMatch(str, @"^#([a-fA-F0-9]){6}$");
        }
        public static int getHashCode(string key)
        {
            return  Convert.ToInt32(key,16);
        }
    }
}
