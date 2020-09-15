using System;

namespace BreakPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Console.WriteLine(BreakPoint(num));
        }
        public static bool BreakPoint(int num)
        {
            var sum1 = 0;
            var sum2 = 0;
            while (num > 0)
            {
                while (sum1 < sum2)
                {
                    int temp = num;
                    int m = 1;
                    while (temp > 9)
                    {
                        temp /= 10;
                        m *= 10;
                    }
                    sum1 += temp;
                    num -= temp * m;
                }
                sum2 += num % 10;
                num /= 10;
            }
            return (sum1 == sum2);
        }
    }
}
