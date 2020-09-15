using System;
using System.Text.RegularExpressions;

namespace AveWordLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Dude, this is so awesome!";
            Console.WriteLine(AverageWordLength(str));
        }
        public static double AverageWordLength(string str)
        {
            string[] array = str.Split();
            double m = Regex.Matches(str, @"\w").Count;
            return Math.Round(  m / array.Length,2);
        }
    }
}
