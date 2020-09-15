using System;

namespace MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack obj = new MinStack();
            obj.Push(-2);
            obj.Push(9);
            obj.Push(-3);
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
              
            int param_1 = obj.Top();
            Console.WriteLine(param_1);
            int param_2 = obj.GetMin();
            Console.WriteLine(param_2);
            obj.Pop();
            int param_3 = obj.Top();
            int param_4 = obj.GetMin();
            Console.WriteLine(param_3);
            Console.WriteLine(param_4);

        }
    }
    class MinStack
    {
        private Node head;

        public void Push(int x)
        {
            if (head == null)
                head = new Node(x, x, null);
            else
                head = new Node(x, Math.Min(x, head.min), head);
        }

        public void Pop()
        {
            head = head.next;
        }

        public int Top()
        {
            return head.val;
        }

        public int GetMin()
        {
            return head.min;
        }

        internal class Node
        {
            internal int val;
            internal int min;
            internal Node next;

           internal Node(int val, int min, Node next)
            {
                this.val = val;
                this.min = min;
                this.next = next;
            }
        }
    }
}

