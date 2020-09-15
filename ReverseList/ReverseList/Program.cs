using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseList
{
    class Program
    {
        static string ToString(object obj)
        {
            return obj.ToString();
        }

        static void Main(string[] args)
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            Console.WriteLine(head.ToString2());

            var headAlternative = new ListNode(1);
            headAlternative
                .AddNext(2)
                .AddNext(3)
                .AddNext(4);
            var skipTwo = headAlternative.next.next;
            Console.WriteLine(skipTwo.ToString());

            var newHead = ReverseList(head);
            Console.WriteLine(newHead.ToString());
        }

        static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode newHead = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return newHead;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            this.val = x;
        }

        public ListNode AddNext(int x)
        {
            this.next = new ListNode(x);
            return this.next;
        }

        public override string ToString()
        {
            var current = this.val.ToString();
            if (this.next != null)
            {
                return current + this.next.ToString();
            }
            else
            {
                return current;
            }
        }
        public string ToString2()
        {
            var current = this.val.ToString();
            if (this.next != null)
            {
                return this.next.ToString2() + current;
            }
            else
            {
                return current;
            }
        }

        public string ToStringNotRecursive()
        {
            var node = this;
            var result = "";
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
        public ListNode ReverseList(ListNode head)
        {
            if (null == head) return head;
            ListNode curr = head;       //Start with first node. i.e. head.
            ListNode prev = null;       //When starting with head, prev node will be null.
            while (curr.next != null)   //Make sure that there is a next node.
            {
                ListNode next = curr.next;  //Store the pointer to next node as we are going to override that to previous node.
                curr.next = prev;           //Next to curr node becomes what was previous node.
                prev = curr;                //Now move prev ahead to curr node.
                curr = next;                //Now move curr to the next node, which was have previously stored in next.
            }
            curr.next = prev;       //DO NOT FORGET. Once out of the loop curr.next is null. You have to point it to last prev.
            return curr;
        }
    }
}

