using System;
using System.Collections.Generic;
using System.Linq;

namespace Sieve
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 10;
            int[] range = Enumerable.Range(2, limit-1 ).ToArray();

            List<int> prime = new List<int>();
            foreach (var number in range)
            {
                if (number > 0)
                {
                    prime.Add(number);
                    int[] index = Enumerable.Range(2, (limit / number)-1).ToArray();
            
                    foreach (var b in index)
                    {
                       if (range[number * b - 2]>0) range[number * b - 2] *= (-1);
                    }
                }
            }

            
            foreach (var item in prime)
            {
            Console.WriteLine(item);

            }
        }
    }
}
