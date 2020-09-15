using System;
using System.Text;

namespace ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type something");
            string word = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                var c = word[i];
                sb.Append(c); // sb += c;

            }
            Console.WriteLine(sb.ToString());
        }

    }
}

