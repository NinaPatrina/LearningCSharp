using System;
using System.Linq;

namespace MaxInGroupArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] matrix = new double[3][]
            { new double[] { 0.4321, 0.7634, 0.652},
                new double[]  { 1.324, 9.32, 2.5423, 6.4314 },
                new double[]  { 9, 3, 6, 3 }
            }

            foreach (var max in FindLargest(matrix))
            {
                Console.WriteLine(max);
            }
        }
        public static double[] FindLargest(double[][] values)
        {
            var array = values.Select(v=> v.Max()).ToArray();
            return array;
        }
    }
}
