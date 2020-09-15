using System;
using System.Collections;

namespace QueueUsingStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueW2St q = new QueueW2St();
            q.Add(1);
            q.Add(2);
            q.Add(5);
            Console.WriteLine(q.IsEmpty());
            Console.WriteLine(q.Peek());

            Console.WriteLine(q.Remove());
            Console.WriteLine(q.Remove());
            Console.WriteLine(q.Remove());
            q.Add(6);
            Console.WriteLine(q.Remove());
            Console.WriteLine(q.IsEmpty());

        }
    }
    public class QueueW2St
    {
        private Stack stackNewest = new Stack();
        private Stack stackOldest = new Stack();

        public void Add(int item)
        {
            while (stackOldest.Count != 0)
            {
                var item1 = stackOldest.Pop();
                stackNewest.Push(item1);
            }

            stackNewest.Push(item);

        }
        public int Remove()
        {
            while (stackNewest.Count != 0)
            {
                var item = stackNewest.Pop();
                stackOldest.Push(item);
            }
            return (int)stackOldest.Pop();
        }
        public int Peek()
        {
            while (stackNewest.Count != 0)
            {
                var item = stackNewest.Pop();
                stackOldest.Push(item);
            }
            return (int)stackOldest.Peek();
        }
        public bool IsEmpty()
        {
            return (stackNewest.Count == 0 && stackOldest.Count == 0);
        }
    }
}
