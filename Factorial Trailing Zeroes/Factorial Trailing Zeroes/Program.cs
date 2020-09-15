using System;
using System.Linq;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(TrailingZeroes(n));

            static int TrailingZeroes(int n)
            {
                int result;
                if (n == 1) { return 1; }
                else { result = TrailingZeroes(n - 1) * n; }
                //int x = result.ToString().Where(c => c == '0').Count();
                return result;
            }
        }
    }
}
