using System;
using System.Linq;

namespace EliminateOddNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
            var arr1 = array.Where(c => (c % 2 == 0)).ToArray();

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
