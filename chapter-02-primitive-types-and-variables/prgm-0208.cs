/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Declare two variables of type string and give them values
|     "Hello" and "World".
|
|     Assign the value obtained by the concatenation of the two
|     variables of type string (do not miss the space in the middle)
|     to a variable of type object.
|
|     Declare a third variable of type string and initialize it with
|     the value of the variable of type object
|     (you should use type casting).
|
| Solutions ang Guidelines:
|
|     Look at the sections about Strings and Object Data Type. To cast
|     from object to string use typecasting:
|
|       * string str = (string)obj;
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
            object objectContainer = hello + " " + world;
            string stringContainer = (string)objectContainer;
        }
    }
}