using System;
using System.Text.RegularExpressions;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "zzzZZzz9'?<>,.";
            Console.WriteLine(ValidatePassword(password));
        }
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 6 || password.Length > 23) return false;
            //if (Regex.IsMatch(password, @"^[]a-zA-Z0-9!@#$%^&*()+=_{}[:;”’?<>,.-]+$")) return false;
            string r =
                @"(?=.*\d)" +
                @"(?=.*[A-Z])" +
                @"(?=.*[a-z])"+
                @"(?!.*(\S)\1\1)";
            return Regex.IsMatch(password, r);
        }
    }
}
