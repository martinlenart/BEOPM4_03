using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = "<i>By default</i> quantifiers are <i>greedy</i> creatures";

            Console.WriteLine("Greedy");
            var matches = Regex.Matches(html, @"<i>.*</i>");
            Console.WriteLine(matches.Count);               // 1
            foreach (Match m in matches)
                Console.WriteLine(m.Value);

            Console.WriteLine();
            Console.WriteLine("Lazy");
            matches = Regex.Matches(html, @"<i>.*?</i>");
            Console.WriteLine(matches.Count);               // 2
            foreach (Match m in matches)
                Console.WriteLine(m.Value);
        }
    }
}
