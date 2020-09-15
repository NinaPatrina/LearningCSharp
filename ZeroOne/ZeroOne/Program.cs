using System;
using System.Text;

namespace ZeroOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "zero ONE zero one zero one zero one one two";
            Console.WriteLine(TextToNumberBinary(str));
        }
        public static string TextToNumberBinary(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var word in str.Split())
            {
                if (string.Equals(word, "zero", StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(0);
                };
                if (string.Equals(word, "one", StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(1);
                };
                      }
            while(sb.Length%8!=0)
            { sb.Remove(sb.Length -sb.Length%8, 1); }
            return sb.ToString();

        }
    }
}
