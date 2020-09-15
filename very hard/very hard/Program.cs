using System;

namespace very_hard
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { -1, -1, 0, -1, -1 };

            var result = CheckLandscape(array);
            Console.WriteLine("It is: " + result);
        }

        private static string CheckLandscape(int[] array)
        {
            var a = 0;
            var b = 0;
            int max = array[0];
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                    a = i;
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= min)
                {
                    min = array[i];
                    b = i;
                }
            }
            Console.WriteLine("{0},{1},{2},{3}", max, a, min, b);
            if ((b == 0 || b == array.Length-1) && CheckMountain(array, a))
                return "mountain";

            if ((a == 0 || a == array.Length-1)  && CheckValley(array, b))
                return "valley";
            return "neighter";
        }

        public static bool CheckValley(int[] array, int b)
        {
            for (int i = 0; i < b - 1; i++)
            {
                if (array[i] < array[i + 1])
                    return false;
            }
            for (int i = b; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }
            return true;
        }

        public static bool CheckMountain(int[] array, int a)
        {
            for (int i = 0; i < a - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }
            for (int i = a; i < array.Length-1; i++)
            {
                if (array[i] < array[i + 1])
                    return false;
            }
            return true;
        }



    }
}

