/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Write a program to find a sequence of neighbor numbers
|     in an array, which has a sum of certain number S.
|
|       * Example: {4, 3, 1, 4, 2, 5, 8}, S = 11 -> {4, 2, 5}.
|
| Solutions and Guidelines:
|
|     This exercise can be solved with two nested loops.
|     The first loop assigns a starting index. The second loop
|     sums the elements from the starting index to the right until
|     this partial sum reaches or is greater than S.
|     If the sum is equal to S, we will remember the starting index
|     (from the first loop) and the ending index (from the second loop).
|
|     If all numbers are positive, there is a much faster algorithm.
|     We sum all numbers from left to the right, starting from zero.
|     If the current sum becomes greater than S during the summation,
|     we remove the leftmost number in the sequence and we subtract it
|     from the sum. If the current sum is still greater than S, we
|     remove the next leftmost number and do that until the current
|     sum becomes smaller than S. When the sum becomes smaller than S
|     we add the next number on right. If we find a sum equal to S,
|     we print the sum and the sequence to the console.
|     So this solution uses just with one scan through the elements
|     in the array.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("S = ");
            int s = int.Parse(Console.ReadLine());

            int[] arrayX = { 4, 3, 1, 4, 2, 5, 8 };

            for (int i = 0; i < arrayX.Length - 1; i++)
            {
                int counter = 0;
                for (int j = i; j < arrayX.Length; j++)
                {
                    if (counter < s)
                    {
                        counter += arrayX[j];
                    }

                    if (counter == s)
                    {
                        Console.Write("S = {0} -> {{ ", s);
                        for (int x = i; x <= j ; x++)
                        {
                            if (x < j)
                            {
                                Console.Write("{0}, ", arrayX[x]);
                            }
                            else
                            {
                                Console.Write("{0} }}\n", arrayX[x]);
                            }
                        }
                        // We exit the loop since the condition of the exercise is met.
                        break;
                    }

                    if (counter > s)
                    {
                        break;
                    }
                }
            }
        }
    }
}