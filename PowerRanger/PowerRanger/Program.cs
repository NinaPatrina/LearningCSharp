using System;

namespace PowerRanger
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = 4;
             int min = 250;
             int max = 1300;
            Console.WriteLine(PowerRanger( power,  min,  max));
        }
        public static int PowerRanger(int power, int min, int max)
        {
            double i = 1;
            double result = 0;
            int count = 0;
            while (result <= max)
            {
                result = System.Math.Pow(i, power);
                i++;
                if (result >= min && result <= max) count++;
            }

            return count;
        }
    }
}
