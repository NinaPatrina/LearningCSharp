using System;
using System.Linq;

namespace PalindromTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int h1 = 2;
            int m1 = 12;
            int s1 = 22;
            int h2 = 4;
            int m2 = 35;
            int s2 = 10;
            Console.WriteLine(PalendromeTimestamps(h1,m1,s1,h2,m2,s2));
        }
         static int PalendromeTimestamps(int h1, int m1, int s1, int h2, int m2, int s2)
        {
            var t1 = new TimeSpan(h1,m1,s1);
            var t2 = new TimeSpan(h2, m2, s2);
            int result = 0;
            while (t1 <= t2)
            {
                string t = t1.ToString();
                if (t.SequenceEqual(t.Reverse())) result++;
                t1 = t1.Add(TimeSpan.FromSeconds(1));

            }
            return result;

        }
    }
}
