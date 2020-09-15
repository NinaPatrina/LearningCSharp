using System;

namespace SimplifiedFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "4/6";
            Console.WriteLine(Simplify(str));
        }
        public static string Simplify(string str)
        {
            string[] num = str.Split('/');
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            int c = a == 0 ? b : a;
            a = int.Parse(num[0])/ c;
            b = int.Parse(num[1])/ c;

            return b == 1 ? a.ToString(): a.ToString()+"/"+b.ToString();

        }
    }
}
