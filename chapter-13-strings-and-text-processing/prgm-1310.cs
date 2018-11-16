/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     A string is given, composed of several "forbidden" words
|     separated by commas. Also a text is given, containing
|     those words. Write a program that replaces the forbidden
|     words with asterisks.
|
|       * Sample text:
|
|           Microsoft announced its next generation C#
|           compiler today. It uses advanced parser
|           and special optimizer for the Microsoft CLR.
|
|     Sample string containing the forbidden words: "C#,
|     CLR, Microsoft".
|
|       * Sample result:
|
|           ********* announced its next generation **
|           compiler today. It uses advanced parser
|           and special optimizer for the ********* ***.
|
| Solutions and Guidelines:
|
|     First, split the forbidden words with the method Split(...)
|     in order to get them as an array. For each forbidden word,
|     iterate through the text and search for an occurrence.
|     If a forbidden word is found, replace it with as many asterisks
|     as letters contained in the forbidden word.
|
|     Another, easier approach is to use RegEx.Replace(...) with
|     a suitable regular expression and a suitable MatchEvaluator method.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static string HideForbiddenWord(string text, string forbiddenWord)
        {
            StringBuilder restrictedStr = new StringBuilder();
            restrictedStr.Append(text);
            restrictedStr.Replace(forbiddenWord, new string ('*', forbiddenWord.Length));
            return restrictedStr.ToString();
        }

        static void Main(string[] args)
        {
            string str =
                "Microsoft announced its next generation C# compiler today. " +
                "It uses advanced parser and special optimizer for the Microsoft CLR.";
            string forbiddenWords =
                "C#, CLR, Microsoft";

            char[] separators = { ',', ' ' };
            string[] forbiddenWordsArr = forbiddenWords.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string restrictedStr = str;
            for (int i = 0; i < forbiddenWordsArr.Length; i++)
            {
                restrictedStr = HideForbiddenWord(restrictedStr, forbiddenWordsArr[i]);
            }

            Console.WriteLine($"Before hiding forbidden words:\n{str}\n\n\nAfter hiding forbidden words:\n{restrictedStr}");
        }
    }
}