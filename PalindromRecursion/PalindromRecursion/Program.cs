using System;

namespace PalindromRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "heloleh";
            Console.WriteLine(Pal(s));

        }
        static bool Pal(string s)
        {
            Console.WriteLine(s);

            if (s.Length <= 1) return true;
            if (s[0] != s[s.Length - 1]) return false;
            else
            {
                s = s.Substring(1, s.Length - 2);
                return Pal(s);
            }
        }
        

    }
}

