using System;
using System.Text;
namespace ConvertToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputword = "Big Boy";
            Console.WriteLine(ConvertToHex(inputword));
        }
        public static string ConvertToHex(string inputword)
        {
            string result = "";
            foreach (var item in inputword.ToCharArray())
            {
               result+= string.Format("{0:x2}", Convert.ToInt32(item));
            }
            return result;
        }
    }
}
