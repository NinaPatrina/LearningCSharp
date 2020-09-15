using System;
using System.Linq;

namespace SocksPair
{
    class Program
    {
        static void Main(string[] args)
        {
            string socks = "CABBAcCCCvbn";
            Console.WriteLine(SockPairs(socks));
        }
        public static int SockPairs(string socks)
        {
            //var socks1 = socks.OrderBy(c=>c).ToArray();
            //int count = 0;
            //for (int i = 0; i < socks1.Length-1; i++)
            //{
            //    if (socks1[i] == socks1[i + 1]) { count++; i++; }
            //}

            return socks.GroupBy(c => c).Select(c => c.Count() / 2).Sum();
        }
    }
}
