using System;

namespace Retrieve_the_Subreddit
{
    class Program
    {
        static void Main(string[] args)
        {
            string reddit = "https://www.reddit.com/r/mildlyinteresting/";
            string s2 = reddit.Remove(0, 25).TrimEnd('/');
            Console.WriteLine(s2);
        }
    }
}
