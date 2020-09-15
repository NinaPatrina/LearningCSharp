using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VeryEasyEdabit
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 4;
            int year = 2000;
            string word = "gee";
            int[] hurdles = {};
            int jumpHeight = 5;
            string str1 = "mArmALadE";
            string str2 = "acddf";

            Console.WriteLine(SameCase( str1));
        }
        public static int Addition(int num)
        {
            return num + 1;
        }
        public static int triArea(int b, int h)
        {
            return b * h / 2;
        }
        public static int Remainder(int x, int y)
        {
            return x % y;
        }
        public static bool LessThanOrEqualToZero(double a)
        {
            return a <= 0;
        }
        public static bool divisibleByFive(int n)
        {
            return n % 5 == 0;
        }
        public static int FindLargestNum(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length - 1];
        }
        public static bool TimeForMilkAndCookies(int year, int month, int day)
        {
            return month == 12 && day == 24;
        }
        public static bool Comp(string str1, string str2)
        {
            return str1.Length == str2.Length;
        }
        public static string IsEvenOrOdd(int num)
        {
            return num % 2 == 0 ? "even" : "odd";
        }
        public static bool HasSpaces(string str)
        {
            return str.Contains(" ");
        }
        public static bool EqualSlices(int total, int people, int each)
        {
            return people * each <= total;
        }
        public static bool IsPlural(string word)
        {
            return word.EndsWith('s');
        }
        public static object GetLastItem(object[] arr)
        {
            return arr[arr.Length - 1];
        }
        public static bool match(string s1, string s2)
        {
            return s1.ToLower() == s2.ToLower();
        }
        public static double FindSmallestNum(double[] arr)
        {
            return arr.Min();
        }
        public static string MissingAngle(int angle1, int angle2)
        {
            int angle3 = 180 - angle1 - angle2;
            return angle3 < 90 ? "acute" : angle3 > 90 ? "obtuse" : "right";
        }
        public static int differenceMaxMin(int[] arr)
        {
            return arr.Max() - arr.Min();

        }
        public static int FindDigitAmount(int num)
        {
            return num.ToString().Length;
        }
        public static bool CheckEnding(string str1, string str2)
        {
            return str2.Equals(str1.Substring(str1.Length - str2.Length));
        }
        public static int AddUp(int num)
        {
            //return Enumerable.Range(1, num).Sum();
            if (num == 1) return 1;
            return num + AddUp(num - 1);
        }
        public static int CountWords(string str)
        {
             return str.Split('-').Length;
        }
        public static string MonthName(int num)
        {
            return CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(num);
        }
        public static int Days(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }
        public static int FindIndex(string[] arr, string str)
        {
           return Array.FindIndex(arr, x=>x==str);
        }
        public static string Go(int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
               sb.Append('-');
                            }
            return sb.ToString();

        }
        public static int CharCount(char myChar, string str)
        {
          return  str.Count(c=>c==myChar);
        }
        public static int GetAbsSum(int[] arr)
        {
            return arr.Sum(c=>Math.Abs(c));

        }
        public static bool hurdleJump(int[] hurdles, int jumpHeight)
        {
            if (hurdles.Length == 0) return true;
            return hurdles.Max() <= jumpHeight;

        }
        public static string smallerNum(string n1, string n2)
        {
            
            int[] array = { int.Parse(n1), int.Parse(n2) };
            return array.Min().ToString();
        }
        public static int HammingDistance(string str1, string str2)
        {
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == str2[i]) count++;
            }
            return count;
        }
        public static int[] MultiplyByLength(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] * arr.Length;

            }
            return result;
        }
        public static double[] FindMinMax(double[] values)
        {
            return new[] { values.Min(), values.Max() };
        }
        public static long CalculateExponent(long number, long exponent)
        {
            return (long)Math.Pow((double)number, (double)exponent);
        }
        public static int Factorial(int num)
        {
            if (num == 1) return 1;
            else return num*Factorial(num -1);
        }
        public static int CountVowels(string str)
        {
            return Regex.Matches(str, @"[aeiou]").Count;
        }
        public static bool isIdentical(string str)
        {
            string r = str[0].ToString()+"{"+str.Length.ToString()+"}";
           return Regex.IsMatch(str, r);
        }
        public static int[] SortNumsAscending(int[] arr)
        {
            return arr.OrderBy(c => c).ToArray();
        }
        public static string NameShuffle(string str)
        {
            string[] temp = str.Split();
            return string.Join(" ",temp[1],temp[0]);
        }
        public static bool SameCase(string str)
        {
            if (Regex.IsMatch(str, @"[^A-Z]")) return true;
            if (Regex.IsMatch(str, @"[^a-z]")) return true;
            return false;
        }

    }
    }

