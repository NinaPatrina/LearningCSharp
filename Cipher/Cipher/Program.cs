using System;
using System.Linq;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var minefield = new[]
        {
            " *  * ",
            "  *   ",
            "    * ",
            "   * *",
            " *  * ",
            "      "
        };
            foreach (var item in Annotate(minefield))
            {
            Console.WriteLine(item);
                            }

        }
           
         static string[] Annotate(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    int n = 0;
                    if (i > 0) n += GoUp(i, j, input);
                    if (i > 0 && j < input[i].Length - 1) n += GoUpRight(i, j, input);
                    if (i > 0 && j > 0) n += GoUpLeft(i, j, input);
                    if (j < input[i].Length - 1) n += GoRight(i, j, input);
                    if (j > 0) n += GoLeft(i, j, input);
                    if (i < input.Length - 1) n += GoDown(i, j, input);
                    if (i < input.Length - 1 && j < input[i].Length - 1) n += GoDownRight(i, j, input);
                    if (i < input.Length - 1 && j > 0) n += GoDownLeft(i, j, input);
                    Console.WriteLine(n);
                    if (n > 0) input[i]=input[i].Insert(j, n.ToString()).Remove(j + 1, 1);
                }
            }
            return input;

        }
        static int GoUp(int i, int j, string[] input)
        {
            if (input[i - 1].Substring(j, 1) == "*") return 1;
            else return 0;
        }
        static int GoUpRight(int i, int j, string[] input)
        {
            if (input[i - 1].Substring(j + 1, 1) == "*") return 1;
            else return 0;
        }
        static int GoUpLeft(int i, int j, string[] input)
        {
            if (input[i - 1].Substring(j - 1, 1) == "*") return 1;
            else return 0;
        }
        static int GoRight(int i, int j, string[] input)
        {
            if (input[i].Substring(j + 1, 1) == "*") return 1;
            else return 0;
        }
        static int GoLeft(int i, int j, string[] input)
        {
            if (input[i].Substring(j - 1, 1) == "*") return 1;
            else return 0;
        }
        static int GoDown(int i, int j, string[] input)
        {
            if (input[i + 1].Substring(j, 1) == "*") return 1;
            else return 0;
        }
        static int GoDownRight(int i, int j, string[] input)
        {
            if (input[i + 1].Substring(j + 1, 1) == "*") return 1;
            else return 0;
        }
        static int GoDownLeft(int i, int j, string[] input)
        {
            if (input[i + 1].Substring(j - 1, 1) == "*") return 1;
            else return 0;
        }

    }
}
