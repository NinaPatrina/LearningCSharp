using System;

namespace Maskify
{
    class Program
    {
        static void Main(string[] args)
        {
            string maskify = "516";
            Console.WriteLine(Maskify(maskify));
        }
        public static string Maskify(string str)
        {
            if (str.Length <= 4) return str;
            return str.Substring(str.Length-4).PadLeft(str.Length, '*');
        }
    }
}
