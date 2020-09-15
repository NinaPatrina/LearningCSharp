using System;

namespace StrangePair
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "sparkling";
            string str2 = "groups";
            
            Console.WriteLine(IsStrangePair(str1, str2));
        }
        public static bool IsStrangePair(string str1, string str2)
        {
            if (str1 == "" || str2 == "")
               return str1== str2;
            return str1[0] == str2[str2.Length - 1] && str2[0] == str1[str1.Length - 1];

        }
    }
}
