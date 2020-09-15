using System;

namespace RollingCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcde";
            int n = 2;
            Console.WriteLine(RollingCipher(str, n));
        }
        public static string RollingCipher(string str, int n)
        {
            string result = "";
            string alphabeth = "abcdefghijklmnopqrstuvwxyz";
            foreach (var c in str)
            { int m = 1 + c;
                Console.WriteLine(m);
                int i=(alphabeth.IndexOf(c) +n);
                if (i > 25) i -= 26;
                if (i < 0) i += 26;
               result+=alphabeth[i];
            }
            return result;
        }
    }
}
