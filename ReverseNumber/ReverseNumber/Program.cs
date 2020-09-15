using System;
using System.Linq;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 111211;

            Console.WriteLine(IsSymmetrical( num));
        }
        public static bool IsSymmetrical(int num)
        {
            string rev = num.ToString();
            return rev.SequenceEqual(rev.Reverse());
        }
    }
}
