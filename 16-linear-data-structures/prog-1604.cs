/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Write a method that finds the longest subsequence
|     of equal numbers in a given List<int> and returns
|     the result as new List<int>. Write a program to test
|     whether the method works correctly.
|
| Solutions and Guidelines:
|
|     Use List<int>. Scan the list with a for-loop (1 ... n - 1)
|     while keeping two variables: start and length.
|     Initially start = 0, length = 1. At each loop iteration
|     if the number at the left is the same as the current number,
|     increase length. Otherwise restart from the current cell
|     (start = current, length = 1).
|     Remember the current start and length every time when
|     the current length becomes better than the current
|     maximal length.
|
|     Finally create a new list and copy the found sequence to it.
|     Testing could be done through a sequence of examples
|     and comparisons, e.g.
|
|       * {1} -> {1};
|         {1, 2} -> {1};
|         {1, 1} -> {1, 1};
|         {1, 2, 2, 3} -> {2, 2};
|         {1, 2, 2} -> {2, 2};
|         {1, 1, 2} -> {1, 1};
|         {1, 2, 2, 1, 1, 1, 2, 2, 2, 3, 3, 3} -> {1, 1, 1};
|         {1, 2, 2, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3} -> {2, 2, 2, 2};
|
*/

using System;
using System.Collections.Generic;

namespace Program
{
    public static class Program
    {
        public static void GetLongestSubSequence(List<int> sequence)
        {
            int start = 0, length = 1, maxStart = start, maxLength = length;
            for (int i = start; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    length++;
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        maxStart = start;
                    }
                    start = i + 1;
                    length = 1;
                }

                if (i == sequence.Count - 2 && length > maxLength)
                {
                    maxLength = length;
                    maxStart = start;
                }
            }

            List<int> longestSubSequence = sequence.GetRange(maxStart, maxLength);
            Console.Write("\nLongest Sub Sequence: ");
            foreach (var num in longestSubSequence)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            List<int> sequence = new List<int>();
            sequence = new List<int> { 1 };
            GetLongestSubSequence(sequence);
            sequence = new List<int> { 1, 2 };
            GetLongestSubSequence(sequence);
            sequence = new List<int> { 1, 1 };
            GetLongestSubSequence(sequence);
            sequence = new List<int> { 1, 2, 2, 3 };
            GetLongestSubSequence(sequence);
            sequence = new List<int> { 1, 2, 2 };
            GetLongestSubSequence(sequence);
            sequence = new List<int> { 1, 1, 2 };
            GetLongestSubSequence(sequence);
            sequence = new List<int> { 1, 2, 2, 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            GetLongestSubSequence(sequence);
            sequence = new List<int> { 1, 2, 2, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3 };
            GetLongestSubSequence(sequence);
        }
    }
}