using System;

namespace CapitalFirstLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this is a title";
            Console.WriteLine(MakeTitle( str));
        }
        public static string MakeTitle(string str)
        {
            char[] array = str.ToCharArray();
            array[0] = char.ToUpper(array[0]);
            for (int i = 1; i < array.Length; i++)
            {if (array[i] == ' ') array[i+1]=char.ToUpper(array[i + 1]);
                        }
            return string.Concat(array);

            //string[] words = str.Split();
            //string[] temp = new string[words.Length];
            //foreach (string word in words)
            //{
            //    char a = word[0];
            //    string letter = char.ToUpper(word[0]).ToString();
            //    string temp = word.Insert(1, letter);
            //    string word = temp.Remove(0, 1);

            //}
            //string together = string.Join(" ", words);
            //    return together;
        }
    }
}
