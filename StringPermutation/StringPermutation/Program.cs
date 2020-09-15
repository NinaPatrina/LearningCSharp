using System;
using System.Linq;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcdef1";
            string str2 = "abcdfe2";
            Console.WriteLine(str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c)));


            Console.WriteLine(PermutationCheck(str1, str2));

            static bool PermutationCheck(string str1, string str2)
            {if (str1.Length != str2.Length) return false;

                int[] check = new int[128];
                foreach (var c in str1)
                {
                    check[(int)c]++;
                                    }
                foreach (var d in str2)
                {
                    check[(int)d]--;
                    if (check[(int)d] < 0) return false;
                                    }
                return true;

            }
        }
    }
}
