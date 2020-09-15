using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6};
            int k = 3;
            Rotate3(nums, k);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            static void Rotate(int[] nums, int k)
            {
                //swap 3 times
                if (nums.Length == 0)
                {
                    return;
                }

                int start = 0;
                k = k % nums.Length;

                if (k == 0)
                {
                    return; ;
                }

                while (k != 0)
                {
                    if (nums.Length - start > k)
                    {
                        for (int i = start; i < start + k; i++)
                        {
                            int oppositeIndex = nums.Length - k + (i - start);

                            var tmp = nums[i];
                            nums[i] = nums[oppositeIndex];
                            nums[oppositeIndex] = tmp;
                        }

                        start += k;
                        k = k % (nums.Length - start);
                    }
                }

            }
            static void Rotate1(int[] nums, int k)
            {
                //using second array
                int[] num1 = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    num1[i] = nums[k];
                    k++;
                    if (k == nums.Length) k = 0;
                }
                Array.Copy(num1, nums, nums.Length);
            }
            static void Rotate2(int[] nums, int k)
            {
                //moving k times
                while (k != 0)
                {
                    int temp = nums[0];
                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        nums[i] = nums[i + 1];
                    }
                    nums[nums.Length - 1] = temp;
                    k--;
                }

            }
            static void Rotate3(int[] nums, int k)
            {
                if (nums.Length < 1) return;
                //swap 3 times

                Swap(nums,0,nums.Length,nums.Length-1);
                Swap(nums, 0, nums.Length - k,nums.Length-k-1);
                Swap(nums, nums.Length - k, k,nums.Length-1);
                                                                                 
            }
            static void Swap(int[] nums, int startIndex,int length,int lastIndex)
            {
                for (int i = startIndex; i < length / 2+startIndex; i++)
                {
                    int temp = nums[i];
                    nums[i] = nums[lastIndex];
                    nums[lastIndex] = temp;
                    lastIndex--;
                }
            }
        }
    }
}
