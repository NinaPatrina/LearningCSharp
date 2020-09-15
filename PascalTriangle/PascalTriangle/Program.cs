using System;
using System.Collections.Generic;
using System.Linq;

namespace Pascal
{
    class Program
    {
        static int[][] memo = new int[3][];
        static void Main(string[] args)
        {
            int rows = 3;

            //memo =(int[][])Calculate(rows);
            foreach (var item in Calculate(rows))
            {
                foreach (var i in item)
                {
                    Console.Write(i.ToString());
                }
                Console.WriteLine(" ");
            }
        }
          
        public static IEnumerable<IEnumerable<int>> Calculate(int rows)
        {

            if (rows == 0) yield break;
            if (rows == 1)
            {
                memo[1] = new int[1];
                memo[1][0] = 1;
                yield return memo[1];
                yield break;
            }
            int i = 0;
            int temp = 0;
            if (memo[rows] == null)
            {
                memo[rows] = new int[rows];
                var item = Calculate(rows - 1).Last();
                foreach (var d in item)
                {
                    memo[rows][i] = temp + d;
                    temp = d;
                    i++;
                }
                memo[rows][i] = temp;
            }
            yield return memo[rows];
        }
    }
    }

