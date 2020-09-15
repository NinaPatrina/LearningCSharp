using System;

namespace MiddleCharachters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "test";
            Console.WriteLine(GetMiddle(str));
        }
        public static string GetMiddle(string str)
        {
            if (str.Length % 2 == 0)
            {
                char[] result = new char[2];
                result[0] = str[(str.Length / 2)-1];
                result[1] = str[str.Length / 2];
                string res = new string(result);
                return res;
            }
            else
            {
                char result = str[str.Length / 2];
                string res = result.ToString();
                return res;
                            }
        }
    }
}
