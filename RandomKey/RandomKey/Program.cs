using System;
using System.Linq;

namespace RandomKey
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numbers = "0123456789";
            var random = new Random();

            Console.WriteLine(string.Concat(
                    Enumerable
                  .Range(0, 2)
                  .Select(_ => letters[random.Next(letters.Length)]).ToArray())+
            string.Concat(Enumerable
                  .Range(0, 3)
                  .Select(_ => numbers[random.Next(numbers.Length)]).ToArray()));
        }
    }
}
