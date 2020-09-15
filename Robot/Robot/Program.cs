using System;
using System.Collections.Generic;
using System.Linq;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int repeatedNames = 0;

            for (int i = 0; i < 10_000; i++)
            {
                var robot = new Robot1();
                bool newName = names.Add(robot.Name);
                if (!newName) repeatedNames++;
            }
            Console.WriteLine(repeatedNames);

        }
    }
    public class Robot1
    {
        public string name;
        static HashSet<string> names = new HashSet<string>();

        public Robot1()
        {
            this.name = Name;

        }
        public string Name
        {
            get
            {
                if (this.name == null)
                {
                    do
                    {
                        var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        var random = new Random();
                        this.name = string.Concat(Enumerable
                                 .Range(0, 2)
                                 .Select(_ => letters[random.Next(letters.Length)]).ToArray()) +
                                 random.Next(100, 999).ToString();
                    }
                    while (names.Contains(this.name));
                }
                names.Add(this.name);
                return this.name;
            }
        }

        public void Reset()
        {
            this.name = null;
            this.name = Name;
        }
    }
}
