/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write a program that reads from the console
|     a sequence of positive integer numbers.
|     The sequence ends when empty line is entered.
|     Calculate and print the sum and the average
|     of the sequence. Keep the sequence in List<int>.
|
| Solutions and Guidelines:
|
|     See the section "List<T>".
|
*/

using System;
using System.Collections.Generic;

namespace Program
{
    public static class Program
    {
        public static List<int> GetSequence()
        {
            string input = null;
            List<int> sequence = new List<int>();

            Console.WriteLine("Please, enter positive integers only. (Enter empty line to exit)\n");
            do
            {
                Console.Write(": ");
                input = Console.ReadLine();
                if (input.Equals(" ")) break;
                bool success = int.TryParse(input, out int num);
                if (success && num > 0) sequence.Add(num);
                else Console.WriteLine("\nInvalid input! Please, try again.\n");
            } while (true);

            return sequence;
        }

        public static int GetSum(List<int> sequence)
        {
            int sum = 0;
            foreach (var number in sequence) sum += number;

            return sum;
        }

        public static void Main()
        {
            List<int> sequence = GetSequence();
            int sum = GetSum(sequence);
            double average = (double)sum / sequence.Count;
            Console.WriteLine($"\nSum = {sum}, Average = {average}");
        }
    }
}