/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write a program that reads a string, reverse it and prints it to
|     the console. For example: "introduction" -> "noitcudortni".
|
| Solutions and Guidelines:
|
|     Use StringBuilder and for (or foreach) loop.
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
        public static string ReverseString(string input)
        {
            StringBuilder reversedInput = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
                reversedInput.Append(input[i]);
            return reversedInput.ToString();
        }

        public static void Main(string[] args)
        {
            Console.Write("\nString: ");
            string input = Console.ReadLine();
            string reversedInput = ReverseString(input);
            Console.WriteLine($"Reversed string: {reversedInput}");
        }
    }
}