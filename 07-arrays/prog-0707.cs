/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Write a program, which reads from the console two integer numbers
|     N and K (K<N) and array of N integers. Find those K consecutive
|     elements in the array, which have maximal sum.
|
| Solutions and Guidelines:
|
|     You can find out which sequence of the sequences of K numbers
|     has the biggest sum by checking the sums of all of those sequences.
|     The first sequence starts at index 0 and finishes at index K-1
|     and has sum S. Then the second one starts at index 1 and ends at
|     index K and we can find its sum using S by subtracting the element
|     at index 0 and adding the element at index K. In this way we can
|     reach the end of the sequence.
|
|     By finding and printing the previous element (prev) many times
|     until it exists, we can find the elements, which compose
|     the longest sequence in reversed order (from the last to the first).
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integers (K < N):");
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int k;
            do
            {
                Console.Write("K = ");
                k = int.Parse(Console.ReadLine());
                if (k >= n)
                    Console.WriteLine("\nPlease, try again (K < N).\n");
            } while (k >= n);

            int[] arrayX = new int[n];
            Console.WriteLine("Please, enter arrays variables. Array[n].\n");
            for (int i = 0; i < arrayX.Length; i++)
            {
                Console.Write("arrayX[{0}] = ", i);
                arrayX[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0, maxSum = 0, maxSumIndex = 0;
            for (int i = 0; i < n; i++)
            {
                //We get the sum of first K consecutive elements.
                if (i < k)
                {
                    sum += arrayX[i];
                }

                // After we get the others.
                if (i >= k)
                {
                    sum = (sum - arrayX[i - k]) + arrayX[i];
                }

                // And find which has biggest sum.
                if (maxSum < sum)
                {
                    maxSum = sum;
                    maxSumIndex = i;
                }
            }

            Console.Write("\nElements with max sum: { ");
            for (int i = 0; i < n; i++)
            {
                if (i < n - 1)
                    Console.Write("{0}, ", arrayX[i]);
                else
                    Console.Write("{0}", arrayX[i]);

            }
            Console.Write("} -> { ");
            for (int i = maxSumIndex - (k - 1); i <= maxSumIndex; i++)
            {
                if (i <= maxSumIndex - 1)
                    Console.Write("{0}, ", arrayX[i]);
                else
                    Console.Write("{0}", arrayX[i]);
            }
            Console.WriteLine(" }");
            Console.WriteLine("\nMax sum: {0}", maxSum);
        }
    }
}