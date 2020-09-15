using System;

namespace ValidName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "H. George Wells";
            Console.WriteLine(ValidName(name));
        }
        public static bool ValidName(string name)
        {
            string[] array = name.Split();
            if (array.Length < 2 || array.Length > 3) return false;
            foreach (var word in array)
            {
                if (char.IsLower(word[0]) ||
                (word.Length == 1) ||
                (word.Length == 2 && word.Contains(".") == false) ||
                (word.Length > 2 && word.Contains("."))) return false;
            }
            if (array[array.Length - 1].Length <= 2) return false;
            if (array.Length == 3 && array[1].Length > 2 && array[0].Length < 3) return false;
            return true;


        }
    }
}
