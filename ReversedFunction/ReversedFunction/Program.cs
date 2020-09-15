using System;

namespace ReversedFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 832;
            Console.WriteLine(MysteryFunc(n));
        }
        public static int MysteryFunc(int num)
        {
            int result = 1;
            while (num > 0)
            {
                result *= num % 10;
                num /= 10;
            }
            return result;
        }
    }
}
