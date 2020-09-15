using System;

namespace ValidateEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = "hello@edabit.";
            Console.WriteLine(ValidateEmail(mail));
        }
        static bool ValidateEmail(string str)
        {
            //char[] array = str.ToCharArray();
            //if (str.Length < 5) return false;
            //if (array[0] == '@') return false;
            //for (int i = 1; i < str.Length - 2; i++)
            //{
            //    if (array[i] == '@')
            //    {
            //        if (array[i + 1] == '.') return false;
            //        for (int j = i + 2; j < str.Length - 1; j++)
            //        {
            //            if (array[j] == '.')
            //                return true;
            //        }

            //    }

            //}
            //return false
            int atIndex = str.IndexOf('@');
            int dotIndex = str.LastIndexOf('.');
            if (atIndex >= dotIndex || atIndex <= 0 || dotIndex == str.Length - 1) return false;
            return true;
        }
    }
}
