/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write a method that checks whether an element, from a certain
|     position in an array is greater than its two neighbors.
|     Test whether the method works correctly.
|
| Solutions and Guidelines:
|
|     Just perform a check. The elements of the first and the last
|     position in the array will be compared only with their left
|     and right neighbor.
|     Test examples like GreaterThanNeighbors(new int[]{1,3,2}, 1)
|     -> true and GreaterThanNeighbors(new int[]{1}, 0) -> true.
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

            if (array[index] > array[index -1] && array[index] > array[index + 1])
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
            int[] array = { 2, 3, 6, 5, 2, 5, 3, 5 };
            int index = 2;

            if (GreaterThanNeighbors(array, index))
            {
                Console.WriteLine("Number ({0}) in index ({1}) is greater than it's neighbors.", array[index], index);
            }
            else
            {
                Console.WriteLine("Number ({0}) in index ({1}) is not greater than it's neighbors.", array[index], index);
            }

            //Unit tests...
            if (GreaterThanNeighbors(new int[] { 1, 3, 2 }, 1) == true)
                throw new Exception("1 > 3.");
            if (GreaterThanNeighbors(new int[] { 1 }, 0) == true)
                throw new Exception("Array with single elements do not have neighbors.");
        }
    }
}