using System;

namespace LinkedListPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode headA = new ListNode(1);
            //headA.next = new ListNode(2);
            //headA.next.next = new ListNode(2);
            //headA.next.next.next = new ListNode(1);

            Console.WriteLine(IsPalindrome(headA));

            static bool IsPalindrome(ListNode head)
            {
                ListNode slow = head;
                ListNode fast = head;

                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }

                //reverse 2nd half of a list
                ListNode reversed = null;

                while (slow != null)
                {
                    ListNode temp = slow.next;
                    slow.next = reversed;
                    reversed = slow;
                    slow = temp;

                }
                
                fast = head;
                while (reversed != null)
                {
                    if (fast.val != reversed.val) return false;
                    fast = fast.next;
                    reversed = reversed.next;
                }
                return true;






            }
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }

            public override string ToString()
            {
                var first = this;
                string result = "";
                while (first != null)
                {
                    result += first.val.ToString();
                    first = first.next;
                }
                return result;
            }
        }
    }
}
