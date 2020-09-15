using System;
using System.Linq;

namespace NumDescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2619805;
            int numSorted = int.Parse(string.Join("", num.ToString().OrderByDescending(c => c).ToArray()));
            Console.WriteLine(numSorted);
        }
    }
}
