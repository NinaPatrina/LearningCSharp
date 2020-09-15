using System;
using System.Collections;
using System.Collections.Generic;

namespace PalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list = new ListNode(1);
            //list.next = new ListNode(2);
            //list.next.next = new ListNode(3);
            //list.next.next.next = new ListNode(2);
            //list.next.next.next.next = new ListNode(1);


            Console.WriteLine(list.IsPalindromRunners());
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
        public bool IsPalindromRunners()
        {
            ListNode slow = this;
            ListNode fast = this;
            Stack<int> stack = new Stack<int>();

            while (fast != null && fast.next != null )
            {
                stack.Push(slow.val);
                slow = slow.next;
                fast = fast.next.next;
            }

            if (fast == null) fast = slow;
            else fast = slow.next;
             
            while (fast != null)
            {
                if (fast.val != stack.Pop()) return false;
                fast = fast.next;
            }

            return true;
        }
        public bool IsPalindrome()
        {
            ListNode current = this;
            ListNode reversed = current.ReverseList();
            while (current != null)
            {
                if (current.val != reversed.val) return false;
                current = current.next;
                reversed = reversed.next;
            }
            return true;
        }
        public ListNode ReverseList()
        {
            ListNode head = this;
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
    }
}
