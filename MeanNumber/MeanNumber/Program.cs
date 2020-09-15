using System;

namespace MeanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tape 8 numbers");
            int[] array = new int[8];
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine(sum/2);
        }
    }
}
