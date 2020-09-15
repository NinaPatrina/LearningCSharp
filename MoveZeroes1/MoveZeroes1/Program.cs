using System;

namespace MoveZeroes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 0, 12 };
            MoveZeroes(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        static void MoveZeroes(int[] nums)
        {
            int m = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) nums[m] = nums[i];
                m++;
            }
            for (int j = m; j < nums.Length; j++)
            {
                nums[j] = 0;
            }
            //for (int i = 0; i < nums.Length; i++)
            // {
            //     Console.WriteLine(nums[i]);
            // }
        }
    }
}
