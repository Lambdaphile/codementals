/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program, which finds the maximal sequence of increasing
|     elements in an array arr[n]. It is not necessary the elements
|     to be consecutively placed.
|
|       * E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} -> {2, 4, 6, 8}.
|
| Solutions and Guidelines:
|
|     We can solve the problem with two nested loops and one more array
|     len[0...n-1]. In the array len[i] we can keep the length of the
|     longest consecutively increasing sequence, which starts somewhere
|     in the array (it does not matter where exactly) and ends with
|     the element arr[i].
|
|     Therefore len[0]=1, len[x] is the maximal sum max(1 + len[prev]),
|     where prev < x and arr[prev] < arr[x]. Following the definition,
|     we can calculate len[0…n-1] with two nested loops: the outer loop
|     will iterate through the array from left to right with the
|     loop variable x.
|
|     The inner loop will iterate through the array from the start to
|     position x-1 and searches for the element prev with maximal value
|     of len[prev], where arr[prev] < arr[x]. After the search, we
|     initialize len[x] with 1 + the biggest found value of len[prev]
|     or with 1, if such a value is not found.
|
|     The described algorithm finds the lengths of all maximal ascending
|     sequences, which end at each of the elements. The biggest one of
|     these values is the length of the longest increasing sequence.
|     If we need to find the elements themselves, which compose that
|     longest sequence, we can start from the element, where the sequence
|     ends (at index x), we can print it and we can search for a previous
|     element (prev). By definition prev < x and len[x] = 1 + len[prev]
|     so we can find prev with a for-loop from 1 to x-1. After that we
|     can repeat the same for x=prev.
|
|     By finding and printing the previous element (prev) many times
|     until it exists, we can find the elements, which compose the longest
|     sequence in reversed order (from the last to the first).
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayX = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            int n = arrayX.Length;
            int[] lis = new int[n];
            int i, j, max = 0;

            /* Initialize LIS values for all indexes */
            for (i = 0; i < n; i++)
                lis[i] = 1;

            /* Compute optimized LIS values in bottom up manner */
            for (i = 1; i < n; i++)
                for (j = 0; j < i - 1; j++)
                    if (arrayX[i] > arrayX[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;

            /* Pick maximum of all LIS values */
            for (i = 0; i < n; i++)
                if (max < lis[i])
                    max = lis[i];

            for (int b = 1; b < arrayX.Length; b++)
            {
                if (b == 0 && lis[b] < lis[b+1])
                {
                    Console.WriteLine(arrayX[b]);
                }

                if (b > 0 && lis[b + 1] > lis[b])
                {
                    Console.WriteLine(arrayX[b]);
                }
            }
        }
    }
}