using System;
using System.Collections;
using System.Collections.Generic;

namespace SortStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(10);
            s1.Push(1);
            s1.Push(5);
            s1.Push(20);

            SortStack(s1);

            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());


            static void SortStack(Stack<int> s1)
            {
                Stack<int> s2 = new Stack<int>();
                while (s1.Count != 0)
                {
                    var temp = s1.Pop();
                    while (s2.Count != 0 && s2.Peek() > temp)
                    {
                        s1.Push(s2.Pop());
                    }
                    s2.Push(temp);

                }
                while (s2.Count != 0)
                {
                    s1.Push(s2.Pop());
                }

            }
        }
    }
}
