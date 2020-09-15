using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3,2,4 };
            int target = 6;
            foreach (var item in TwoSum(nums, target))
            {
                Console.WriteLine(item);
            }
            
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = { 0, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (Array.Exists(nums, p => p == (target - nums[i])))
                {
                    result[0] = Array.IndexOf(nums, nums[i]);
                    result[1] = Array.IndexOf(nums, target - nums[i]);
                    return result;
                }
               
            }
            return result;

        }
    }
}
