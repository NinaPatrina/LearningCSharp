using System;

namespace Partition
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list = new ListNode(9);
            list.next = new ListNode(8);
            list.next.next = new ListNode(3);
            list.next.next.next = new ListNode(2);
            list.next.next.next.next = new ListNode(9);

            //passed leetcode but does not work for only 1 before

            list.Partition(list, 3);
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
        public ListNode Partition(ListNode head, int x)
        {
            ListNode beforeStart = null;
            ListNode afterStart = null;
            ListNode beforeEnd = null;
            ListNode afterEnd = null;

            while (head != null)
            {
                ListNode temp = head.next;
                head.next = null;
                
                if (head.val < x)
                {
                    if (beforeStart == null) { beforeStart = head; beforeEnd = beforeStart; }
                    else { beforeEnd.next = head; beforeEnd = head; }
                }
                if (head.val>=x)
                {
                    if (afterStart == null) { afterStart = head; afterEnd = afterStart; }
                    else { afterEnd.next = head; afterEnd = head; }
                }
                    head = temp;
                }
                    if (beforeStart == null) return afterStart;

                beforeEnd.next = afterStart;
                return beforeStart;
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
