using System;
using System.Text.RegularExpressions;

namespace ReplaceLetterWithPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Wow, does that work?";
            Console.WriteLine(AlphabetIndex( str));
        }
        public static string AlphabetIndex(string str)
        {
            string result = "";
            string letters = "0abcdefghijklmnopqrstuvwxyz";
            str = Regex.Replace(str, @"[^A-Za-z]", "").ToString().ToLower();
            foreach (char c in str)
            {
                result += letters.IndexOf(c).ToString()+" ";
            }
            return result.TrimEnd();

        }
    }
}
