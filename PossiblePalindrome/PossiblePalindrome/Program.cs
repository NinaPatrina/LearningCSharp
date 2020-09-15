using System;
using System.Linq;

namespace PossiblePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "acabbaa";
            Console.WriteLine(PossiblePalindrome(str));
        }
        public static bool PossiblePalindrome(string str)
        {
            var result = str.GroupBy(c => c).Where(c=>c.Count()%2!=0).Count();
            return (result <=1);
        }
    }
}
