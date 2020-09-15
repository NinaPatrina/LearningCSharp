using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace Library
{
    class Program
    {
        static void Main()
        {
            var book = new List<Books>();
            bool choice = true;
            while (choice == true)
            { choice = Menu(book); }
        }
        public static bool Menu(List<Books> book)
        {
            Console.WriteLine("\n\n\n1.Write");
            Console.WriteLine("2.Read");
            Console.WriteLine("3.Exit\n\n");

            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1: InputBook(book); break;
                case 2: Catalog(book); break;
                case 3: return false;
            }
            return true;
        }
        public static List<Books> InputBook(List<Books> books)
        {
            bool adding = true;
            var newBook = new Books();
            while (adding == true)
            {
                try
                {
                    Console.WriteLine("Print Title\n");
                    newBook.Title = (Console.ReadLine().TrimStart().TrimEnd());
                    Console.WriteLine("Print Year\n");
                    newBook.Year = (Math.Abs(int.Parse(Console.ReadLine())));
                    Console.WriteLine("Is this book available?\n");
                    newBook.Availability = (Console.ReadLine().ToUpper());
                    books.Add(newBook);
                    var asLines = books.Last().ConverToLine();
                    File.AppendAllText(@"C:\Users\ninoc\Documents\library.txt", asLines);
                    Console.WriteLine("Do you want to add another book? Y/N\n");
                    if (Console.ReadLine().ToUpper() != "Y") adding = false;
                }
                catch (Exception)
                {
                     Console.WriteLine("\nError adding book,Please try again\n\n");
                }
                
            }
            Console.Clear();
            return books;
        }


        public static void Catalog()
        {
            Console.WriteLine("_".PadLeft(57, '_'));
            Console.WriteLine("|Title:{0,-14}|Year:{1,10}|Availability:{2,5}|"," "," ", " ");
            Console.WriteLine("_".PadLeft(57,'_'));


            string[] readText = File.ReadAllLines(@"C:\Users\ninoc\Documents\library.txt");
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("_".PadLeft(57, '_'));

        }
    }

    class Books
    {
        public string Title;
        public int Year;
        public string Availability;

        public string ConverToLine()
        {
            return $"|{Title,-20}|{Year,15}|{Availability,18}|\n";
        }
    }
}
