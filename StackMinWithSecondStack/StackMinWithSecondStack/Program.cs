using System;

namespace StackMinWithSecondStack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackMin obj = new StackMin();
            obj.Push(2147483646);
            //obj.Push(2147483646);
            //obj.Push(2147483647);
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.GetMin());
            //Console.WriteLine(obj.Pop());
            //Console.WriteLine(obj.GetMin());
            //Console.WriteLine(obj.Pop());
            //Console.WriteLine(obj.GetMin());

            //obj.Push(2147483647);
            //Console.WriteLine(obj.GetMin());
            //obj.Push(-2147483648);
            //Console.WriteLine(obj.GetMin());
            //Console.WriteLine(obj.Pop());
            //Console.WriteLine(obj.GetMin());

        }
    }
    public class StackMin
    {
        private StackNode top;
        private StackNode min;

        private sealed class StackNode
        {
            public int data;
            public StackNode next;

            public StackNode(int item)
            {
                this.data = item;
                this.next=null;
            }
        }
        public void Push(int item)
        {
            StackNode nextTop = new StackNode(item);
            nextTop.next = top;
            top = nextTop;

            StackNode nextMin = new StackNode(item);
            if (min == null)
            {
                min = nextMin;
                return;
            }

            if (nextMin.data <= min.data)
            {
                nextMin.next = min;
                min = nextMin;
            }
        }

        public int Pop()
        {
            int item = top.data;

            if (top.data == min.data)
            {
                min = min.next;
            }

            top = top.next;

            return item;
        }
        public int Top()
        {
            return top.data;
        }

        public int GetMin()
        {
             

            return min.data;
        }
    }
}

