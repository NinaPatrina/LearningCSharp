using System;

namespace EdabitEasy1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doubleLetter = false;
           
            Console.WriteLine("type a word");
            string word = Console.ReadLine();
            string doubleWord = "";

            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == word[i + 1])
                    doubleLetter = true;
            }
            Console.WriteLine(doubleLetter);
            
            for (int i = 0; i < word.Length; i++)
                doubleWord = doubleWord + word[i]+word[i];
                      
            Console.Write(doubleWord);
        }
    }
}

