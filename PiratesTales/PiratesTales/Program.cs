using System;

namespace PiratesTales
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = { 10, 10 };
            Console.WriteLine(NumberOfDays(coordinates));
        }
        public static int NumberOfDays(int[] coordinates)
        {
            int temp = Math.Abs(coordinates[0] + coordinates[1]);
            return temp%5==0? temp+(temp/5)-1 : temp + temp / 5;
        }
    }
}
