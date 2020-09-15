using System;

namespace LastDigitUltimate
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55;
            int b = 226;
            int c = 5190;
            int num = 0;
            Console.WriteLine(Last_dig(a, b, c));
            Console.Write(Factorial(num));
        }
        static bool Last_dig(int a, int b, int c)
        {
            return (a * b) % 10 == c % 10 ? true : false;
                    }
        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
