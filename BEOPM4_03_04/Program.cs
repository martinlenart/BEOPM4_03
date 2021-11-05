using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_04

{
    class Program
    {
        static void Main(string[] args)
        {
            //Matches h H i I
            string str = "I like to hike and HOLLOR (shout) in the mountains.";
            string pattern = @"[IiHh]";
            Console.WriteLine(Regex.Matches(str, pattern).Count);       // 9
            foreach (Match item in Regex.Matches(str, pattern))
            {
                Console.WriteLine(item.Value);
            }

            pattern = @"[IiHh](ke|out)";
            Console.WriteLine();
            Console.WriteLine(Regex.Matches(str, pattern).Count);       // 3
            foreach (Match item in Regex.Matches(str, pattern))
            {
                Console.WriteLine(item.Value);
            }

            //Matches q followed by everything except vowels
            Console.WriteLine();
            Console.WriteLine(Regex.Match("How do your like the quiz?", "q[aeiou]").Index);  // 21
            Console.WriteLine(Regex.Match("I have a qwerty keyboard", "q[^aeiou]").Index);   // 9

            //Matches a range
            Console.WriteLine();
            Console.WriteLine(Regex.Match("b1-c4", @"[a-h]\d-[a-h]\d").Success); // true
            Console.WriteLine(Regex.Match("i1-k4", @"[a-h]\d-[a-h]\d").Success); // false
        }
    }
}
