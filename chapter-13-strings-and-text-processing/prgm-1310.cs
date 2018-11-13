/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     Write a program that extracts from a text all
|     sentences that contain a particular word.
|     We accept that the sentences are separated from
|     each other by the character "." and the words
|     are separated from one another by a character which
|     is not a letter.
|
|       * Sample text: We are living in a yellow submarine.
|         We don't have anything else. Inside the submarine
|         is very tight. So we are drinking all the day.
|         We will move out of it in 5 days.
|
|       * Sample result: We are living in a yellow submarine.
|         We will move out of it in 5 days.
|
| Solutions and Guidelines:
|
|     First split the sentences from each other by using
|     the Split(...) method. Then make sure that each
|     sentence contains the searched word by searching
|     for it as a substring with IndexOf(...) and if you
|     find it check whether there is a separator (character,
|     which is not a letter or start / end of the string)
|     on the left and on the right of the found substring.
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