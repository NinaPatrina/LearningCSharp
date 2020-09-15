using System;
using System.Linq;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 100, 2, 100, 100, 4, 100 };
            Console.WriteLine(MajorityElement(nums));
        }
        public static int MajorityElement(int[] nums)
        {
            var sorted=  nums.OrderBy(c => c).ToArray();
            return  int.Parse(sorted[nums.Length / 2].ToString());
        }
    
}
}
