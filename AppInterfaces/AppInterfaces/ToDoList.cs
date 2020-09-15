using System;
using System.Collections.Generic;
using System.Text;

namespace AppInterfaces
{
    class TodoList : IDisplayable
    {

        public string[] Todos
        { get; private set; }
        public string HeaderSymbol { get; set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            HeaderSymbol = "_______";
        }

        public void Add(string todo)
        {
            if (nextOpenIndex == 4) throw new ArgumentOutOfRangeException();
            else
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }

        }
        public void Display()
        {
            Console.WriteLine(HeaderSymbol);
            foreach (var todo in Todos)
            {
                if (string.IsNullOrEmpty(todo)) Console.WriteLine("[]");
                else Console.WriteLine(todo);
            }
        }
        public void Reset()
        {

            Array.Clear(Todos, 0, 5);
            nextOpenIndex = 0;
        }
    }
}

