using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using System.Threading.Tasks;

namespace ParallelLF
{
    class Program
    {
        static void Main(string[] args)
        {
            var texts = Enumerable.Repeat("abc", 1000);
            var lf = new Dictionary<char, int>();
            var lockObject = new object();

            Parallel.ForEach(texts, text =>
            {
                foreach (var c in text.ToLower())
                {
                    lock (lockObject)
                    {
                        if (lf.ContainsKey(c)) lf[c]++;
                        else if (char.IsLetter(c)) lf.Add(c, 1);
                    }
                }
            });

            foreach (var item in lf)
            {
                Console.WriteLine(item);
            }
        }
    }
}
