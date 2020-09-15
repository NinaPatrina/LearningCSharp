using System;

namespace RepeatLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a word");
            string word = Console.ReadLine();

            Console.WriteLine("Give me a number");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatLetterNTimes(word, n));

        }
        static string RepeatLetterNTimes(string word, int n)
        {
            string newWord = "";
            foreach (char c in word)
            {
                for (int i = 0; i < n; i++)
                {
                    newWord = newWord + c;

                }

            }

            return newWord;
        }

    }

}
