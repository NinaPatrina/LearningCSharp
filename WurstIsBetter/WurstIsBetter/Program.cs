using System;
using System.Text.RegularExpressions;

namespace WurstIsBetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Sausage fests are like Wurst fests";
            Console.WriteLine(WurstIsBetter(str));
        }
        public static string WurstIsBetter(string str)
        {
            string[] name = { "Kielbasa","Chorizo","Moronga","Salami", "Sausage", "Andouille","Naem","Merguez","Gurka","Snorkers", "Pepperoni"};
            foreach (var item in name)
            {
                string str1 = Regex.Replace(str, item, "Wurst", RegexOptions.IgnoreCase);
                str = str1;
            }

            return str;
        }
    }
}
