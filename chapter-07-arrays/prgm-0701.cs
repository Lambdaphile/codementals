/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| # Exercise 1:
|
|   - Write a program, which creates an array of 20 elements of type
|     integer and initializes each of the elements with a value equals
|     to the index of the element multiplied by 5.
|     Print the elements to the console.
|
| # Solutions and Guidelines:
|
|   - Use an int[] array and a for-loop.
|
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array with indexes equal i * 5:\n");

            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            Console.WriteLine(" ");
        }
    }
}