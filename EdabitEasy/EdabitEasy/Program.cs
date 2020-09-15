using System;
using System.Text;

namespace EdabitEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = Console.ReadLine();
            if (int.TryParse(foo, out int num))
            {
                Console.WriteLine($"{num} is a number");
            }
            else
            {
                Console.WriteLine($"{foo} is not a number");
            }
            // Console.WriteLine(Factorial(num));
            //  CountUp(num);

            static int Factorial(int num)
            {/*
                int result=num;
                while (num!=1)
                {
                    result = result * (num - 1);
                    num = num - 1;
                }
                return result;
                */
                int result;
                if (num == 1) return 1;
                else
                {
                    result = num * Factorial(num - 1);
                }
                return result;
            }
            static void CountUp(int num)
            {
                if (num == 1) Console.WriteLine(1);
                else
                {
                    CountUp(num - 1);
                    Console.WriteLine(num);
                }
            }
            static int Pow(int num)
            {
                if (num == 1)
                {
                    return 1;
                }
                else
                {
                    return num + Pow(num - 1);
                }
            }
            // Console.WriteLine(Pow(num));
            static bool Two(int num)
            {
                if (num % 2 != 0) return false;
                if (num == 2) return true;
                else
                {
                    num = num / 2;
                    return Two(num);
                }
            }
            //Console.WriteLine(Two(num));
            Console.WriteLine(Sum(num));
            static int Sum(int num)
            {
                if (num == 1) return 1;
                else return num + Sum(num - 1);
            }

        }
    }
}
