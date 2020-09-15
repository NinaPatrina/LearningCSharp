using System;
using System.Linq;

namespace SmallestTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 977;
            Console.WriteLine(SmallestTransform(num));
        }
        public static int SmallestTransform(int num)
        {
            var num2 = num.ToString().OrderBy(c => c).ToArray();
            int[] diff = new int[num2.Length - 1];
            for (int i = 0; i < diff.Length; i++)
            {
                diff[i] = int.Parse(num2[i + 1].ToString()) - int.Parse(num2[i].ToString());
            }
            int result = 0;
            for (int i = 0; i < diff.Length; i++)
            {
                for (int j = i; j < diff.Length - i; j++)
                {
                    result += diff[j];
                }
            }
            return result;
        }
    }
}
