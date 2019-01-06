/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Declare a variable of type char and assign it as a value
|     the character, which has Unicode code, 72 (use the Windows
|     calculator in order to find hexadecimal representation of 72).
|
| Solutions and Guidelines:
|
|     Look at the section about Character Literals.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            char container = '\u0048';
            Console.WriteLine(container);
        }
    }
}