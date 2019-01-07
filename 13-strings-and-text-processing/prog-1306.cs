/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program that reads a string from the console
|     (20 characters maximum) and if shorter complements it
|     right with "*" to 20 characters.
|
| Solutions and Guidelines:
|
|     Use the PadRight(...) method from the String class.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\nPlease, enter a text (20 characters maximum): ");
            string text = Console.ReadLine();
            Console.WriteLine("\n" + text.PadRight(20, '*'));
        }
    }
}