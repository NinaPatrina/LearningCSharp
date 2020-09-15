using System;

namespace ReplaceVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string");
            string word = (Console.ReadLine());
            Console.WriteLine("Input a symbol");
            string symbol = (Console.ReadLine());
            string[] vowels = new string[5]{"a","o","u","e","i"};

            foreach (string vowel in vowels)
            {
                string newWord = word.Replace(vowel, symbol);
                word = newWord;
            }

            Console.WriteLine(word);
        }
    }
}
