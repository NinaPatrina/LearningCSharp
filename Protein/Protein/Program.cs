using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Main()
{
    public static Dictionary<string, string> codonsToProteins = new Dictionary<string, string>{
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
     static void Main()
    {
        string strand = "UCCUCCUCG";
        string[] codons = Regex
            .Split(strand, @"(.{3})")
            .Where(x => x.Length == 3)
            .ToArray();

       var collection =codonsToProteins.Where(x=>x.Key.Equals(codons)).Select(x=>x.Value).ToArray();

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        } 
        //TakeWhile(x=>x!="STOP").
              
    }
}
