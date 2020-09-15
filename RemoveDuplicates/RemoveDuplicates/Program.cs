using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = "asdft".ToCharArray();
            Array.Sort(a);
            Console.WriteLine(a);


            Console.WriteLine("input a list");
            List<string> words = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                words.Add(Console.ReadLine());
            }
            for (int i = 0; i < words.Count ; i++)
            {
                CompareAndRemove(i, words[i], words);
            }
            //string[] wordsArray = words.ToArray();
            //for (int i = 0; i < wordsArray.Length; i++)
            //{
            //    Console.WriteLine(wordsArray[i]);
            //}
            static List<string> CompareAndRemove(int n, string word, List<string> words)
            {
                for (int i = n + 1; i < words.Count; i++)
                {
                    if (word == words[i])
                    {
                        words.RemoveAt(i);
                        i--;
                    }
                }
                return words;
            }
        }
    }
}

