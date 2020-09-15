using System;

namespace NextPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 48;
            Console.WriteLine(NextPrime(num));
        }
        public static int NextPrime(int num)
        {
            if (num <= 1) return num;
           startLoop:
            while (true)
            {
                if (num % 2 == 0) { num++; goto startLoop; };
                if (num % 3 == 0) { num++; goto startLoop; };
                for (int i = 5; i < num / 2; i += 6)
                {
                    if (num % i == 0 || num % (i + 2) == 0) { num++; goto startLoop; };
                };
                return num;
            }
        }
    }
}
