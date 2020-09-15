using System;

namespace Briefcase_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            string current = "4089";
            string target = "5672";

            Console.WriteLine(MinTurns(current, target));
        }
        public static int MinTurns(string current, string target)
        {
            int total = 0;

            for (int i = 0; i < 4; i += 1)
            {
                int largest = Math.Max(current[i], target[i]);
                int smallest = Math.Min(current[i], target[i]);

                total += Math.Min((largest - smallest), ((smallest + 10) - largest));
            }
            return total;
        }
    }
}
