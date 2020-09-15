using System;
using System.Text.RegularExpressions;

namespace OneString_InOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "*bc";
            string str2 = "Ican'tsingmyABC";

            Console.WriteLine(Overlap(str1, str2));
        }
        public static bool Overlap(string str1, string str2)
        {
            if (str1.Length > str2.Length) str1 = str1.Substring(str1.Length - str2.Length);
            else str2 = str2.Substring(str2.Length - str1.Length);
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            int i = 0;
            while (i<str1.Length)
            {            
                if (str1[i] == str2[i] || str1[i] == '*' || str2[i] == '*')
                { i++; }
                else return false;
            }
            return true;
            }
           
        }
    }

