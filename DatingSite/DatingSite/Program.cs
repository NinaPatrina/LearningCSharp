using System;

namespace DatingSite
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile(city: "New York", country: "USA", pronounce: "he/him")
            {
                Name = "Sam Drakkila",
                Age = 30,
            };
            string[] hobbies = { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball","writing a speculative fiction novel","reading advice columns"};
            sam.SetHobbies(hobbies);
            Console.WriteLine(sam.ViewProfile());


        }
    }
}
