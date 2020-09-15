using System;

namespace RotatingString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "bbbacddceeP";
            string str2 = "ceebbbbacdd";
            Console.WriteLine(RotateString(str1,str2));

            static bool RotateString(string A,string B)
            {
                if (A.Length != B.Length) return false;
                if (A.Length == 0) return true;

                for (int i = 0; i < A.Length; i++)
                {
                    A = A.Substring(1, A.Length - 1) + A[0];
                    if (string.Equals(B, A)) return true;
                }
             
                return false;
                
            }
        }
    }
}
