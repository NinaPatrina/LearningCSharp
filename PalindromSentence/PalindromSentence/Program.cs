using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PalindromSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!";
            string str1 = str.ToLower();
            Console.WriteLine(IsPalindrome(str));
        }
        public static bool IsPalindrome(string str)
        {
            var str1 = Regex.Replace(str, "[^a-zA-Z]", "");
            string str2 = "";
            for (int i = 0; i < str1.Length; i++)
            {
                str2 = str2 + char.ToLower(str1[i]);
            }
            return str2.SequenceEqual(str2.Reverse());
        }
    }
}
