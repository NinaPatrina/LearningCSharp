using System;

namespace MaximumSubarray
{
    class Program
    {
        static void Main()
        {
            int[] nums = {};
            Console.WriteLine(MaxSubArray(nums));
        }
        public static int MaxSubArray(int[] nums)
        {if (nums.Length == 0) return 0;
            int global_max = nums[0];
            int local_max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                local_max = Math.Max(local_max + nums[i], nums[i]);
                global_max = Math.Max(global_max, local_max);
            }
            return global_max;

        }
    }
}
