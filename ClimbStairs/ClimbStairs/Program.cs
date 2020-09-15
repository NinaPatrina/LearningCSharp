using System;

namespace ClimbStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine(ClimbStairs(n));
        }
        public static int ClimbStairs(int n)
        {
            int sum = 1;
            int a = 1;
            int b = 1;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return sum;

        }
    }
}
