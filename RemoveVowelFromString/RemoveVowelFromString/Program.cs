using System;
using System.Text.RegularExpressions;
using System.Text;

namespace RemoveVowelFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Happy Birthday";
            Console.WriteLine(ReverseCase(str));
            Console.WriteLine(RemoveVowels(str));
        }
        public static string RemoveVowels(string str)
        {
            return Regex.Replace(str, "[aouei]", "");
        }
        public static string ReverseCase(string str)
        {
            char[] arr = str.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (var item in arr)
            {
                if (Char.IsUpper(item) == true) sb.Append(Char.ToLower(item));
                else if (Char.IsLower(item) == true) sb.Append(Char.ToUpper(item));
                else sb.Append(item);
                            }
            return sb.ToString();
        }
    }
}