using System;

namespace EdabitMedium1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number:");
            int n =int.Parse (Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }

        public static bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i < n; i++)
                if ((n % i) == 0)
                    return false;

            return true;
        }
    }
}
