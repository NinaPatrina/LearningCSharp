using System;

namespace LinkedListCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode headA = new ListNode(1);
            headA.next = new ListNode(2);
            //headA.next.next = new ListNode(0);
            //headA.next.next.next = new ListNode(-4);
            //headA.next.next= headA.next;

            Console.WriteLine(HasCycle(headA));

            static bool HasCycle(ListNode head)
            {
                ListNode turtle = head;
                ListNode hare = head;

                while (hare != null && hare.next != null)
                {
                    turtle = turtle.next;
                    hare = hare.next.next;

                   if (turtle==hare) return true;
                }

                return false;
            }
        }
        class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
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
