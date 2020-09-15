using System;

namespace _1stUniqueCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cc";
            Console.WriteLine(FirstUniqChar(s));
            static int FirstUniqChar(string s)
            {
                foreach (char c in s)
                {
                    if (s.IndexOf(c) == s.LastIndexOf(c)) return s.IndexOf(c);
                }
                return 0;
            }
        }
    }
}
