using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace camelCase___snake_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello_edabit_replace";
            string str2 = "helloEdabitReplace";

            Console.WriteLine(ToSnakeCase(str));
            Console.WriteLine(ToCamelCase(str2));
        }
        public static string ToSnakeCase(string str)
        {
            string[] array = str.Split('_');
            string result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
               char[] a=  array[i].ToCharArray();
                a[0] = char.ToUpper(a[0]);
                string s = new string(a);
                result += s;
                            }
            return result;
        }
        public static string ToCamelCase(string str)
        {
            string r = @"(?=[A-Z])";
            string result = "";
            foreach (string s in Regex.Split(str, r))
            { result = result + s + "_"; }
            return result.ToLower().TrimEnd('_');

            //return Regex.Replace(str, @"[\p{Lu}]","_");

        }
    }
}
