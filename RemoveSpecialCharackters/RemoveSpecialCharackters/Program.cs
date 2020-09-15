using System;
using System.Text.RegularExpressions;
namespace RemoveSpecialCharackters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "%fd76$ fd(-)6GvKlO";
            Console.WriteLine(RemoveSpecialCharacters(str));
        }
        static string RemoveSpecialCharacters(string str)
        {
             string result = Regex.Replace(str, @"[^\w \- ]", "");
            return result;
        }
    }
}
