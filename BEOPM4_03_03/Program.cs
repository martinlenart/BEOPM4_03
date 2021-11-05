using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regex metacharacters \  *  +  ?  |  {  [  (  )  ^  $  .  #
            Console.WriteLine(Regex.Match("What time is it?", @"it\?").Value);  //it?
            Console.WriteLine(Regex.Match("What time is it?",  @"it?").Value);  //it

            Console.WriteLine();
            Console.WriteLine(Regex.Escape(@"How many $ will it cost?"));     
            Console.WriteLine(Regex.Unescape(@"How many \$ will it cost\?"));

            //Be careful with Pattern WhiteSpaces
            Console.WriteLine();
            Console.WriteLine(Regex.IsMatch("Hi Johan", @"Hi Johan"));         //true
            Console.WriteLine(Regex.IsMatch("Hi Johan", @"(?x) hello world")); //false 
            Console.WriteLine(Regex.IsMatch("HiJohan", @"(?x) hello world"));  //true 
        }
    }
}
