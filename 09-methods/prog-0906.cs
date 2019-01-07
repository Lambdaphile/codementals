/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a method that returns the position of the first occurrence
|     of an element from an array, such that it is greater than its two
|     neighbors simultaneously. Otherwise the result must be -1.
|
| Solutions and Guidelines:
|
|     Invoke the method from the previous problem in a for-loop.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static bool GreaterThanNeighbors(int[] array, int index)
        {
            if (index == 0)
            {
                if (array[index] > array[index + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (index == (array.Length - 1))
            {
                if (array[index] > array[index - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 2, 3, 5, 7, 3, 6 };
            // i = 1; i < array.Length -1; to avoid
            // checking elements with only one neighbor.
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (GreaterThanNeighbors(array, i))
                {
                    Console.WriteLine("First element which is greater than it's neighbors is at index ({0}).", i);
                    break; // To avoid unnecessary cycling and ease the readability.
                }
                // End of the array is reached.
                // No elements which is greater than it's neighbors.
                if (i == (array.Length - 2))
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}