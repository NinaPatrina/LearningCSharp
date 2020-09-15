using System;
using System.Linq;
using System.Text;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("type 10 numbers; ");
            //int[] numbers = new int[] { 4, 2, 5, 2, 8, 3, 7, 2, 5, 5 };
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            FormatPhoneNumber(numbers);
            9
            StringBuilder sb = new StringBuilder();
            sb.Append("(" + numbers[0]+numbers[1] + numbers[2] + ") " + numbers[3]+ numbers[4]   +numbers[5]+ "-" + numbers[6] + numbers[7]+ "-" + numbers[8] + numbers[9]);
            string numberRendered = sb.ToString();
            Console.WriteLine(numberRendered);
        }

        public static void FormatPhoneNumber(int[] numbers)
        {
            string composite = "({0}{1}{2}) {3}{4}{5}-{6}{7}-{8}{9}";
            //string phone = string.Format(composite, numbers);
            string phone = string.Format(composite, numbers.Cast<object>().ToArray());
            Console.WriteLine(phone);
        }

        private static void TemplateOutput()
        {
            var header = "Hi";
            var footer = "Bye";
            var template = $@"
{header}

Some text here.
Lots of text.
A template.

{footer}
";
            Console.WriteLine(template);
        }
    }
}


