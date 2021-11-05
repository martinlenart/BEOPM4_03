using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // string starting with whitespace, then
            // h or H, then one or more character followed by whitespace
            string pattern = @"\sh\w+\s"; 
            string str = "I like to hike and HOLLOR (shout) in the mountains.";
            RegexOptions options = RegexOptions.IgnoreCase;
            foreach (Match match in Regex.Matches(str, pattern, options))
                Console.WriteLine($"'{match.Value}' found at index {match.Index}"); 


            //Ignore whitespace in pattern expression for readability 
            pattern = @"\s h \w+ \s";
            str = "I like to hike and HOLLOR (shout) in the mountains.";
            options = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;
            Console.WriteLine();
            foreach (Match match in Regex.Matches(str, pattern, options))
                Console.WriteLine($"'{match.Value}' found at index {match.Index}"); 

            //Possible, but poor readability when integrate IgnoreCase and IgnorePatternsWhitespace (?ix)
            pattern = @"(?ix)\s h \w+ \s";
            str = "I like to hike and HOLLOR (shout) in the mountains.";
            Console.WriteLine();
            foreach (Match match in Regex.Matches(str, pattern))
                Console.WriteLine($"'{match.Value}' found at index {match.Index}"); 
        }
    }
}
