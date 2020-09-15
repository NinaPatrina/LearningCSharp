using System;

namespace BeerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            int startBottles = 1; int takeDown = 1;
            Console.WriteLine(Recite(startBottles, takeDown));
        }
        public static string Recite(int startBottles, int takeDown)
        {
            string result = "";
            string input = startBottles.ToString();
            string final = $"Go to the store and buy some more, {startBottles} bottles of beer on the wall.";
            for (int i = takeDown; i > 0; i--)
            {   string input1="";
                string input2="";
                string input3="";

                if (startBottles >1 ) input1 = startBottles.ToString() + "bottles"; input2 = input1;
                if (startBottles == 1) input1 = startBottles.ToString() + "bottle"; input2 = input1; input3 = "no more bottles";
                if (startBottles == 0) input1 = "No more bottles"; input2 = "no more bottles";

                
                else result +=
                 $"{input1} of beer on the wall, {input2} of beer.\n" +
                 $"Take one down and pass it around, {input3} of beer on the wall.";

                if (startBottles==0) result+=final;
                if (i != 0) result += "\n\n";
                startBottles--;
            }
            return result;
        }
    }
}
