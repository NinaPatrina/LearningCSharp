using System;
using System.Text;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aBCDEFGHIJKLMNOP";

            Console.WriteLine(CompressedStr(str));

            static string CompressedStr(string str)
            {
                StringBuilder sb = new StringBuilder();
                int i = 0;
                while (i < str.Length)
                {
                    sb.Append(str[i]);
                    if (sb.Length > str.Length) return str;
                    int count = 1;
                    while ((i < str.Length - 1)&&(str[i] == str[i + 1]))
                    {
                        i++; count++;
                    }
                    i++;
                    sb.Append(count);
                    Console.WriteLine(sb.ToString());
                }
                return sb.Length < str.Length ? sb.ToString() : str;

            }
        }
    }
}
