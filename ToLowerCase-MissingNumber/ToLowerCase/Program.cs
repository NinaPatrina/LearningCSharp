using System;
using System.Linq;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "HEllo World";
            char[] str1 = str.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (var item in str1)
            {
                sb.Append(Char.ToLower(item));
            }
            sb.ToString();

            Console.WriteLine(sb);

            int[] nums = new int[] { 1, 2, 3 ,4,6,7,8,9};
            int missingNum = Enumerable.Range(1, 9).Except(nums).First();
            Console.WriteLine(missingNum);



            Console.WriteLine(ContainsDuplicate(nums));

            static bool ContainsDuplicate(int[] nums)
            {
                Array.Sort(nums);
                    for (int i = 0; i < nums.Length-1; i++)
                    {
                        if (nums[i] == nums[i+1])
                        {
                            return true;
                        }
                    }
                      return false;


                
            } }

    }
}
