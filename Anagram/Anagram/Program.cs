using System;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "cristian";
            string str2 = "Cristina";
            Console.WriteLine(IsAnagram(str1,str2));
        }
        public static bool IsAnagram(string str1, string str2)
        {
            return  str1.ToLower().OrderBy(c=>c).SequenceEqual(str2.ToLower().OrderBy(c => c));
             
        }
    }
}
