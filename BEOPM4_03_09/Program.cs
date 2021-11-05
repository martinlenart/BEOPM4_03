using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Positive Lookahead
            string str = "say 25 miles more";
            Console.WriteLine("Positive Look-ahead");
            Console.WriteLine(Regex.Match(str, @"\d+\s(?=miles)").Value);    // 25
            Console.WriteLine(Regex.Match(str, @"\d+\s(?=miles).*").Value);  // 25 miles or more

            //Negative Lookahead
            Console.WriteLine();
            Console.WriteLine("Negative Look-ahead");
            string regex = @"(?i)good(?!.*(however|but))";
            Console.WriteLine(Regex.IsMatch("Good work! But...", regex)); // false
            Console.WriteLine(Regex.IsMatch("Good work! Thanks!", regex)); // true

            //Positive Look behind
            Console.WriteLine("Positive Look-behind"); 
            regex = @"(?<=USD) \d+ "; // match only those amounts which are in USD
            var matches = Regex.Matches("USD 100 JPY 2200 USD 200 JPY 4400 ", regex);
            Console.WriteLine(matches.Count); // 2
            foreach (Match m in matches)
                Console.WriteLine(m.Value); // 100 200

            //Negative Look behind
            Console.WriteLine();
            Console.WriteLine("Negative Look-behind");
            regex = @"(?<!USD) \d+ "; //  match all currencies except the USD
            matches = Regex.Matches("USD 100 JPY 2200 USD 200 JPY 4400 ", regex);
            Console.WriteLine(matches.Count); // 2
            foreach (Match m in matches)
                Console.WriteLine(m.Value); // 2200 4400
        }
    }
}
