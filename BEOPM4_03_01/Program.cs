using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //? quantifier matches exactly 0 or 1 time
            Console.WriteLine(Regex.Match("color", @"colou?r").Success); //true
            Console.WriteLine(Regex.Match("colour", @"colou?r").Success); //true

            Match m1 = Regex.Match("True color. I see your true colours. True colors", @"colou?rs?");
            Match m2 = m1.NextMatch();
            Match m3 = m2.NextMatch();
            Console.WriteLine();
            Console.WriteLine($"Success: {m1.Success}  Value: {m1.Value}"); // true color
            Console.WriteLine($"Success: {m2.Success}  Value: {m2.Value}"); // true colours
            Console.WriteLine($"Success: {m3.Success}  Value: {m3.Value}"); // true colors

            string r = @"Mari(e|a|eluise)?";
            Console.WriteLine();
            Console.WriteLine(Regex.IsMatch("Maria", r));                   // true
            Console.WriteLine(Regex.IsMatch("Marie", r));                   // true
            Console.WriteLine(Regex.IsMatch("Marieluise", r));              // true
            Console.WriteLine(Regex.IsMatch("Kim", r));                     // false
        }
    }
}
