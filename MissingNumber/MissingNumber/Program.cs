using System;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {};
            Console.WriteLine(MissingNumber(nums));
            static int MissingNumber(int[] nums)
            {
                int j = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                   j+= i+1 - nums[i];
                }
                return j;
            }
        }
    }
}
