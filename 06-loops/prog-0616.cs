/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 16:
|
|     Write a program that by a given integer N prints the
|     numbers from 1 to N in random order.
|
| Solutions and Guidelines:
|
|     Search in the Internet for information about the class
|     System.Random. Read in the Internet about arrays
|     (or in the next chapter). Create an array with N elements
|     and write in it the numbers from 1 to N. After that
|     a few times (think exactly how many) swap two random pairs
|     of elements from the array.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the length of the wanted sequence (from 1 to n): ");
            int n = int.Parse(Console.ReadLine());

            int[] rndArr = new int[n];
            for (int i = 0; i < n; i++) rndArr[i] = i + 1;

            Random rnd = new Random();
            int rndIndex;
            for (int i = 0; i < rndArr.Length; i++)
            {
                int container = rndArr[i];
                rndIndex = rnd.Next(1, n);
                rndArr[i] = rndArr[rndIndex];
                rndArr[rndIndex] = container;
            }
            Console.Write("\nAfter randomizing the sequence indexes: ");
            foreach (var num in rndArr)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine();
        }
    }
}