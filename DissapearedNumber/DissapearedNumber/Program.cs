using System;
using System.Collections.Generic;

namespace DissapearedNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr= new int[] {4, 3, 2, 7, 8, 2, 3, 1 };
            foreach (var item in Dissapeared(arr))
            {
                Console.WriteLine(item);
            }
        }
        static List<int> Dissapeared(int[] arr)
        {
            

            foreach (var item in arr)
            {
                int val = Math.Abs(item) - 1;
              if (arr[val]>0)  arr[val] =- arr[val] ;
            }
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) result.Add(i + 1);
            }
            return result;

        }
    }
}
