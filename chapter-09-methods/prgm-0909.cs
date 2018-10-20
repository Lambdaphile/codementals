/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     Write a method that finds the biggest element of an array
|     in a given range.
|     Use that method to implement sorting in descending order.
|
| Solutions and Guidelines:
|
|     First write a method that finds the biggest element in array
|     and then modify it to find the biggest element in given range
|     of the array, e.g. in the elements at indexes [3...10].
|
|     Finally find the biggest number in the range [1...n-1]
|     and swap it with the first element, then find the biggest
|     element in the range [2...n-1] and swap it with the second
|     element of the array and so on.
|     Think when the algorithm should finish.
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
        // Insertion sort method in descending order.
        public static int[] Sort(int[] array, int fromIndex, int toIndex)
        {
            int biggestInteger = 0;
            int biggestIntegerIndex = fromIndex;

            for (int i = fromIndex; i <= toIndex - 1; i++)
            {
                for (int j = i; j <= toIndex; j++)
                {
                    if (biggestInteger < array[j])
                    {
                        biggestInteger = array[j];
                        biggestIntegerIndex = j;
                    }
                }
                // Insertion is happening there.
                int temp = array[i];
                array[i] = biggestInteger;
                array[biggestIntegerIndex] = temp;

                biggestInteger = 0;
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] array = { 2, 3, 5, 7, 5, 8, 4 };
            int fromIndex = 0;
            int toIndex = 6;

            array = Sort(array, fromIndex, toIndex);

            Console.WriteLine("Biggest integer within the given range of the array is: {0}\n", array[fromIndex]);

            Console.Write("After sorting the array from index {0} to index {1}: ", fromIndex, toIndex);
            foreach (var element in array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}