using System;
using System.Text.RegularExpressions;

namespace ValidComment
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "/**//**////**/";
            Console.WriteLine(CommentsCorrect(str));
        }
        public static bool CommentsCorrect(string str)
        {
           str =  Regex.Replace(str, @"(/\*\*/)+|(//)+", "").ToString();
           if(str.Length==0) return true;
            return false;
        }
    }
}
