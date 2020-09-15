using System;
using System.Collections.Generic;
using System.Linq;

namespace ScaleGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string tonic = "C";
            string pattern = "MMmMMMm";
            foreach (var item in Interval(tonic, pattern))
            {
                Console.WriteLine(item);
                
            }
        }
            static string[] sharps = new[] { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
            static string[] flats = new[] { "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab" };

            public static string[] Chromatic(string tonic)
            {
                if (tonic == "C" || tonic == "G" || tonic == "D" || tonic == "A" || tonic == "E" || tonic == "B")
                    return Enumerable.Concat(sharps.SkipWhile(x => String.Compare(tonic, x, true) != 0), sharps.TakeWhile(x => String.Compare(tonic, x, true) != 0)).ToArray();
                else return Enumerable.Concat(flats.SkipWhile(x => String.Compare(tonic, x, true) != 0), flats.TakeWhile(x => String.Compare(tonic, x, true) != 0)).ToArray();
            }
            public static string[] Interval(string tonic, string pattern)
            {
                List<string> result = new List<string>();
                string[] tonics = Chromatic(tonic);
                result.Add(tonics[0]);
                int i = 0;
                foreach (var item in pattern)
                {
                    int s = 0;
                    if (item == 'm') s = 1;
                    if (item == 'M') s = 2;
                    if (item == 'A') s = 3;
                    i = i + s;
                Console.Write(i);
                   // result.Add(tonics[i]);
                }
            //return result.ToArray();
            return tonics;
            }
        }
    }
