using System;
using System.Linq;
using System.Collections.Generic;
//using System.Text.RegularExpressions;

namespace ReturnIndexCapitalLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "eFSDaBiT";

            str.Where(x => char.IsLetter(x) && x == char.ToUpper(x)).Select(x => str.IndexOf(x)).ToArray();

            //int n = 0;
            //int[] array = new int[str.Length];
            //foreach (Match m in Regex.Matches(str, "[A-Z]"))
            //{
            //    array[n] = m.Index;
            //    n++;
            //    Console.WriteLine(m.Index); } 



            //char[] str1 = str.ToCharArray();
            //int[] index = new int[str.Length
            //int n = 0;
            //for (int i = 0; i < str1.Length; i++)
            //{

            //    if (str1[i] == [A-Z]) { index[n] = i;  n++; }
            //}
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }
    }
}
