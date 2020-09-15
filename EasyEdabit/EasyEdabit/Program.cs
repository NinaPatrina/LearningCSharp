using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EasyEdabit
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "llopo";
            Console.WriteLine(DoubleLetters(word));
            static bool DoubleLetters(string word)
            {
                return
                    Regex.IsMatch(word, @"(.)\1");
            }
        }
    }
}
