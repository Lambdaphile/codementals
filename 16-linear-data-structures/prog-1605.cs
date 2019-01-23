/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write a program, which removes all negative numbers
|     from a sequence.
|
|       * Example: array = {19, -10, 12, -6, -3, 34, -2, 5} ->
|                  {19, 12, 34, 5}
|
| Solutions and Guidelines:
|
|     Use list. Perform a left-to-right scan through all elements.
|     If the current number is positive, add it to the result,
|     otherwise, skip it.
*/

using System;
using System.Collections.Generic;

namespace Program
{
    public static class Program
    {
        public static List<int> RemoveNegativeNumbers(List<int> sequence)
        {
            List<int> result = new List<int>();
            foreach (var num in sequence)
            {
                if (num > 0)
                    result.Add(num);
            }

            return result;
        }

        public static void Main(string[] args)
        {
            List<int> sequence = new List<int> { 19, -10, 12, -6, -3, 34, -2, 5 };
            sequence = RemoveNegativeNumbers(sequence);
            foreach (int num in sequence)
                Console.WriteLine(num);
        }
    }
}