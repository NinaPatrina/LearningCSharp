using System;
using System.Collections;
using System.Collections.Generic;

namespace HanoiTower
{
    class Program
    {

        public static class TowerOfHanoi
        {
            public static Queue<int>[] q = new Queue<int>[4];
            static void Main(string[] args)
            {
                q[1] = new Queue<int>();
                q[2] = new Queue<int>();
                q[3] = new Queue<int>();

                q[1].Enqueue(1);
                q[1].Enqueue(2);
                q[1].Enqueue(3);
                int n = 3;
                Hanoi(n, 1, 2, 3);
                static void Hanoi(int n, int A, int C, int B)
                {
                    if (n == 0) return;
                    else
                    {
                        Hanoi(n - 1, A, B, C);
                        int d = q[A].Dequeue();
                        q[B].Enqueue(d);
                        Console.WriteLine($"transfer {n} from {A} to {C}");
                        Hanoi(n - 1, B, C, A);
                    }
                }
                /* static void Hanoi(int n, char A, char C, char B)
                 {
                     if (n == 0) return;
                     else
                     {
                         Hanoi(n - 1, A, B, C);
                         Console.WriteLine($"transfer {n} from {A} to {C}");
                         Hanoi(n - 1, B, C, A);
                     }
                 }
                 */
            }
        }
    }
}
