using System;
using System.Linq;

namespace PositiveCountNegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            Console.WriteLine(CountPosSumNeg(arr));
        }
        public static int[] CountPosSumNeg(double[] arr)
        {
            if (arr == null) return null;
          int[] result ={arr.Where(v =>v >=0).Count(), Convert.ToInt32(arr.Where(v => v <= 0).Sum())};
          return result;
        }
    }
}
