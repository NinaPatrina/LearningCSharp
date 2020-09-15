using System;
using System.Collections.Generic;
using System.Linq;

namespace HighScore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {0};
           var scores = new HighScores(list);

            Console.WriteLine(string.Join("  ",scores.Scores()));
            Console.WriteLine(string.Join("  ", scores.Latest()));
            Console.WriteLine(string.Join("  ", scores.PersonalBest()));
            Console.WriteLine(string.Join("  ", scores.PersonalTopThree()));

        }
    }
       
    public class HighScores
    {
        private readonly List<int> list;
        public HighScores(List<int> list)
        {
            if (list == null) throw new ArgumentNullException();
            if (list.Any(x => x < 0))
                throw new InvalidOperationException("the score can't be negative");
            this.list = list;
        }
        public List<int> Scores() => list;
        public int Latest() => list.LastOrDefault();
        public int PersonalBest()
        {
            if (list.Count == 0) throw new InvalidOperationException("there are no scores in the list");
            return list.Max();
        }
        public List<int> PersonalTopThree() => list.OrderByDescending(c => c).Take(3).ToList();
    }
}
