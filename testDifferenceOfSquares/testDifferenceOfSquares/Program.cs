using System;
using System.Collections.Generic;
using System.Linq;

namespace testDifferenceOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 840;

            foreach (var d in TripletsWithSum(sum))
            {
                Console.WriteLine($"{d.a} {d.b} {d.c}");
            }
        }

        static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        {

            int a = 2;
            while (a < sum / 3)
            {
                double temp = (double)sum * ((double)sum - 2 * (double)a) / (2 * ((double)sum - (double)a));
                if (temp % 1 == 0 && temp < sum&&a<temp)
                {
                    int b = (int)temp;
                    int c = sum - a - b;

                    yield return (a, b, c);
                }
                a++;
            }
        }
    }
}
