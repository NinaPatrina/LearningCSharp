using System;

namespace AppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");

            PasswordManager pm = new PasswordManager("iluvpietyty", true);
            tdl.Display();
            pm.Display();
            tdl.Reset();
            tdl.Display();
        }
    }
}
