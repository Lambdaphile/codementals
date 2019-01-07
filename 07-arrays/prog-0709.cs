/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     Write a program, which finds a subsequence of numbers
|     with maximal sum.
|
|       * E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> 11
|
| Solutions and Guidelines:
|
|     There are two ways to solve this problem. The first way is to
|     use brute force method, which in this case means that using
|     two nested loops we check every possible start and end
|     and it's corresponding sum.
|
|     The second way is to use one loop through the array to scan it
|     from left to right and sum the elements. Once we get a negative
|     sum, we can restart summing from the next element.
|     Think why this is correct! At each step we check if the current
|     sum is greater than the current max.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayX = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int sum = 0, maxSum = 0;
            for (int i = 0; i < arrayX.Length; i++)
            {
                sum += arrayX[i];

                if (sum < 0)
                {
                    sum = 0;
                }

                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
            Console.WriteLine("Maximal subsequence sum in the given array: {0}", maxSum);
        }
    }
}