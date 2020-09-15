using System;

namespace listIntersection
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
            list.next.next.next.next.next = new ListNode(6);

            ListNode list2 = new ListNode(7);
            list2.next = new ListNode(8);
            list2.next.next = list.next.next.next.next;

            Console.WriteLine(ListNode.ListIntersectionRunner(list, list2).val);
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
        public static ListNode ListIntersectionRunner(ListNode list1, ListNode list2)
        {
            ListNode a = list1;
            ListNode b = list2;

            while (a != b)
            {
                a = (a == null) ? list2 : a.next;
                b = (b == null) ? list1 : b.next;
            }
            return a;
        }



        public static ListNode ListIntersection(ListNode list1, ListNode list2)
        {
            ListNode temp1 = list1;
            ListNode temp2 = list2;

            int length1 = 1;
            int length2 = 1;
            while (temp1.next != null)
            {
                temp1 = temp1.next;
                length1++;
            }
            while (temp2.next != null)
            {
                temp2 = temp2.next;
                length2++;
            }
            if (temp1 != temp2) return null;

            if (length1 > length2)
            {
                while (length1 != length2)
                {
                    length1--;
                    list1 = list1.next;
                }
            }
            else while (length1 != length2)
                {
                    length2--;
                    list2 = list2.next;
                }
            while (list1 != list2) { list1 = list1.next; list2 = list2.next; }
            return list1;
        }

    }
}
