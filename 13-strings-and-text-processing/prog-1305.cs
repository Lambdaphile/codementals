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
|           We are living in a <upcase>yellow submarine</upcase>.
|           We don't have <upcase>anything</upcase> else.
|
|       * Result:
|
|           We are living in a YELLOW SUBMARINE.
|           We don't have ANYTHING else.
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

using System;

namespace Program
{
    class Program
    {
        public static string RemoveTagsFromText(string text, string openingTag, string closingTag)
        {
            int openingTagIndex = text.IndexOf(openingTag);
            int closingTagIndex = text.IndexOf(closingTag);

            while(openingTagIndex != -1)
            {
                // Getting the <opening tag> + text + <closing tag> part of the text
                string temp1 = text.Substring(openingTagIndex, (closingTagIndex + closingTag.Length) - openingTagIndex);
                // Getting the text inside tags and applying ToUpper() function on it
                string temp2 = text.Substring(openingTagIndex + openingTag.Length, closingTagIndex - (openingTagIndex + openingTag.Length)).ToUpper();
                // Replace <opening tag> + text + <closing tag> part with text in uppercase
                text = text.Replace(temp1, temp2);

                openingTagIndex = text.IndexOf(openingTag);
                closingTagIndex = text.IndexOf(closingTag);
            }
            return text;
        }

        public static void Main(string[] args)
        {
            string quote =
                "We are living in a <upcase>yellow submarine</upcase>. " +
                "We don't have <upcase>anything</upcase> else.";

            string tagsFreeText = RemoveTagsFromText(quote, "<upcase>", "</upcase>");
            Console.WriteLine(tagsFreeText);
        }
    }
}