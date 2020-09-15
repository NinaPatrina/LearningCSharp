using System;

namespace LinkListIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode headA = new ListNode(1);
            //headA.next = new ListNode(1);

            ListNode headB = new ListNode(1);
            //headB.next = new ListNode(0);
            //headB.next.next = new ListNode(1);


            //ListNode headC = new ListNode(9);
            //headC.next = new ListNode(4);
            //headC.next.next = new ListNode(5);

            //headA= headC;
            headB.next = headA;
            //Console.WriteLine(headA.ToString());
            //Console.WriteLine(headB.ToString());

            Console.WriteLine(GetIntersectionNode(headA, headB).val);


            static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
            {
                if (headA == null || headB == null) return null;

                ListNode a = headA;
                ListNode b = headB;

                while (a != b)
                {
                    a = (a == null) ? headB : a.next;
                    b = (b == null) ? headA : b.next;
                }
                return a;
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
