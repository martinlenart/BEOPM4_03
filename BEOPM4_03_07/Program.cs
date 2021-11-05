using System;
using System.Text.RegularExpressions;

namespace BEOPM4_03_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I like hiking and to hike in the mountains.";

            //Find hike as a standalone word or hik
            string find = @"(\bhike\b)|hik";
            string replace = "swim";
            Console.WriteLine(Regex.Replace(str, find, replace));
            // I like swiming and to swim in the mountains.

            
            str = "10 plus 20 makes 30";
            Console.WriteLine();
            Console.WriteLine(Regex.Replace(str, @"\d+", @"<$0>")); //<10> plus <20> makes <30>


            //Match any replace any word that starts and ends with the same letter
            str = "hello helloh toot tooth ";
            string pattern = @"\b(\w)\w+\1\b";
            var matches = Regex.Matches(str, pattern);
            Console.WriteLine();
            Console.WriteLine(Regex.Replace(str, pattern, @"<$0>"));
            Console.WriteLine(Regex.Replace(str, pattern, @"<$1-$1>"));

            //Match an HTML tag and att a 'value' attribute
            string regFind =
                @"<(?'tag'\w+?).*>" +   // match first tag, and name it 'tag'
                @"(?'text'.*?)" +       // match text content, name it 'text'
                @"</\k'tag'>";          // match last tag, denoted by 'tag'

            string regReplace =
                @"<${tag}" +            // <tag
                @" value=""" +          // value="
                @"${text}" +            // text
                @"""/>";                // "/>

            Console.WriteLine();
            Console.WriteLine(Regex.Replace("<msg>hello</msg>", regFind, regReplace)); 
            // <msg value="hello"/>

            //Split at any digit
            Console.WriteLine();
            foreach (string s in Regex.Split("a5b7c", @"\d"))
                Console.Write(s + " "); // a b c

            //Split at character a-z
            Console.WriteLine();
            foreach (string s in Regex.Split("1a5B7c", @"[a-zA-Z]"))
                Console.Write(s + " "); // 1 5 7

        }
    }
}
