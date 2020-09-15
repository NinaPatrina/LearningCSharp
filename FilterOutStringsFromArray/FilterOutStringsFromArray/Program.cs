using System;
using System.Linq;

namespace FilterOutStringsFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = { 1, 2, "aasf", "1", "123", 123 };
            int[] result = FilterArray(arr);

            foreach (var item in result)
            {
                Console.WriteLine(item);
                            }
        }
        public static int[] FilterArray(object[] arr)
        {
            var result = arr.OfType<int>().ToArray();
            return result;
        }
    }
}
