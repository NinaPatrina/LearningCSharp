using System;
using System.Linq;

namespace PalindromeDescendant
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 11211230;
            Console.WriteLine(PalindromeDescendant(num));
        }
        public static bool PalindromeDescendant(int num)
        {
            string num1 = num.ToString();
            while (num1.Length >= 2)
            {
                Console.WriteLine(num1);
                if (Palindrome(num1)) return true;
                string temp = "";
                for (int i = 0; i < num1.Length - 1; i += 2)
                {
                    temp += int.Parse(num1[i].ToString()) + int.Parse(num1[i + 1].ToString());

                }
                if (num1.Length > 2) num1 = temp;
                else num1 = "";
            }
            return false;

        }
        public static bool Palindrome(string num)
        { return num.SequenceEqual(num.Reverse()); }

    }
}
