/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     Declare two variables of type string and assign them a value
|     "The "use" of quotations causes difficulties."
|     (without the outer quotes). In one of the variables use
|     quoted string and in the other do not use it.
|
| Solutions and Guidelines:
|
|     Look at the section about Character Literals. It is necessary
|     to use the escaping character \" or verbatim strings.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string quotedString = "The \"use\" of quotations causes difficulties.";
            string nonQuotedString = "The use of quotations causes difficulties.";

            Console.WriteLine(quotedString);
            Console.WriteLine(nonQuotedString);
        }
    }
}