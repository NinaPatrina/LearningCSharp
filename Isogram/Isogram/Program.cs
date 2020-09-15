using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string isogram = "Password";

            Console.WriteLine(isogram.Length == isogram.ToLower().Distinct().Count());
          
        }
    }
}
