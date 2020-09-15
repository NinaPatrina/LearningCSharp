using System;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 0, 1, 0, 3, 12,0,99,0,0,0,7,8 };
            int m = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i]!=0)
                {
                    n[m] = n[i];
                    m++;
                }
            }
            for (int i = m; i < n.Length; i++)
            {
                n[i] = 0;
            }

            foreach (var item in n)
            {
                Console.WriteLine(item);
            }
         
        }
    }
}
