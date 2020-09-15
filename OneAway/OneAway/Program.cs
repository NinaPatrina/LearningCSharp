using System;

namespace OneAway
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "pbuy";
            string str2 = "pbe";

            Console.WriteLine(OneAway(str1, str2));

            static bool OneAway(string str1, string str2)
            {                
                if (str1.Length == str2.Length - 1)
                    return StringInsert(str1, str2);

                if (str1.Length == str2.Length + 1)
                    return StringInsert(str2, str1);

                if (str1.Length == str2.Length)
                {
                    int numberOfMismatches = 0;
                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str1[i] != str2[i]) numberOfMismatches++;
                        if (numberOfMismatches > 1) return false;
                    }
                    if (numberOfMismatches == 0) return false;

                    return true;
                }
                return false;
            }
            static bool StringInsert(string str1, string str2)
            {
                int numberOfMismatches = 0;
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str1[i - numberOfMismatches] != str2[i]) numberOfMismatches++;
                    if (numberOfMismatches > 1) return false;
                }
                return true;

            }
        }
    }
}
