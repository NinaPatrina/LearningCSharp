using System;
using System.Diagnostics;
using System.Text;

namespace StringPerformance
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
            Console.ReadLine();
        }

        private Process process;
        private Stopwatch stopwatch;

        public Program()
        {
            this.process = Process.GetCurrentProcess();
            this.stopwatch = new Stopwatch();
        }

        public void Run(int iterations = 100000)
        {
            this.TestPerformance("StringBuilder", () =>
            {
                var sb = new StringBuilder();
                for (int i = 0; i < iterations; i++)
                {
                    sb.Append((i % 10).ToString());
                }
            });

            this.TestPerformance("String", () =>
            {
                var str = "";
                for (int i = 0; i < iterations; i++)
                {
                    str += (i % 10).ToString();
                }
            });
        }

        private void TestPerformance(string methodName, Action action)
        {
            GC.Collect();
            stopwatch.Restart();

            action();

            Console.WriteLine($"{methodName} performance: ");
            Console.WriteLine($"  Time: {stopwatch.Elapsed}");
            Console.WriteLine($"  Memory: {this.Memory}");
            Console.WriteLine();
        }

        private string Memory
        {
            get
            {
                var inMb = process.PrivateMemorySize64 / 1024.0 / 1024.0;
                return string.Format("{0:0.00} MB", inMb);
            }
        }
    }
}
