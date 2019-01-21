/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write a program that reads from the console
|     a sequence of positive integer numbers.
|     The sequence ends when an empty line is entered.
|     Print the sequence sorted in ascending order.
|
| Solutions and Guidelines:
|
|     Keep the numbers in List<T>
|     and finally use its Sort() method.
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
            List<int> sequence = new List<int>();

            Console.WriteLine("Please, enter positive integers only or enter empty line to exit).\n");
            do
            {
                Console.Write(": ");
                input = Console.ReadLine();
                if (input.Equals(" ")) break;
                bool success = int.TryParse(input, out int num);
                if (success) sequence.Add(num);
                else Console.WriteLine("\nInvalid input! Please, try again.\n");
            } while (true);

            sequence.Sort();

            Console.Write("\n: ");
            foreach (var num in sequence)
            {
                Console.Write($"{num} ");
            }
        }
    }
}