/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Write a program that converts a given string into
|     the form of array of Unicode escape sequences in
|     the format used in the C# language.
|
|       * Sample input: "Test".
|
|       * Result: "\u0054\u0065\u0073\u0074".
|
| Solutions and Guidelines:
|
|     Use format string "\u{0:x4}" for the Unicode
|     character code for each character of the input string
|     (you can get it by converting char to ushort).
|
*/

using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\nPlease, enter a string: ");
            string str = Console.ReadLine();

            str.ToCharArray();

            Console.Write("\nUnicode representation: ");
            foreach(char ch in str)
            {
                Console.Write("\\u{0:x4}", (ushort)ch);
            }
            Console.WriteLine();
        }
    }
}