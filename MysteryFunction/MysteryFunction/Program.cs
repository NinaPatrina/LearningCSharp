using System;
using System.Linq;

namespace MysteryFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(MysteryFunc(num));
        }
        public static int MysteryFunc(int num)
        {
            int temp = int.Parse(string.Join("",num.ToString().OrderBy(c => c)).ToArray());
            return num - temp;
         }
    }
}
