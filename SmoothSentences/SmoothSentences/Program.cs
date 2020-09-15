using System;

namespace SmoothSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string smooth = "Marta Appreciated deep perpendicular right trapezoids";
            Console.WriteLine(IsSmooth(smooth));
        }
        public static bool IsSmooth(string sentence)
        {
            string[] words = sentence.ToLower().Split();
            for (int i = 0; i < words.Length-1; i++)
            {
                if (words[i].EndsWith(words[i + 1][0].ToString())==false) return false;
            }
            return true;
        }

    }
}
