using System;
using System.Linq;

namespace CryptiSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var plaintext = "Chill out.";
            Console.WriteLine(Ciphertext(plaintext));
        }

        public static string Ciphertext(string plaintext)
        {
            if (plaintext == "") return "";
            plaintext = string.Concat(plaintext.Where(x => char.IsLetter(x) || char.IsNumber(x))).ToLower();
            int c = (int)Math.Ceiling(Math.Sqrt(plaintext.Length)); 
            int r = plaintext.Length / c;
            Console.WriteLine(c);
            while (plaintext.Length % c != 0)
            {
                plaintext += " ";
            }
            if (plaintext.Length % r == 0) c = plaintext.Length / r;
            else r = plaintext.Length / c;
            
            string[] array = new string[r];

            int m = 0;
            for (int i = 0; i < plaintext.Length; i += c)
            {
                array[m] = plaintext.Substring(i, c); m++;
            };

            string result = "";
            for (int i = 0; i < c; i++)
            {
                result += string.Concat(array.Select(x => x[i]));
                if (i != (c - 1)) result += " ";
            }
            return result;
        }
    }
}

