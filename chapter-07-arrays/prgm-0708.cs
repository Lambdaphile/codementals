/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Sorting an array means to arrange it's elements in an increasing
|     (or decreasing) order. Write a program, which sorts an array using
|     the algorithm "selection sort".
|
| Solutions and Guidelines:
|
|     Find in Internet information about "Selection sort" and it's C#
|     implementations. Briefly the idea is to find the smallest element
|     and to place it at position 0 (through swapping) then to find
|     the smallest number excluding the first and place it at position 1
|     and so on, until the entire array is arranged in ascending order.
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
            int[] arrayX = { 5, 3, 1, 4, 2 };

            int minIndex;
            for (int i = 0; i < arrayX.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arrayX.Length; j++)
                {
                    if (arrayX[minIndex] > arrayX[j])
                    {
                        minIndex = j;
                    }
                }
                int temp = arrayX[i];
                arrayX[i] = arrayX[minIndex];
                arrayX[minIndex] = temp;
            }

            Console.Write("The array after selection sort in increasing order: { ");
            for (int i = 0; i < arrayX.Length; i++)
            {
                if (i < arrayX.Length - 1)
                {
                    Console.Write("{0}, ", arrayX[i]);
                }
                else
                {
                    Console.Write("{0} ", arrayX[i]);
                }
            }
            Console.Write("}\n");
        }
    }
}