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
| Solutions and Guidelines:
|
|     Slow solution: pass through the elements with a for -loop.
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
        public static List<int> GetOccurenceCount(List<int> sequence)
        {
            int appearCount = 1;
            List<int> result = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                for (int j = i + 1; j < sequence.Count - 1; j++)
                {
                    if (sequence[j] == sequence[i])
                        appearCount++;
                }
                if (appearCount % 2 == 0)
                {
                    result.Add(sequence[i]);
                    sequence.RemoveAll(num => num == sequence[i]);
                }
                appearCount = 1;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            List<int> sequence = new List<int> { 1, 1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6, 6 };
            sequence = GetOccurenceCount(sequence);
            foreach (int num in sequence)
                Console.WriteLine(num);
        }
    }
}