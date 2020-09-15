using System;

namespace ValidZipCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string zip = "90-37";
            var result = int.TryParse(zip, out int number);
            if (!result || zip.Length!=5||number<0)
                Console.WriteLine("false");
            else
                Console.WriteLine(" true");
        }
    }
}
