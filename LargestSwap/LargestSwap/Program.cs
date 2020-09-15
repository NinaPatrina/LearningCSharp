using System;

namespace LargestSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 27;
            int n2 = number / 10;
            //int n3 = n2 * 10 + n2;
            //if (number <= n3)
            //    Console.WriteLine(true);
            //else Console.WriteLine(false);
                        // can improve it
            int n3 = number % 10;
            if (n2 >= n3)
                Console.WriteLine(true);
            else Console.WriteLine(false);
            
        }
    }
}
