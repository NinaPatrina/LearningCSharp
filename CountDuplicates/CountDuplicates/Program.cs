using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace CountDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Indivisibilities";
            Console.WriteLine(DuplicateCount(str));
        }
        public static int DuplicateCount(string str)
        {
            string str2 = "";
            List<char> meList = new List<char>();
            foreach (char item in str)
            {
                if (!str2.Contains(item))
                    str2 += item;
                else meList.Add(item);
            }
            return meList.Distinct().Count(); ;
        }
    }
}
