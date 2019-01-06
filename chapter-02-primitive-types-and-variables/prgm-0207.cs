/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Declare two variables of type string with values
|     "Hello" and "World".
|
|     Declare a variable of type object. Assign the value obtained
|     of concatenation of the two string variables (add space
|     if necessary) to this variable.
|
|     Print the variable of type object.
|
| Solutions ang Guidelines:
|
|     Look at the sections about Strings and Object Data Type.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object container = hello + " " + world;

            Console.WriteLine(container);
        }
    }
}