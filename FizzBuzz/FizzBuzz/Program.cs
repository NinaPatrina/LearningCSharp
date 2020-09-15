using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;

            foreach (var item in FizzBuzz(n))
            {
                Console.WriteLine(item);

            }
            static IList<string> FizzBuzz(int n)
            {
                List<string> result = new List<string>();
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0) result.Add("FizzBuzz");
                    else if (i % 3 == 0) result.Add("Fizz");
                    else if (i % 5 == 0) result.Add("Buzz");
                    else result.Add(i.ToString());
                }
                return result;
            }
        }
    }
}
