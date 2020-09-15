using System;
using System.Text.RegularExpressions;

namespace CorrectInequalitySigns
{
    class Program
    {
        static void Main()
        {
            string str = "33 < 7 < 11 < 9";
            Console.WriteLine(CorrectSigns(str));
        }
        public static bool CorrectSigns(string str)
        {
            while (Regex.Matches(str, @"(\d+)").Count > 1)
            {
                int m = int.Parse(Regex.Match(str, @"^\d+").Value);
                var sign = Regex.Match(str, @"(<|>)").Value;
                str = Regex.Replace(str, @"^(\d+) (<|>) ", "").ToString();
                int b = int.Parse(Regex.Match(str, @"^\d+").Value);
                if (m < b && sign == ">") return false;
                if (m > b && sign == "<") return false;
                if (m == b) return false;
            }

            return true;
        }
    }
}
