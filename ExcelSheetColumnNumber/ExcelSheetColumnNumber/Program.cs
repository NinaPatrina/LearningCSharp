using System;

namespace ExcelSheetColumnNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "BBB";
            Console.WriteLine(TitleToNumber(s));
            static int TitleToNumber(string s)
            {
                int result = 0;
                for (int i = 0; i < s.Length;  i++)
                { result = result * 26 + (s[i] - 'A' + 1); }
                return result;

                //double charIndex=0;
                //int result = 0;
                //char[] c = s.ToCharArray();

                //for (int i = 0; i<c.Length ; i++)
                //{
                //    charIndex =(c[c.Length-i-1] - 'A' + 1)*Math.Pow(26, i);
                //    result+=(int)charIndex;
                //  }
                //return result;
            }
        }
    }
}
