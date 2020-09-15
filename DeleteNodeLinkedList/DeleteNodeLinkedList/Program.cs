using System;

namespace DeleteNodeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(4);
            head.next = new ListNode(5);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(9);

            Console.WriteLine(head.ToString());
            DeleteNode(head.next);
            Console.WriteLine(head.ToString());

            static void DeleteNode(ListNode node)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public override string ToString()
        {
            string s = "";
            ListNode head = this;
            while (head != null)
            {
                s += head.val.ToString();
                head = head.next;
            }
            return s;


        }
    }
}
