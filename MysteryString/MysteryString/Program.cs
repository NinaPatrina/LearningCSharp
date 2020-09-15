using System;

namespace MysteryString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A4B5C2";
            Console.WriteLine(MysteryFunc(str));
        }
        public static string MysteryFunc(string str)
        {
            string result = "";
            char[] array = str.ToCharArray();
            for (int i = 0; i < array.Length - 1; i += 2)
            {
                int n = int.Parse(str[i + 1].ToString());
                for (int m = 0; m < n; m++)
                {
                    result += array[i];
                }
            }
            return result;
        }
    }
}
