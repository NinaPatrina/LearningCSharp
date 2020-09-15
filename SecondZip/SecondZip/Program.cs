using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SecondZip
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "846ZIbo";
            int a = 2; int b = 5; int c = -1;
            // Console.WriteLine(findZip(s));
            // Console.WriteLine(IsPlural(s));
            //Console.WriteLine(solutions(a,b,c));
            // Console.WriteLine(Brackets(s));
            // Console.WriteLine(reversedBinaryInteger(a));
            //Console.WriteLine(UniqueFract());
            // Console.WriteLine(GCD(a, b));
            Console.WriteLine(sorting(s));
        }
        static string sorting(string str)
        {
            return string.Concat(str
                .OrderByDescending(c => c / 64)
                .ThenBy(c => c % 32)
                .ThenByDescending(c => c / 32)); 
             
        }
        static int reversedBinaryInteger(int num)
        {
            String str = string.Concat(Convert.ToString(num, 2).Reverse());
            return Convert.ToInt32(str, 2);
        }
        static int findZip(string str)
        {
            Match m = Regex.Match(str, @"zip");
            Match m2 = m.NextMatch();
            return m2.Index == 0 ? -1 : m2.Index;
        }
        static bool IsPlural(string word)
        {
            return word.EndsWith('s');
        }
        static int solutions(int a, int b, int c)
        {
            if (b * b - 4 * a * c > 0) return 2;
            if (b * b - 4 * a * c < 0) return 0;
            else return 1;
        }
        static bool Brackets(string str)
        {
            var br = new Stack<char>();
            foreach (var s in str)
            {
                if (s == '(')
                    br.Push(s);

                if (s == ')')
                {
                    if (br.Count == 0)
                        return false;
                    else
                        br.Pop();
                }
            }
            return true;

        }
        static double UniqueFract()
        {
            double sum = 0;
            for (int i = 1; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (GCD(i, j) == 1)
                    {
                        sum += ((double)i / j);
                    }
                }
            }
            return sum;
        }
        static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            return a == 0 ? b : a;

        }
    }
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }
    }
}
