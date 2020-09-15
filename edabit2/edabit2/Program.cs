using System;

namespace edabit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number");
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("your number is " + IsEvenOrOdd(num));

        }
        public static string IsEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            { return "even"; }
            return "odd";
        }

    }

}
