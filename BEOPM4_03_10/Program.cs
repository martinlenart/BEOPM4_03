using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Regex.Match("Not now", "^[Nn]o").Value); // no
            Console.WriteLine(Regex.Match("f = 0.2F", "[Ff]$").Value); // F

            Console.WriteLine();
            foreach (Match m in Regex.Matches("Wedding in Sarajevo", @"\b\w+\b"))
                Console.WriteLine(m.Value);               // 3 matches: Weddin in Sarajevo

            Console.WriteLine();
            Console.WriteLine(Regex.Matches("Wedding in Sarajevo", @"\bin\b").Count); // 1
            Console.WriteLine(Regex.Matches("Wedding in Sarajevo", @"in").Count);     // 1

            //look ahead for sic: match: loose
            Console.WriteLine();
            string text = "Don't loose (sic) your cool";
            Console.WriteLine(Regex.Match(text, @"\b\w+\b\s(?=\(sic\))").Value); 
        }
    }
}
