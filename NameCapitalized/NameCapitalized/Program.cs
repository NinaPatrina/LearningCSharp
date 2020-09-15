using System;
using System.Linq;

namespace NameCapitalized
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "samuel", "MABELLE", "leTTitia", "MEridith" };
            foreach (var item in CapMe(arr))
            {
                Console.WriteLine(item);
            }
        }
        public static string[] CapMe(string[] arr)
        {
            return arr.Select(c=>string.Concat(c.Substring(0, 1).ToUpper(), c.Substring(1).ToLower())).ToArray();
        }
        
    }

}

