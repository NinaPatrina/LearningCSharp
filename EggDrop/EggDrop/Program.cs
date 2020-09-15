using System;

namespace EggDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] attempts = new int[100];

            for (int i = 1; i < 100; i++)
            {
                attempts[i] = 100/i +( i - 1);

            }
            foreach (var item in attempts)
            {
                Console.WriteLine(item);

            }
        }
    }
}
