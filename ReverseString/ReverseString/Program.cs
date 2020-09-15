using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = {};
            foreach (var item in ReverseString(s))
            {
                Console.WriteLine(item);
            }

            static char[] ReverseString(char[] s)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    char temp = s[i];
                    s[i] = s[s.Length - 1 - i];
                    s[s.Length - 1 - i] = temp;
                }
                return s;
            }
        }
    }
}
