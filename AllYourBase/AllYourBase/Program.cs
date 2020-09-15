using System;
using System.Collections.Generic;

namespace AllYourBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputBase = 97;
            var digits = new[] { 3, 46, 60 };
            var outputBase = 73;

            foreach (var item in Rebase(inputBase, digits, outputBase))
            {
                Console.WriteLine(item);
            }
        }
        static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
        {
            double digit = 0;
            for (int n = 0; n < inputDigits.Length; n++)
            {
                digit +=inputDigits[n] * Math.Pow((double)inputBase, (double)inputDigits.Length - n - 1);
            }
            List<int> outputDigits = new List<int>();
            while (digit > 0)
            {
                outputDigits.Add((int)digit % outputBase);
                digit = (int)digit / outputBase;
            }
            outputDigits.Reverse();
            return outputDigits.ToArray();
        }
    }
}

