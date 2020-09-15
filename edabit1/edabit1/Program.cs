using System;

namespace edabit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input а");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("input b");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine("the sum of a and b is:  " + Sum(a, DateTime.Now));
            /*
            Console.WriteLine("the next number after a is:  " + Addition(a));

            Console.WriteLine("the area of triangle is:  " + TriArea(a, b));

            Console.WriteLine("the reminder a/b is:  " + a % b);

            Console.WriteLine("a is less or equal 0 :   " + LessThanOrEqualToZero(a));
            /**/
        }

        // static
        // int in parameters
        // many int declarations

        public static dynamic Sum(dynamic a, dynamic b)
        {
            return a + b;
        }

        public int Addition(int a)
        {
            return a + 1;
        }
        public int TriArea(int a, int b) => a * b / 2;

        public bool LessThanOrEqualToZero(double a)
        {
            if (a <= 0)
            {
                return true;
            }
            return false;
        }

    }
}
