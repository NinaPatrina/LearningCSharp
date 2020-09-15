using System;
using System.Linq;

namespace SameLetterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AABAABAADD";
            string str2 = "SSCSSCSSDA";
            Console.WriteLine(SameLetterPattern(str1, str2));
        }
        public static bool SameLetterPattern(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1.IndexOf(str1.Substring(i, 1), i + 1) != str2.IndexOf(str2.Substring(i, 1), i + 1)) return false;
            }
            return true;


            //Console.WriteLine(str1.IndexOf(str1[0].ToString(), 2));
            //if (str1.Length != str2.Length) return false;
            //return RewriteString(str1) == RewriteString(str2);
        }
        //public static string RewriteString(string str)
        //{
        //    var st1 = str.Distinct();
        //    char i = 'a';
        //    foreach (var c in st1)
        //    {
        //        str = str.Replace(c, i);
        //        i++;
        //    }
        //    return str;
        //}
    }
}

