using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackImpl obj = new StackImpl();
            obj.Push(-2);
            obj.Push(0);
            obj.Push(-3);
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);

            Console.WriteLine(obj.GetMin());
            Console.WriteLine("\n");

            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());

            Console.WriteLine(obj.GetMin());
            Console.WriteLine("\n");

            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());

            Console.WriteLine(obj.GetMin());
            Console.WriteLine("\n");

            Console.WriteLine(obj.Peek());

        }
    }
    public class StackImpl
    {
        private StackNode top;
        private int min;
        private class StackNode
        {
            public int data;
            public StackNode next;
            public StackNode(int data)
            {
                this.data = data;
            }
        }
        public int GetMin()
        {
            return min;
        }

        public void Push(int item)
        {
            if (top == null) min = item;
            else
            {
                int temp = item;
                item = item - min;
                if (item < 0) min = temp;
            }

            StackNode t = new StackNode(item);
            t.next = top;
            top = t;
        }
        public int Pop()
        {
            if (top == null) throw new StackIsEmptyException();

            int item;
            if (top.data < 0)
            {
                item = min; min = min - top.data;
            }
            else item = min + top.data;

            top = top.next;
            return item;
        }

        public int Peek()
        {
            if (top == null) throw new StackIsEmptyException();
            int item;
            if (top.data < 0)
            {
                item = min; min = min - top.data;
            }
            else item = min + top.data;

            return item;
        }

        public bool IsEmpty()
        {
            return (top == null);
        }

    }
}
