using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);



            //ListNode reversed = new Solution().ReverseListIterative(head);
            ListNode reversed2 = new Solution().ReverseListRecursive2(head);
            Console.WriteLine(reversed2.ToString());
            //Console.WriteLine(head.ToString());
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public override string ToString()
        {
            var node = this;
            string result = "";
            while (node != null)
            {
                result += node.val.ToString();
                node = node.next;
            }
            return result;
        }
    }

    public class Solution
    {
        public ListNode ReverseListIterative(ListNode head)
        {
            ListNode reversed = null;
            while (head != null)
            {
                ListNode temp = head.next;
                head.next = reversed;
                reversed = head;
                head = temp;
            }
            return reversed;
        }

        public ListNode ReverseListRecursive(ListNode originalList)
        {
            // Guard against empty input
            if (originalList == null)
            {
                return null;
            }

            // End of recursion, we are at the list end, no more elements in the list
            if (originalList.next == null)
            {
                return originalList;
            }

            var temp = originalList;
            var reversed = ReverseListRecursive(originalList.next);

            temp.next.next = originalList;
            originalList.next = null;

            return reversed;
        }


        public ListNode ReverseListRecursive2(ListNode originalList)
        {
            var current = originalList;
            var isEndOfList = current.next == null;
            if (isEndOfList)
            {
                return current;
            }
            var reversed = this.ReverseListRecursive2(current.next);
            var lastElementInReversed = current.next;
            current.next = null;
            lastElementInReversed.next = current;
            return reversed;
        }
    }

}