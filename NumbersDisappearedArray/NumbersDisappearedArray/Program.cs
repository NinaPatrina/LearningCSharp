using System;
using System.Linq;
using System.Collections.Generic;

namespace NumbersDisappearedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };

            var list = FindDisappearedNumbers(nums);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static List<int> FindDisappearedNumbers(int[] nums)
             {
            List<int> ret = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int val = Math.Abs(nums[i]) - 1;
                if (nums[val] > 0)
                {
                    nums[val] = -nums[val];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    ret.Add(i + 1);
                }
            }
            return ret;
        }
        /*
        interface IList<T> : ICollection<T>, IEnumerable<T>
        {
            T this[int index] { get; set; }
            int IndexOf(T item);
            void Insert(int index, T item);
            void Add(T item);
            void RemoveAt(int index);
        
            /**/



    }
}
