using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode sasha = new ListNode("s");
            ListNode dasha = new ListNode("d");
            sasha.next = new ListNode("a");
            dasha.next = new ListNode("b");
            dasha.next = sasha.next;
            Console.WriteLine(dasha.next.letter);
            dasha.next.letter = "u";


            Console.WriteLine(dasha.next.Equals(sasha.next));
         
            sasha.next.next = new ListNode("s");
            sasha.next.next.next = new ListNode("h");
            sasha.next.next.next.next = new ListNode("a");
            sasha.next.next.next.next.next = new ListNode(" ");
            sasha.next.next.next.next.next.next = new ListNode(" ");

            ListNode koltso = new ListNode("1");
            koltso.next = new ListNode("2");
            koltso.next.next = new ListNode("3");
            koltso.next.next.next = new ListNode("4");
            koltso.next.next.next.next = new ListNode("5");
            koltso.next.next.next.next.next = new ListNode("6");
            //koltso.next.next.next.next.next.next = koltso.next.next.next.next;

            Console.WriteLine(koltso.next.next == koltso.next.next.next.next.next.next);


            foreach (var item in koltso)
            {
                Console.WriteLine(item.letter);

            }

            var array1 = koltso.Select(c => c.letter).Take(15).ToArray();

            foreach (var i in array1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ") ;

            //Console.WriteLine(koltso.Tail(koltso).ToString());


            ListNode ela = new ListNode("e");
            ela.next = new ListNode("l");
            ela.next.next = new ListNode("a");

            ListNode mel = new ListNode("m");
            mel.next = new ListNode("e");
            mel.next.next = new ListNode("l");

            sasha.next.next.next.next.next.next.next = mel;
            Console.WriteLine(mel.CopyThisList().ToString());
            Console.WriteLine(sasha.AddList(ela).ToString());

            //Console.WriteLine(sasha.ToString2());

            foreach (var node in sasha.Enumerate())
            {
                Console.Write(node.letter);
            }

            foreach (var node in sasha)
            {
                Console.WriteLine(node.letter);
            }
            var array = sasha.Select(c => c.letter).Distinct().ToArray();

            foreach (var i in array)
            {
                Console.Write(i);
            }

        }
    }
    public class ListNode : IEnumerable<ListNode>
    {
        public string letter;
        public bool check;
        public ListNode next;

        public ListNode(string x) { letter = x; check = false; }
        public ListNode(string x, bool y) { letter = x; check = y; }

        public ListNode Tail(ListNode koltso)
        {
            var node = this;
            foreach (var item in koltso)
            {
                if (item.check == true)
                {
                    node.next = null;
                    return this;
                }
                item.check = true;
                node = node.next;
            }
             return null;
            //var oldList = this;
            //var newList = new ListNode(oldList.letter);
            //var newListHead = newList;
            //int temp = 0;
            //foreach (var item in koltso)
            //{
            //    foreach (var item1 in koltso.Take(temp))
            //    {
            //        if (item == item1)
            //        {
            //            return newListHead.next;
            //        }
            //    }
            //    newList.next = new ListNode(item.letter);
            //    newList = newList.next;

            //    temp++;
            //}
            //return null;
        }

        public IEnumerator<ListNode> GetEnumerator()
        {
            var node = this;
            while (node != null)
            {
                yield return node;
                node = node.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListNode> Enumerate()
        {
            var node = this;
            while (node != null)
            {
                yield return node;
                node = node.next;
            }
        }


        public override string ToString()
        {
            var first = this;
            string result = "";
            while (first != null)
            {
                result += first.letter.ToString();
                first = first.next;
            }
            return result;
        }
        public ListNode AddList(ListNode ela)
        {
            var node = this;
            while (node != null)
            {
                if (node.letter == " ")
                {
                    var temp = node.next;
                    node.next = ela;
                    while (node.next != null)
                        node = node.next;

                    node.next = temp;
                    return this;
                }
                node = node.next;
            }
            return this;
        }
        public ListNode CopyThisList()
        {
            var oldList = this;
            var newList = new ListNode(oldList.letter);
            var newListHead = newList;
            while (oldList.next != null)
            {
                oldList = oldList.next;
                newList.next = new ListNode(oldList.letter);
                newList = newList.next;
            }
            return newListHead;
        }

    }
}

