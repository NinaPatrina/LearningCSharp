using System;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 2, 1, 2 };

            Console.WriteLine(SingleNumber(nums));
        }
        static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    i++;
                else
                    return nums[i];
                            }
            return nums[nums.Length-1];
        }
    }
}
