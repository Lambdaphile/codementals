/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     How many backslashes you must specify as an argument
|     to the method Split(...) in order to split the text
|     by a backslash?
|
|       * Example: one\two\three.
|
|     Note: In C# backslash is an escaping character.
|
| Solutions and Guidelines:
|
|     If you do not know how many slashes you must use, try
|     Split(...) with an increasing number of slashes until
|     you reach the desired result.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "One\\Two\\Three";
            string[] splitText = text.Split('\\');
            foreach (var word in splitText)
            {
                Console.WriteLine(word);
            }
        }
    }
}