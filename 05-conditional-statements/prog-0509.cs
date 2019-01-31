/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     We are given 5 integer numbers. Write a program that
|     finds those subsets whose sum is 0.
|
|       * Examples:
|
|         If we are given the numbers {3, -2, 1, 1, 8},
|         the sum of -2, 1 and 1 is 0.
|
|         If we are given the numbers {3, 1, -7, 35, 22},
|         there are no subsets with sum 0.
|
| Solutions and Guidelines:
|
|     Use nested if statements or series of 31 comparisons,
|     in order to check all the sums of the 31 subsets of
|     the given numbers (without the empty one). Note that
|     the problem in general (with N numbers) is complex
|     and using loops will not be enough to solve it.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = new int[5];
            Console.WriteLine("Please, enter five integers:\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Integer {0}: ", i + 1);
                set[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int subsetSum;
            bool hasSubsetSumEqualZero = false;
            for (int i = 0; i < set.Length; i++)
            {
                subsetSum = set[i];

                for (int j = i + 1; j < set.Length; j++)
                {
                    subsetSum += set[j];
                    if (subsetSum == 0)
                    {
                        Console.WriteLine("Subsets whose sum equals 0:");
                        int targetIntegerIndex = i;
                        while (targetIntegerIndex <= j)
                        {
                            Console.Write(" {0} ", set[targetIntegerIndex]);
                            targetIntegerIndex++;
                        }
                        Console.WriteLine();
                        hasSubsetSumEqualZero = true;
                    }
                }
            }
            if (hasSubsetSumEqualZero != true)
            {
                Console.WriteLine("There are no subsets whose sum equals 0.");
            }
        }
    }
}