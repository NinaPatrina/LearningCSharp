using System;
using System.Collections.Generic;
using System.Text;

namespace RationalEdabit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 450;
            Console.WriteLine(Rational(a, b));
        }
        static string Rational(int a, int b)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(a / b);
            sb.Append(".");
            var rem = new List<int>();
            a = a % b;
            do
            {
                rem.Add(a % b);
                a = a * 10;
                sb.Append(a / b);
                a = a % b;
            }
            while (a != 0 && !rem.Contains(a));
            if (a != 0)
            {
                sb.Append(")");
                string result = sb.ToString();
                Predicate<int> p = x => x == a;
                int index = rem.FindIndex(p)+2;
                sb.Insert(index, "(");
            }
            return sb.ToString();
        }
    }
}
