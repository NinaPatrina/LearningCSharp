using System;

namespace FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000000;
            Console.WriteLine(FormatNum(n));
        }
        public static string FormatNum(int num)
        {
            string result = num.ToString();
            int m = result.Length;
            for (int i = 1; i <=(m - 1) / 3; i++)
            {
                 result = result.Insert((m - 3 * i), ",");
            }
            return result;
        }
    }
}
