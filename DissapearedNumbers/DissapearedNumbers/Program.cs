using System;
using System.Collections;
using System.Collections.Generic;

namespace DissapearedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            foreach (var item in FindDisappearedNumbers(nums))
            {
                Console.WriteLine(item);

            }
        }
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]);
                if (nums[index - 1] > 0) nums[index - 1] = nums[index - 1] * (-1);

            }
            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) result.Add(i + 1);
            }
            return result;
        }
    }
}
