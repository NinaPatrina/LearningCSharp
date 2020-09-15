using System;

namespace edabit_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalsNumber = new int[3];
            var legs = new int[] { 2, 4, 4 };

            Console.WriteLine("number of chicken:");
            animalsNumber[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("number of cows:");
            animalsNumber[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("number of pigs:");
            animalsNumber[2] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("number of animals : {0}", animalsNumber[i]);
                Console.WriteLine("number of legs : {0}", legs[i]);
            }
            int sum1 = 0;
            for (int i = 0; i < 3; i++)
            {
                int temp = animalsNumber[i] * legs[i];
                sum1 += temp;
            }
            Console.WriteLine("number of legs of all animals : {0}", sum1);

            var sum = animalsNumber[0] * 2 + animalsNumber[1] * 4 + animalsNumber[2] * 4;
            Console.WriteLine("legs on a farm:{0}", sum);
        }
        public static int AnimalsLegs(int[] animalsNumber) 
        {
            if (animalsNumber?.Length <3)
            {
                throw new ArgumentException();
            }

            return animalsNumber[0] * 2 + animalsNumber[1] * 4 + animalsNumber[2] * 4;
        }

    }
}
