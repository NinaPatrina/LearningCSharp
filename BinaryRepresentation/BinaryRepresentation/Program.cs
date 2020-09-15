using System;
using System.Linq;

namespace BinaryRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 999;
            Console.WriteLine(CountOnes(n));
        }
        public static int CountOnes(int i)
        {
            //var bin = Convert.ToString(i, 2);
            //var m = bin.Where(c => c == '1').Count();
            //return m;
            string result = "";
            while (i >0)
            {                 
               result +=(i % 2).ToString();
                i=i/2;
                        }
            var m = result.Where(c => c == '1').Count();
            return m;


        }
    }
}
