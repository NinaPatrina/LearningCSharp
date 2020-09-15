using System;

namespace edabit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine(HasSpaces(sentence));
        }
        public static bool HasSpaces(string sentence)
        {
            return sentence.Contains(" ");
        }
    }

}
