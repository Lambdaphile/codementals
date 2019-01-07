/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write a program, which compares two arrays of type char
|     lexicographically (character by character) and checks,
|     which one is first in the lexicographical order.
|
| Solutions and Guidelines:
|
|     In lexicographic order the elements are compared one by one
|     starting from the very left. If the elements are not the same,
|     the array, whose element is smaller (comes earlier in the alphabet),
|     comes first. If the elements are equal, the next character
|     is compared. If the end of one of the arrays is reached, without
|     finding different elements, the shorter array is the smaller
|     (comes earlier lexicographically).
|     If all elements are equal, the arrays are equal.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayA = { 'b', 'a', 'a' };
            char[] arrayB = { 'b', 'c', 'a' };

            // Getting the length of the smaller array or the length of both if they are equal.
            int smallerArrayLength = Math.Min(arrayA.Length, arrayB.Length);

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (arrayA[i] != arrayB[i])
                {
                    Console.WriteLine(arrayA[i] < arrayB[i] ?
                           "arrayA is lexicographically first." : "arrayB is lexicographically first.");

                    break; // To eliminate unnecessary cycling.
                }
                // When the arrays are lexicographically equal and their size is same.
                if (i == (smallerArrayLength - 1) && (arrayA.Length == arrayB.Length))
                {
                    Console.WriteLine("Arrays are lexicographically equal.");
                }
                // When the arrays are lexicographically equal, but their size is not equal.
                if (i == (smallerArrayLength - 1) && (arrayA.Length != arrayB.Length))
                {
                    Console.WriteLine(arrayA.Length < arrayB.Length ?
                               "arrayA is lexicographically first." : "arrayB is lexicographically first.");
                }
            }
        }
    }
}