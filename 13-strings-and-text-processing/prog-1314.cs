/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 14:
|
|     A dictionary is given, which consists of several
|     lines of text. Each line consists of a word and its
|     explanation, separated by a hyphen:
|
|       * .NET – platform for applications from Microsoft
|         CLR – managed execution environment for .NET
|         namespace – hierarchical organization of classes
|
|     Write a program that parses the dictionary and then
|     reads words from the console in a loop, gives an explanation
|     for it or writes a message on the console that the word
|     is not into the dictionary.
|
| Solutions and Guidelines:
|
|     You can parse the text by splitting it by the new line
|     character, then a second time by the "-" character.
|     The most appropriate way to record the dictionary is in
|     a hash table ( Dictionary<string, string> ), which will
|     provide a quick search for a given word.
|     Read on the Internet for hash-tables and the Dictionary<K,T>
|     class. You might also check the chapter "Dictionaries,
|     hash-Tables and Sets".
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
        static void Main(string[] args)
        {
            
        }
    }
}