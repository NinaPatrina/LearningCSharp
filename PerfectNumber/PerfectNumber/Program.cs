using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 496;
            Console.WriteLine(CheckPerfect( num));
        }
        public static bool CheckPerfect(int num)
        {
            int x = 0;
            for (int i = 1; i <= num/2; i++)
            {if (num % i == 0)
                    x += i;
                                   }
            return x == num ;
        }
    }
}
