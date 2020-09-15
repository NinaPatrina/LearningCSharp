using System;
using System.Text.RegularExpressions;

namespace NoYelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string yell = "What? went wrong???!!!";
            Console.WriteLine(NoYelling(yell));
        }

        public static string NoYelling(string phrase)
        {
			return Regex.Replace(phrase, @"([?|!])\1*$", @"$1");        }
    }
}
