using System;

namespace BitManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            uint bin = 1010010100;
            Console.WriteLine(ReverseBits(bin));
            int x = 1;
            int y = 8;
            int z = x ^ y;
            int n = 0;
            while (z > 0)
            {
                z &= z - 1;
                ++n;
            }
                    Console.WriteLine(n);
        }
        static uint ReverseBits(uint n)
        {
                n = (n >> 16) | (n << 16);
                n = ((n & 0xff00ff00) >> 8) | ((n & 0x00ff00ff) << 8);
                n = ((n & 0xf0f0f0f0) >> 4) | ((n & 0x0f0f0f0f) << 4);
                n = ((n & 0xcccccccc) >> 2) | ((n & 0x33333333) << 2);
                n = ((n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1);
                return n;
        }
    }
}
