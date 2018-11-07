/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     A text is given. Write a program that modifies the casing
|     of letters to uppercase at all places in the text surrounded
|     by <upcase> and </upcase> tags. Tags cannot be nested.
|
|       * Example:
|
|         We are living in a <upcase>yellow submarine</upcase>.
|         We don't have <upcase>anything</upcase> else.
|
|       * Result:
|
|         We are living in a YELLOW SUBMARINE.
|         We don't have ANYTHING else.
|
| Solutions and Guidelines:
|
|     Use regular expressions or IndexOf(...) method for opening
|     and closing tag. Calculate the start and end index of the text.
|     Change the text in all capital letters and replace the entire
|     substring opening tag + text + closing tag with the text
|     in uppercase.
|
*/

// NOT FINISHED YET!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string quote =
                "We are living in a<upcase> yellow submarine </upcase>." +
                "We don't have <upcase>anything</upcase> else.";

            int openingUpcaseIndex;
            int closingUpcaseIndex;

            openingUpcaseIndex = quote.IndexOf("<upcase>");
            closingUpcaseIndex = quote.IndexOf("</upcase>");
            string temp = null;

                quote = quote.Substring(openingUpcaseIndex + 8, closingUpcaseIndex - (openingUpcaseIndex + 8)).ToUpper();

            Q
            Console.WriteLine(quote);

        }
    }
}