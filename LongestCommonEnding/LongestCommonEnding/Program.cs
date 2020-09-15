using System;

namespace LongestCommonEnding
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "pitiful";
            string str2 = "beautiful";
            Console.WriteLine(LongestCommonEnding( str1, str2));

        }
        public static string LongestCommonEnding(string str1, string str2)
        {
           var index= Math.Abs(str1.Length-str2.Length);
            if (str1.Length > str2.Length) str1 = str1.Substring(index);
            if (str1.Length < str2.Length) str2 = str2.Substring(index);

            while (str1 != str2)
            {
                str1 = str1.Substring(1);
                str2 = str2.Substring(1);
            }
            return str1;
        }
    }
}
