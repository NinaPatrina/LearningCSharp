using System;
using System.Linq;
using System.Text;

namespace HighestLowestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "1 2 -3 4 5";

            Console.WriteLine(HighLow(numbers));
        }
        public static string HighLow(string str)
        {
            var str1 = str.Split().Select(s => int.Parse(s));
            

                StringBuilder sb = new StringBuilder();
            sb.Append(str1.Max().ToString());
            sb.Append(" ");
            sb.Append(str1.Min().ToString());

            return sb.ToString();
        }
    }
}
