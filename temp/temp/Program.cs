using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "12234567890";
            int n = 20;
            int[] multiples =  { 3, 5 };
            Console.WriteLine(Sum(multiples,n));

        }
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            int result = 0;
            for (int i = multiples.Min(); i < max; i++)
            {
                if (multiples.Any(x => (i % x == 0))) result += i;
            }
            return result;
        }
    }
}
