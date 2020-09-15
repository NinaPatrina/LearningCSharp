using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveMinFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {};
            foreach (var item in RemoveSmallest(array))
            {
                Console.WriteLine(item);

            }
        }
        public static int[] RemoveSmallest(int[] values)
        { if (values.Length == 0) return values;
            int n = values.Min();
            int m = 0;
            var st = new Stack<int>();
            foreach (var item in values)
            {if (item == n && m == 0) m++;
             else st.Push(item);}
            return st.ToArray().Reverse().ToArray();
                    }
    }
}
