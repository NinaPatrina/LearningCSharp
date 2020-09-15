using System;
using System.Globalization;
using System.Threading;

namespace TheDayRobWasBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1970;
            int month = 9;
            int day = 21;
            Console.WriteLine(WeekdayRobWasBornInDutch(year, month, day));
        }
        public static string WeekdayRobWasBornInDutch(int year, int month, int day)
        {
            var dateTime = new DateTime(year, month, day);
            var cultureInfo = new CultureInfo("nl-NL");
            return cultureInfo.DateTimeFormat.GetDayName(
                dateTime.DayOfWeek);
        }
    }
}
