using System;

namespace EqualityOf3Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            int c = 3;
            var value = 0;
            if (a == b) value++;
            if (b == c) value++;
            if (a == c) value++;
            if (value == 2) value = 1;

            Console.WriteLine(value);
        }
    }
}
