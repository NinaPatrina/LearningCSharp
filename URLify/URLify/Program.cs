using System;

namespace URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Mr John Smith   ";
            int n = 13;

            Console.WriteLine(ModifyString(str,n));

            static string ModifyString(string str, int n)
            {
                 str= str.Substring(0, n);
                var splitted =str.Split();

                string str1="";
               
                foreach (var w in splitted)
                {
                    str1+= w +"%20";
                }
                return str1.Substring(0,str1.Length-3);
            }
        }
    }
}
