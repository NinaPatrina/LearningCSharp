using System;
using System.Linq;

namespace SumOfTwoSmallestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 19, 5, 42, 2, 77 };
            Console.WriteLine(SumSmallest(arr));
        }
        public static int SumSmallest(int[] values)
        {
            return values.Where(v => v >= 0).
              OrderBy(v => v).
                 Take(2).Sum();
        }
    }
}
