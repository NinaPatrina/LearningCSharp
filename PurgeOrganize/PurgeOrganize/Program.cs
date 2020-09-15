using System;
using System.Linq;

namespace PurgeOrganize
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.8998, 4, 4, 4, 4, 4, 3, 2, 1, 2 };

            double[] array2 = array.Distinct().OrderBy(c=>c).ToArray();

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }           
        }
    }
}
