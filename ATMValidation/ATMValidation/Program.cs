using System;

namespace ATMValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string pin = "012356" ;

            bool result =( pin.Length == 4 || pin.Length == 6 )&& int.TryParse(pin, out int pin1)&&pin1>0;

            Console.WriteLine(result);
        }
    }
}
