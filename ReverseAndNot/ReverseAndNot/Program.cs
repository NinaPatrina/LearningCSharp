using System;
using System.Linq;

namespace ReverseAndNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 567;
            Console.WriteLine(ReverseAndNot(num));
        }

        public static int ReverseAndNot(int i)
        {
            return  int.Parse(i.ToString().ToCharArray().Reverse().Concat(i.ToString().Select(c=>c)).ToArray());
        }
    }
}
