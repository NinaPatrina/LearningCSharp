using System;

namespace LoopDetection
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
            list.next.next.next.next.next = list.next.next;

            Console.WriteLine(list.DetectCycle().val);
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
        public ListNode DetectCycle()
        {
            ListNode FR = this;
            ListNode SR = this;

            while (FR != null && FR.next != null)
            {
                FR = FR.next.next;
                SR = SR.next;
                if (FR == SR) break;
            }
            if (FR == null) return null;
            SR = this;
            while (FR != SR)
            {
                FR = FR.next;
                SR = SR.next;

            }
            return FR;

        }
    }
}
