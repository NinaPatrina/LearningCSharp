using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Slag(string strPrefix, int iSummatorMax, int iLeft, int iRight, int n)
        {
            string strPrefix0 = string.Concat(strPrefix, iLeft.ToString());
            string result = string.Concat(strPrefix0, iRight.ToString());
            if (result.Length <= n)
            { Console.WriteLine(result); }

            iSummatorMax = Math.Max(iLeft, 0);
            if (iRight > iSummatorMax)
            {
                for (int i = 1; i <= iRight / 2; i++)
                {
                    if (i >= iSummatorMax)
                        Slag(strPrefix0, 0, i, iRight - i,n);
                }
            }
        }
             static void Main(string[] args)
        {
            int sum = 7;
            int n = 6;
            for (int i = 0; i <= sum / 2; i++)
            {
                Slag("", 0, i, sum - i,n/2);
            }
          
        }
    }
}
