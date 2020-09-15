using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Protein2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> codonsToProteins = new Dictionary<string, string>{
{"AUG", "Methionine"},
{"UUU", "Phenylalanine"},
{"UUC", "Phenylalanine"},
{"UUA","Leucine"},
{"UUG", "Leucine"},
{"UCU","Serine"}, {"UCC","Serine"},
{"UCA","Serine"}, {"UCG", "Serine"},
{"UAU","Tyrosine"}, {"UAC", "Tyrosine"},
{"UGU","Cysteine"},{ "UGC","Cysteine"},
{"UGG" , "Tryptophan"},
{"UAA", "STOP"},{"UAG","STOP"},{ "UGA" ,"STOP"}
    };

            string strand = "UCCUCCUCG";
            string[] codons = Regex
                .Split(strand, @"(.{3})")
                .Where(x => x.Length == 3)
                .ToArray();

            foreach (var item in codons)
            {
                Console.WriteLine(item);
            }
            string codons2 = "UCC";
            var collection = codonsToProteins.Where(x => x.Key.Equals(codons2)).Select(x => x.Value).ToArray();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            //TakeWhile(x=>x!="STOP").

        }
    }
}
