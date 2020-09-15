using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(Factorial(n));
            Console.WriteLine(Fibonacchi(n));
            Console.WriteLine(Frog(n));


        }
        static int Frog(int n)
        {
            int result;
            if (n == 0 || n == 1) return 1;
            else result = Frog(n - 2) + Frog(n - 1);
            return result;

        }
        static int Factorial(int n)
        {
            int result;
            if (n == 1)
                return 1;
            else
            {
                result = n * Factorial(n - 1);
            }
            return result;
        }
        static int Fibonacchi(int n)
        {
            int result;
            if (n == 0) return 0;
            if (n == 1) return 1;
            else
            { result = Fibonacchi(n - 1) + Fibonacchi(n - 2); }
            return result;
        }
    }
}
