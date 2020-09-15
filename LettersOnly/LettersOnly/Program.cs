using System;
using System.Text.RegularExpressions;

namespace LettersOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = "R!=:~0o0./c&}9k`60=y";
            string film1 = Regex.Replace(film, "[^a-zA-Z]", ""); 
            Console.WriteLine(film1);
        }
    }
}
