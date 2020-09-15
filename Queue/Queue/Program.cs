using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue q = new MyQueue();
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Add(4);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Remove());
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Remove());
            Console.WriteLine(q.IsEmpty());
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Remove());
            Console.WriteLine(q.IsEmpty());
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Remove());
            Console.WriteLine(q.IsEmpty());

        }
    }
    public class MyQueue
    {
        private QueueNode first;
        private QueueNode last;


        private class QueueNode
        {
            public int data;
            public QueueNode next;
            public QueueNode(int item)
            {
                this.data = item;
            }
        }

        public void Add(int item)
        {
            QueueNode t = new QueueNode(item);
            if (first == null)
            {
                first = t;
                last = t;
                return;
            }

            if (last != null)
            {
                last.next = t;
                last = last.next;
            }

        }
        public int Remove()
        {            
            int item = first.data;
            first = first.next;
            if (first == null) last = null;
            return item;
        }
        public int Peek()
        {
            return first.data;
        }
        public bool IsEmpty()
        {
            return (first == null && last == null);
        }
    }
}
