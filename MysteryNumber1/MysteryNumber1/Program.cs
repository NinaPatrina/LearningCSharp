using System;

namespace MysteryNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9;
            Console.WriteLine(MysteryFunc(num));
        }
        public static int MysteryFunc(int num)
        {
            int i = 1;
            int result = 0;
            while (i * 2 <= num)
            {
                i *= 2;
                result = result * 10 + 2;
            }
            int temp = num - i;
            int m = 1;
            int result1 = 0;
            while (temp != 0)
            {
                result1 += temp % 10 * m;
                m *= 10;
                temp /= 10;
            }
            return result * m + result1;
        }
    }
}
