using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_07

{
    class Program
    {
        static void Main(string[] args)
        {
            Match m = Regex.Match("206-465-1918", @"(\d{3})-(\d{3}-\d{4})");
            for (int i = 0; i < m.Groups.Count; i++)
            {
                Console.WriteLine($"Group nr {i}: {m.Groups[i].Value}");
            }

            m = Regex.Match("206-4655-1918", @"(\d{3})-((\d{3}|\d{4})-\d{4})");
            Console.WriteLine();
            for (int i = 0; i < m.Groups.Count; i++)
            {
                Console.WriteLine($"Group nr {i}: {m.Groups[i].Value}");
            }


            //Make the group part of the syntax by number the group using \1 in the expression
            Console.WriteLine();
            string str = "hello helloh toot tooth ";
            
            //Match any word that starts and ends with the same letter
            string pattern = @"\b(\w)\w+\1\b";
            var matches = Regex.Matches(str, pattern);

            Console.WriteLine();
            foreach (Match ma in matches)
                Console.Write(ma + " ");

            Console.WriteLine();
            pattern =   @"\b" +             // word boundary
                        @"(?'letter'\w)" +  // match first letter, and name it 'letter'
                        @"\w+" +            // match middle letters
                        @"\k'letter'" +     // match last letter, denoted by 'letter'
                        @"\b";              // word boundary

            matches = Regex.Matches(str, pattern);
            Console.WriteLine();
            foreach (Match ma in matches)
                Console.Write(ma + " ");
            Console.WriteLine();
        }
    }
}
