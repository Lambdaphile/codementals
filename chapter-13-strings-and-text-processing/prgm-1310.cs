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
|         Microsoft announced its next generation C#
|         compiler today. It uses advanced parser
|         and special optimizer for the Microsoft CLR.
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
|     First split the sentences from each other by using the Split(...)
|     method. Then make sure that each sentence contains the searched
|     word by searching for it as a substring with IndexOf(...)
|     and if you find it check whether there is a separator (character,
|     which is not a letter or start / end of the string) on the left
|     and on the right of the found substring.
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
        public static void Main(string[] args)
        {
            
        }
    }
}