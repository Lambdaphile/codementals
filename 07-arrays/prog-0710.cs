/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     Write a program, which finds the most frequently occurring
|     element in an array.
|
|       * Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times).
|
| Solutions and Guidelines:
|
|     This exercise can be solved with two nested loops.
|     The first loop assigns a starting index. The second loop sums
|     the elements from the starting index to the right until this
|     partial sum reaches or is greater than S. If the sum is equal
|     to S, we will remember the starting index (from the first loop)
|     and the ending index (from the second loop).
|
|     If all numbers are positive, there is a much faster algorithm.
|     We sum all numbers from left to the right, starting from zero.
|     If the current sum becomes greater than S during the summation,
|     we remove the leftmost number in the sequence and we subtract it
|     from the sum. If the current sum is still greater than S, we remove
|     the next leftmost number and do that until the current sum becomes
|     smaller than S. When the sum becomes smaller than S we add the
|     next number on right. If we find a sum equal to S, we print the
|     sum and the sequence to the console. So this solution uses just
|     with one scan through the elements in the array.
|
*/
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayX = { 4, 1, 1, 4, 2, 1, 4, 4, 1, 2, 4, 1, 1 };

            int occurrenceCounter = 1, maxOccurrenceCounter = 0, maxOccuringElement = 0;
            Console.Write("{");
            for (int i = 0; i < arrayX.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayX.Length; j++)
                {
                    if (arrayX[j] == arrayX[i])
                    {
                        occurrenceCounter++;
                    }
                }
                if (occurrenceCounter > maxOccurrenceCounter)
                {
                    maxOccurrenceCounter = occurrenceCounter;
                    maxOccuringElement = arrayX[i];
                }
                occurrenceCounter = 1;

                //Printing part
                if (i < arrayX.Length - 2)
                {
                    Console.Write(" {0},", arrayX[i]);
                }
                else
                {
                    Console.Write(" {0}, {1}", arrayX[i], arrayX[i + 1]);
                }
            }
            Console.Write(" }} -> {0} ({1} times).\n", maxOccuringElement, maxOccurrenceCounter);
        }
    }
}