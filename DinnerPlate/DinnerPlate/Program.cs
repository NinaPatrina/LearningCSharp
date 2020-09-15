using System;
using System.Collections.Generic;

namespace DinnerPlate
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfPlates obj = new StackOfPlates();
            obj.Push(-2);
            obj.Push(9);
            obj.Push(-3);
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            obj.Push(2);
            obj.Push(3);
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());


        }
    }
    public class StackOfPlates
    {
        private List<Stack<int>> listOfStacks = new List<Stack<int>>();
        private Stack<int> last = new Stack<int>();

        private const int capacity = 3;

        public void Push(int item)
        {
            if (listOfStacks.Count == 0 || last.Count == capacity)
            {
                listOfStacks.Add(last);
                last.Push(item);
            }
            else last.Push(item);

        }
        public int Pop()
        {
            if (last == null)
            {
                listOfStacks.Remove(last);
            }

            int item = last.Pop();

            return item;

        }



    }
}
