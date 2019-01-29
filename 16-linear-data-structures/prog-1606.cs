/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program that removes from a given sequence all
|     numbers that appear an odd count of times.
|
|       * array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}.
|
| Solutions and Guidelines:
|
|     Slow solution: pass through the elements with a for - loop.
|     For each element p count how many times p appears in the list
|     (with a nested for - loop). If it is even number of times,
|     append p to the result list (which is initially empty).
|     Finally print the result list.
|
|     Fast solution: use a hash-table (Dictionary<int, int> ).
|     With a single scan calculate count[p] (the number of occurrences
|     of p in the input sequence) for each number p from
|     the input sequence. With another single scan pass though
|     all numbers p and append p to the result only when count[p]
|     is even. Read about hash tables from the chapter
|     "Dictionaries, Hash-Tables and Sets".
|
*/

using System;
using System.Collections.Generic;

namespace Program
{
    public static class Program
    {
        public static bool IsOddSubsequence(List<int> sequence, int subsequenceElement)
        {
            int subsequenceLength = 0;
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i].Equals(subsequenceElement)) subsequenceLength++;
            }

            if (subsequenceLength % 2 != 0) return true;
            else return false;
        }

        public static List<int> RemoveOddSubsequences(List<int> sequence)
        {
            List<int> checkedElements = new List<int>();
            for (int i = 0; i < sequence.Count - 1;)
            {
                if (checkedElements.Contains(sequence[i]))
                {
                    i++; continue;
                }
                if(IsOddSubsequence(sequence, sequence[i]))
                {
                    int subsequenceElement = sequence[i]; i = 0;
                    sequence.RemoveAll(elements => elements == subsequenceElement);
                }
                else
                {
                    checkedElements.Add(sequence[i]); i++;
                }
            }

            return sequence;
        }

        public static void Main(string[] args)
        {
            List<int> sequence = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            sequence = RemoveOddSubsequences(sequence);
            foreach (int number in sequence)
            {
                Console.WriteLine($"{number} ");
            }
        }
    }
}