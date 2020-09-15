using System;
using System.Linq;

namespace AnagramString
{
    class Program
    {
        static void Main(string[] args)
        {
            string needle = "car";
            string haystack = "race";
            Console.WriteLine(AnagramStrStr(needle, haystack));
        }
        public static bool AnagramStrStr(string needle, string haystack)
        {
            string aa = string.Concat(needle.OrderBy(c => c));
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                string bb = haystack.Substring(i, needle.Length);
                string b = string.Concat(bb.OrderBy(c => c));
                if (aa == b)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
