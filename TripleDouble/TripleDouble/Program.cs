using System;
using System.Text.RegularExpressions;

namespace TripleDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 12345;
            long num2 = 12345;
            Console.WriteLine(Trouble(num1, num2));
        }
        public static bool Trouble(long num1, long num2)
        {
            string num = Regex.Match(num1.ToString(), @"(0{3}|1{3}|2{3}|3{3}|4{3}|5{3}|6{3}|7{3}|8{3}|9{3})").ToString();
            if (num.Length < 3) return false;
            num = num.Substring(1);
            return Regex.IsMatch(num2.ToString(), num);

        }
    }
}
