using System;

namespace BuySellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 7,1,5,3,6,4 };
            Console.WriteLine(MaxProfit(prices));
        }
        public static int MaxProfit(int[] prices)
        {
            //best solution

            int maxCur = 0, max_global = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                maxCur = Math.Max(0, maxCur + prices[i] - prices[i - 1]);
                max_global = Math.Max(maxCur, max_global);
            }
            return max_global;

            //kendal's algorithm for max sum for subarray 

            //int max_current = prices[0];
            //int max_global = prices[0];
            //for (int i = 1; i < prices.Length - 1; i++)
            //{
            //    max_current = Math.Max(prices[i], max_current + prices[i]);
            //    max_global = Math.Max(max_global, max_current);
            //}
            //return max_global;

            // my solution 

            //if (prices.Length == 0) return 0;
            //int min = prices[0];
            //int profit = 0;
            //for (int i = 0; i < prices.Length-1; i++)
            //{
            //    if (prices[i+1] - min > profit) profit = prices[i+1] - min;

            //    if (prices[i+1] - min < 1) min = prices[i+1];
            //} 
            //return profit;
        }
    }
}
