/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Write a program, which reads from the console
|     N integers and prints them in reversed order.
|     Use the Stack<int> class.
|
| Solutions and Guidelines:
|
|     Use Stack<int>.
|
*/

using System;
using System.Collections.Generic;

namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string input = null;
            Stack<int> sequence = new Stack<int>();

            Console.WriteLine("Please, enter positive integers only or enter empty line to exit)\n");
            do
            {
                Console.Write(": ");
                input = Console.ReadLine();
                if (input.Equals(" ")) break;
                bool success = int.TryParse(input, out int num);
                if (success) sequence.Push(num);
                else Console.WriteLine("\nInvalid input! Please, try again.\n");
            } while (true);

            Console.Write("\n: ");
            foreach (var num in sequence)
            {
                Console.Write($"{num} ");
            }
        }
    }
}