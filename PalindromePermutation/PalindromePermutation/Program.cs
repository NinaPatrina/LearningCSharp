using System;

namespace PalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "zlaco Coa";
            Console.WriteLine(PalindromePermutation(str));

            static bool PalindromePermutation(string str)
            {
                str = str.ToLower().Replace(" ","");

                int[] check = new int[26];
                int result = 0;

                foreach (var letter in str)
                {
                    if (check[letter - 'a'] == 0) { check[letter - 'a']++; result++; }
                    else { check[letter - 'a']--; result--; }
                }
                return (str.Length%2!=0&& result == 1)||(str.Length % 2 == 0 && result == 0);
            }
        }
    }
}
