using System;

namespace PiToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            Console.WriteLine(MyPi(n));
        }
        public static decimal MyPi(int n)
        {
            return Math.Round(Convert.ToDecimal(Math.PI), n);
        }
    }
}
