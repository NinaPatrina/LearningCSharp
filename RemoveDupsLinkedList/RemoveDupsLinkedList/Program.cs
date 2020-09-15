using System;
using System.Collections.Generic;

namespace RemoveDupsLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            list.next.next.next = new ListNode(4);
            list.next.next.next.next = new ListNode(1);
            list.next.next.next.next.next = new ListNode(2);

            list.Print();
            Console.WriteLine("");
            //list.DeleteDuplicatesRunner();
            list.Print();
            Console.WriteLine("");
            list.DeleteDuplicatesHushTable(list);
            list.Print();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        { val = x; }
        public void DeleteDuplicatesHushTable(ListNode head)
        {
            HashSet<int> set = new HashSet<int>();
            ListNode unduplicatedLastNode = null;
            while (head != null)
            {
                if (!set.Contains(head.val))
                {
                    set.Add(head.val);
                    unduplicatedLastNode = head;
                }
                else
                {
                    unduplicatedLastNode.next = head.next;
                }
                head = head.next;
            }
        }

        public void DeleteDuplicatesRunner()
        {
            ListNode current = this;
            while (current != null)
            {
                ListNode runner = current;
                while (runner.next != null)
                {
                    if (current.val == runner.next.val)
                    {
                        runner.next = runner.next.next;
                    }
                    else runner = runner.next;
                }
                current = current.next;
            }
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
