using System;
using System.Linq;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 232;
            Console.WriteLine(IsPalindrome(num));
        }
        public static bool IsPalindrome(int num)
        {
            var temp = num.ToString();
            return  temp.SequenceEqual(temp.Reverse());
        }
    }
}
