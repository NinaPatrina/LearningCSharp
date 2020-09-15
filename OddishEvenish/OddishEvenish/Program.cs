using System;

namespace OddishEvenish
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4433;
            Console.WriteLine(OddishOrEvenish(num));
        }
        public static string OddishOrEvenish(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result += num % 10;
                num /= 10;
                            }
            return result % 2 == 0 ? "Evenish" : "Oddish";
        }
    }
}
