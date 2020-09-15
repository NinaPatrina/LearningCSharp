using System;

namespace CumulativeArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 3, -2, 408, 3, 3 };
            int[] array2 = new int[array.Length];
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i] + n;
                n = array2[i];
            }
            foreach (var item in array2)
            {
                Console.WriteLine(item);

            }
        }
    }
}
