using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            String letters = "Hello World!";
            string newLetters = String.Concat(letters.Select(c => c.ToString() + c.ToString()));
            Console.WriteLine(newLetters);

            char a = letters[0];
            char b = letters[^1];
            string v = letters.TrimEnd(b).TrimStart(a);
            Console.WriteLine(v);

            string palindrom = "mother";

            bool result = palindrom.SequenceEqual(palindrom.Reverse());


            //char[] rev1 = reverse.ToArray();

            //foreach (var c in reverse)
            //{
            //    Console.Write(c);
            //}
            //bool result = true;
            //for (int i = 0; i < rev1.Length; i++)
            //{
            //    if (rev1[i] != pal[i])
            //    { result = false; }
            //}
            if (result == false)
            { Console.WriteLine("   {0}   is not a palindrom", palindrom); }
            else
            { Console.WriteLine("   {0}    is a palindrom", palindrom); }


            // 4letters words

            string[] array = { "Ryan", "Kieran", "Jason", "Matt" };
            var newarray = array.Where(c => c.Length == 4).ToArray();
            foreach (var c in newarray)
            {
                Console.WriteLine(c);
            }

            string[] isBetween = { "bookend", "boolean", "boost"};
            var newIsBetween = isBetween.OrderBy(s => s).ToArray();
            if (isBetween[1] == newIsBetween[2])
                Console.Write("true");
            else Console.Write("false");

            //foreach (var s in newIsBetween)
            //{
            //    Console.WriteLine(s);
            //}


        }
    }
}
