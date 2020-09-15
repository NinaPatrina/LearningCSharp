using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibraryJson
{
    class Program
    {
        private const string path = @"C:\Users\ninoc\Documents\library.json";

        public static void Main(string[] args)
        {
            var json = File.ReadAllText(path);
            var book = JsonConvert.DeserializeObject<List<Book>>(json);
            var choice = true;

            while (choice)
            {
                choice = Menu(book);
            }
        }

        public static bool Menu(List<Book> book)
        {
            Console.Write("\n\n\n");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Exit");
            Console.Write("\n\n");

            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1: InputBook(book); break;
                case 2: Catalog(); break;
                case 3: return false;
            }
            return true;
        }

        public static void InputBook(List<Book> books)
        {
            while (true)
            {
                try
                {
                    books.Add(Book.CreateFromInput());

                    Console.WriteLine("Do you want to add another book? Y/N\n");
                    bool isLastBook = Console.ReadLine().ToUpper() != "Y";
                    if (isLastBook)
                    {
                        File.WriteAllText(path, JsonConvert.SerializeObject(books));
                        Console.Clear();
                        return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError adding book,Please try again\n\n");
                }
            }
        }

        public static void Catalog()
        {
            Console.WriteLine("_".PadLeft(57, '_'));
            Console.WriteLine("|Title:{0,-14}|Year:{1,10}|Availability:{2,5}|", " ", " ", " ");
            Console.WriteLine("_".PadLeft(57, '_'));
            var json = File.ReadAllText(path);
            var books = JsonConvert.DeserializeObject<List<Book>>(json);

            foreach (var book in books)
            {
                book.OutputAsTable();
            }
            Console.WriteLine("_".PadLeft(57, '_'));
        }
    }

    class Book
    {
        public string Title;
        public int Year;
        public string Availability;

        public static Book CreateFromInput()
        {
            var newBook = new Book();
            Console.WriteLine("Print Title\n");
            newBook.Title = (Console.ReadLine().TrimStart().TrimEnd());
            Console.WriteLine("Print Year\n");
            newBook.Year = (Math.Abs(int.Parse(Console.ReadLine())));
            Console.WriteLine("Is this book available?\n");
            newBook.Availability = (Console.ReadLine().ToUpper());
            return newBook;
        }

        public void OutputAsTable()
        {
            Console.WriteLine($"|{Title,-20}|{Year,15}|{Availability,18}|");
        }
    }
}
