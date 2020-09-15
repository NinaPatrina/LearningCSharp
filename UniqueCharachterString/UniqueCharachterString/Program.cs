using System;

namespace UniqueCharachterString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"chek&()_+= />?:;}{][""<";
            Console.WriteLine(CheckString(str));

            static bool CheckString(string str)
            {
                bool[] check = new bool[128];

                foreach (char c in str)
                {
                    if (check[(int)c] == true) return false;
                    check[(int)c] = true;
                }
                return true;
            }

        }
    }
}
