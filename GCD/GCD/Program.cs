using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 40;
            int n2 = 100;
            Console.WriteLine(gcd(n1, n2));
        }
        public static int gcd(int n1, int n2)
        {
            while (n1 != 0)
            {
                (n2, n1) = (n1, n2 % n1);
            }
            return n2;


        }
    }
}
