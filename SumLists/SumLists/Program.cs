using System;

namespace SumLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list = new ListNode(7);
            list.next = new ListNode(1);
            list.next.next = new ListNode(6);
            list.next.next.next = new ListNode(1);
           



            ListNode list2 = new ListNode(5);
            list2.next = new ListNode(9);
            list2.next.next = new ListNode(2);
            list2.next.next.next = new ListNode(1);
            list2.next.next.next.next = new ListNode(2);
            list2.next.next.next.next.next = new ListNode(3);

            ListNode sum = ListNode.Sum(list, list2);

            sum.Print();
            Console.WriteLine("");
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
        public static ListNode Sum(ListNode list1, ListNode list2)
        {
            int temp = (list1.val + list2.val > 10) ? list1.val + list2.val - 10 : list1.val + list2.val;
            int temp2 = list1.val + list2.val > 10 ? 1 : 0;
            ListNode sum = new ListNode(temp);
            ListNode head = sum;
            ListNode add = sum;

            while (list1.next != null || list2.next != null)
            {
                if (list1.next == null) list1.val = 0; else list1 = list1.next;
                if (list2.next == null) list2.val = 0; else list2 = list2.next;
                temp = (list1.val + list2.val >= 10) ? list1.val + list2.val - 10 : list1.val + list2.val;
                add.next = new ListNode(temp + temp2);
                temp2 = list1.val + list2.val >= 10 ? 1 : 0;
                sum = add.next;
                add = sum;
            }
            return head;
        }
        public ListNode AddNode()
        {
            ListNode current = this;
            while (current.next != null)
            { current = current.next; }

            int k = 1;
            ListNode add = current;
            while (k != 8)
            {                
                add.next = new ListNode(k);
                k++;
                current = add.next;
                add = current;
            }
            return current;

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
