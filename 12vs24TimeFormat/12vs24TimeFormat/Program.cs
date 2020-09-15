using System;
using System.Globalization;

namespace _12vs24TimeFormat
{
    class Program
    {
        static void Main()
        {
            string time = "21:00";
            Console.WriteLine(ConvertTime(time));
        }
        public static string ConvertTime(string time)
        {
            string result;
            if (time.Contains("pm")|| time.Contains("am"))
            {
                DateTime dt12 = Convert.ToDateTime(time);
                result = dt12.ToString("H:mm");
            }
            else
            {
                DateTime dt12 = Convert.ToDateTime(time);
                result = dt12.ToString("h:mm tt").ToLower();
            }
            return result;
        }
    }
}
