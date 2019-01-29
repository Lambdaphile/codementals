/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Write a program that finds in a given array of integers
|     (in the range [0...1000]) how many times each of them occurs.
|
|       * array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
|
|         2 -> 2 times
|         3 -> 4 times
|         4 -> 3 times
|
| Solutions and Guidelines:
|
|     Make a new array "occurrences" with size 1001.
|     After that scan through the list and for each number p
|     increment the corresponding value of it's occurrences
|     (occurrences[p]++). Thus, at each index, where the value
|     is not 0, we have an occurring number, so we print it.
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
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            int[] occurrences = new int[1001];
            foreach (int number in array)
            {
                int p = number;
                occurrences[p]++;
            }
            for (int i = 0; i < occurrences.Length; i++)
            {
                if (occurrences[i] != 0)
                    Console.WriteLine($"{i} -> {occurrences[i]} times.");
            }

        }
    }
}