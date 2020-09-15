using System;
using System.Text.RegularExpressions;

namespace FormatPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone = "653 - AAD - THIS";
            Console.WriteLine(TextToNum(phone));
        }
        public static string TextToNum(string phone)
        {
            string phone1 = Regex.Replace(phone, "[(A)(B)(C)]", "2");
            string phone2 = Regex.Replace(phone1, "[(D)(E)(F)]", "3");
            string phone3 = Regex.Replace(phone2, "[(G)(H)(I)]", "4");
            string phone4 = Regex.Replace(phone3, "[(J)(K)(L)]", "5"); 
            string phone5 = Regex.Replace(phone4, "[(M)(N)(O)]", "6");
            string phone6 = Regex.Replace(phone5, "[(P)(S)(Q)(R)]", "7");
            string phone7 = Regex.Replace(phone6, "[(TUV)(U)(V)]", "8");
            string phone8 = Regex.Replace(phone7, "[(W)(Z)(X)(Y)]", "9");
            return phone8;








        }
    }
}
