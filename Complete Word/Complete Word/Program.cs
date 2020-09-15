using System;
using System.Linq;

namespace Complete_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial = "btl";
            string word = "beautiful";
            Console.WriteLine(CanComplete(initial, word));
        }
        public static bool CanComplete(string initial, string word)
        {
            //bool a =initial.All(c => word.Contains(c));
            string duplicates= string.Concat(word.Intersect(initial));
            return initial == duplicates;
            //foreach (var c in duplicates)
            //    Console.WriteLine(c);



        }
    }
}
