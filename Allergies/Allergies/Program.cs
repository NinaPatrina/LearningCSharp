using System;
using System.Linq;

namespace Allergies
{
    class Program
    {
        static void Main(string[] args)
        {
           Allergies al= new Allergies(509);
            string codes =string.Concat( Convert.ToString(509, 2).Reverse()).ToString();
            Console.WriteLine(codes);

        }

        public enum Allergen
        {
            Eggs,
            Peanuts,
            Shellfish,
            Strawberries,
            Tomatoes,
            Chocolate,
            Pollen,
            Cats
        }

        public class Allergies
        {
            private string codes;
            public Allergies(int mask)
            {
                codes = string.Concat(Convert.ToString(mask, 2).Reverse()).ToString();
                Console.WriteLine(codes);

            }

            public bool IsAllergicTo(Allergen allergen)
            {
                int n = (int)allergen;
                Console.WriteLine(n);

                if (codes.Substring(n, 1) == "1") return true;
                else return false;
            }
        }
    }
}
