using System;

namespace CompoundingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "RqaEzty";
            Console.WriteLine(Accum(str));
        }
        public static string Accum(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result = result + char.ToUpper(str[i]) + new string(char.ToLower(str[i]), i) + '-';
            }

            return result.TrimEnd('-');
        }

    }
}
