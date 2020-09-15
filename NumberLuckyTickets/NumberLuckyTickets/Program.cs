using System;
using System.Linq;

namespace NumberLuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            Console.WriteLine(LuckyTicket(n));
        }
        static long LuckyTicket(int n)
        {

            //how many numbers make a sum
            var v = new int[(int)Math.Ceiling(9 * (decimal)n / 2) / 2];
            for (int sum = 0; sum <= Math.Ceiling(9 * (decimal)n / 2) / 2; sum++)
            {
                for (int i = 0; i <= sum / 2; i++)
                {
                    Slag("", 0, i, sum - i, n / 2);
                }
            }
            return 1;
        }
            static void Slag(string strPrefix, int iSummatorMax, int iLeft, int iRight, int n)
            {
                string strPrefix0 = string.Concat(strPrefix, iLeft.ToString());
                string result = string.Concat(strPrefix0, iRight.ToString());
                if (result.Length <= n)
                {
                  result =string.Concat( result.Distinct()).ToString(); 
                if (result.Sum(c=>c)==iRight)
                Console.WriteLine(result); }

                iSummatorMax = Math.Max(iLeft, 0);
                if (iRight > iSummatorMax)
                {
                    for (int i = 1; i <= iRight / 2; i++)
                    {
                        if (i >= iSummatorMax)
                            Slag(strPrefix0, 0, i, iRight - i, n);
                    }
                }
            }
        }
    }



