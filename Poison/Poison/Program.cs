using System;
using System.Collections.Generic;

namespace Poison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Bottle
    {
        private bool poisoned = false;
        private int id;

        public Bottle (int id)
        {
            this.id = id;
        }
        public int getId() { return id; }
        public void setAsPoisoned() { poisoned = true; }
        public bool isPoisoned() { return poisoned;}
    }

    class TestStrips
    {
        public static int DaysForResult = 7;
        private List<List<Bottle>> dropsByDay = new List<List<Bottle>>();
        private int id;

        public TestStrips(int id) { this.id = id; }
        public int getId() { return id; }
        //resize list of days/drops to be large enought
        private void sizeDropsForDay (int day)
        {
            while (dropsByDay.Count <= day)
            {
                dropsByDay.Add(new List<Bottle>());
            }
        }
        //add drops from bottle  on specific day
        public void addDropOnDay(int day, Bottle bottle)
        {
            sizeDropsForDay(day);
            List<Bottle> drops = dropsByDay.get(day);
            drops.Add(bottle);
        }
        //check if any of the bottles in the set are poisoned 
        private bool hasPoison(List<Bottle> bottles)
        {
            foreach (var b in bottles)
            {if (b.isPoisoned()) return true;

            } return false;

            }
        // get bottles used in the test days for result days ago
        public List<Bottle> getLastWeekBottles(int day) { if (day < DaysForResult) { return null; }
            return dropsByDay.get(day - DaysForResult);
        }
        // check for poisoned bottle since before DaysForResult
        public bool isPositiveOnDay(int day)
        {

        }

    }
}
