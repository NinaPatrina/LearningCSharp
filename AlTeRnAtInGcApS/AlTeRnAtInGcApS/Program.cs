using System;

namespace AlTeRnAtInGcApS
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "How are you?";
            Console.WriteLine(AlternatingCaps(str));
        }
        public static string AlternatingCaps(string str)
        {
            char[] ch = str.ToCharArray();
            string result = "";
            int i = 2;
            foreach (var s in ch)
            {
                if (s != ' ')
                {
                    char ch1 = (i % 2 == 0) ? char.ToUpper(s) : char.ToLower(s);
                    result += ch1.ToString();
                    i++;
                }
               else result += s.ToString();

            }

            return result;

        }   }
}

