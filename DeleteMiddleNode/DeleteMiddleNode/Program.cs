using System;

namespace DeleteMiddleNode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            list.next.next.next = new ListNode(4);
            list.next.next.next.next = new ListNode(5);

            list.DeleteNode(list.next.next.next);
            list.Print();
            Console.WriteLine("");
        }
    }
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
        public void DeleteNode(ListNode c)
        {
            if (c == null || c.next == null) return;
            c.val = c.next.val;
            c.next = c.next.next;
        }
        public void Print()
        {
            ListNode a = this;
            while (a != null)
            {
                Console.WriteLine(a.val);
                a = a.next;
            }
        }

    }
}
