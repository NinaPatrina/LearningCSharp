using System;
using System.Text.RegularExpressions;

namespace Parseltongue
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Sshe ssselects to eat that apple.";
            Console.WriteLine(IsParselTongue(sentence));
        }
        public static bool IsParselTongue(string sentence)
        {
            string[] array = sentence.ToLower().Split();
            foreach (var word in array)
            {
                if (Regex.Match(word, @"[ss]").Success==false&& Regex.Match(word, @"[^s]").Success==false)
                 return false;
            }
            return true;
        }
    }
}
