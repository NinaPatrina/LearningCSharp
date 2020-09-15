using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProteinTranslation
{
    class Program
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
            string strand ="UGUUGA";
            foreach (var item in Proteins(strand))
            {
                //Console.WriteLine(item);
            }

           
        }

        static string[] Proteins(string strand)
        {
            string[] codons = Regex.Split(strand, @"(.{3})").Where(x => x.Length == 3).ToArray();
          //  codons = codons.Where(x => x.Length == 3).ToArray();
            Console.WriteLine(codons.Length);

            foreach (var item in codons)
            {
                Console.WriteLine($"we have{item}here");
                Console.WriteLine("  ");

            }


            return codonsToProteins.Where(x => x.Key.Equals(codons)).Select(x => x.Value).ToArray();


            /*TakeWhile(x=>x!="STOP").

             string[] proteins=new string[codons.Length];
             int i=0;
             foreach (var codon in codons)
             { if(codonsToProteins.GetValueOrDefault (codon)=="STOP") return proteins;
                 proteins[i]=codonsToProteins.GetValueOrDefault(codon);
                 i++;
             }
             return proteins;*/
        }
    }
}
