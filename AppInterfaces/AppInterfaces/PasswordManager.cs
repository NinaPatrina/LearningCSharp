using System;
using System.Collections.Generic;
using System.Text;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable
    {
        string password;
        private string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 8) password = value;
                else throw new InvalidPasswordException() ;
            }
        }
        public string HeaderSymbol { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
            HeaderSymbol = "___";

        }
        public void Display()
        {
            Console.WriteLine(HeaderSymbol);

            if (Hidden == false) Console.WriteLine(Password);
            else Console.WriteLine("*******");
        }
        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
        public bool ChangePassword(string a, string b)
        {
            if (Password == a) { Password = b; return true; }
            return false;

        }
    }
}
