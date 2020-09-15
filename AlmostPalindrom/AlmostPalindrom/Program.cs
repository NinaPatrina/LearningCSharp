using System;

namespace AlmostPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdcbg";
            Console.WriteLine(AlmostPalindrome(str));
        }
        public static bool AlmostPalindrome(string str)
        {
            int mistakes = 0;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1-i]) mistakes++;

            }
            return mistakes<=1;
        }
    }
}
