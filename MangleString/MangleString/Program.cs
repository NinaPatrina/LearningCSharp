using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace MangleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox.";
            Console.WriteLine(Mangle(str));
        }
        public static string Mangle(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in str.ToCharArray())
            {
                if (char.IsLetter(c))
                {
                    if (c + 1 == 'a' | c + 1 == 'e' | c + 1 == 'i' | c + 1 == 'o' | c + 1 == 'u') sb.Append(Convert.ToChar(c - 31));
                    else if (c == 'z') sb.Append(Convert.ToChar('A'));
                    else if (c == 'Z') sb.Append(Convert.ToChar('A'));
                    else sb.Append(Convert.ToChar(c + 1));
                }
                else sb.Append(Convert.ToChar(c));
            }
            return sb.ToString();
        }
    }
}
