using System;

namespace GetTheCentury
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1756;
            Console.WriteLine(Century(year));
        }
        public static string Century(int year)
        {
           // string result= (year + 99).ToString().Substring(0, 2);
           //if ((year +99)<2100) return result + "th century";
           //return result +"st century";
            int num = (year +99)/ 100;

            return num > 20 ? $"{num}st century" : num + "th century";


        }
    }
}
