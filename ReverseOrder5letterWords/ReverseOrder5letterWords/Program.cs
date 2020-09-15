using System;
using System.Linq;
using System.Text;
namespace ReverseOrder5letterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a typical sentence.";
            Console.WriteLine(Reverse(str));
        }
        public static string Reverse(string str)
        {

            return string.Join(" ", str.Split(' ').Select(w => w.Length > 4 ? string.Concat(w.Reverse()) : w));
            //string[] words= str.Split();
            // StringBuilder result = new StringBuilder();
            // foreach (var s in words)
            // {
            //     if (s.Length >= 5) result.Append(s.Reverse().ToArray());
            //     else result.Append(s);
            //     result.Append(" ");
            // }
            // return result.ToString().TrimEnd();
        }
    }
}
