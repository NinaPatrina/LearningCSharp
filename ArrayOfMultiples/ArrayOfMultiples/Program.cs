using System;

namespace ArrayOfMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
           int[] array= ArrayOfMultiples(num, length);
            foreach (var item in array)
            {
                Console.WriteLine(item);

            }
        }
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = num * (i + 1);
                            }
            return result;
        }
    }
}
