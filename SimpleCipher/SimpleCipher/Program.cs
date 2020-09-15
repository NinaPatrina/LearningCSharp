using System;
using System.Text;

namespace SimpleCipher
{
    class Program
    {
        static void Main()
        {
            string plaintext = "aaaaaaaaaa";
            Console.WriteLine(Encode(plaintext));
            //Console.WriteLine(Decode(plaintext));

        }
        static string Encode(string plaintext)
        {
            string key = "abcdefghij";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i++)
            {
                int l = plaintext[i] + key[i]+61;
                Console.WriteLine(l);
                Console.WriteLine(key[i]);

                sb.Append(Convert.ToChar(l));
            }

            return sb.ToString();
        }

        static string Decode(string ciphertext)
        {
            string key = "abcdefghij";

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < ciphertext.Length; i++)
            {
                sb.Append(Convert.ToChar(ciphertext[(int)i] + key[(int)i])+61);
            }
            return sb.ToString();
        }
    }
}
