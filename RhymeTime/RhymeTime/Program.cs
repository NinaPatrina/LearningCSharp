using System;
using System.Text.RegularExpressions;

namespace RhymeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Sam I moam";
            string str2 = "Green eggs and ham.";
            Console.WriteLine(DoesRhyme(str1, str2));
        }
        public static bool DoesRhyme(string str1, string str2)
        {
            
                Console.WriteLine(Regex.Matches(str2, @"\b(.*[aeiou].*)\b$").Count);


            string str3 = $"{str1}{str2}";
            return Regex.IsMatch(str3, @"\b(.*[aeiou]+.*)\b$ (\1)$");

        }
    }
}
