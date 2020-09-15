using System;
using System.Text;
using System.Text.RegularExpressions;
namespace CharCode
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = 'A';
            Console.WriteLine(CounterpartCharCode(symbol));
        }
        public static int CounterpartCharCode(char symbol)
        {
            if (char.IsLetter(symbol))
            {
                char ch = char.IsLower(symbol) ? char.ToUpper(symbol) : char.ToLower(symbol);
                return (int)ch;
            }
            return (int)symbol;
        }
    }
}
