using System;
using System.Linq;

namespace Switcharoo
{
    class Program
    {
        static void Main(string[] args)
        {
            object str = "cat";
            Console.WriteLine(FlipEndChars(str));
        }
        public static string FlipEndChars(object str)
        {
            str.GetType();
            Console.WriteLine(str.GetType());
            string str1=str.ToString();
            if (str1.Length<2) return "Incompatible.";
            string beginning = str1.Substring(0,1);
            string end = str1.Substring(str1.Length - 1);
            if (beginning == end) return "Two's a pair.";
            string str2 = str1.Substring(1, str1.Length-2);
            string result = end+str2+beginning;
            return result;
        }
    }
}
