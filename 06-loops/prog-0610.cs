/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     Write a program that reads from the console a positive
|     integer number N (N < 20) and prints a matrix of numbers
|     as on the figures below:
|
|       * N = 3          N = 4
|
|         1  2  3        1  2  3  4
|         2  3  4        2  3  4  5
|         3  4  5        3  4  5  6
|                        4  5  6  7
|
| Solutions and Guidelines:
|
|     You should use two nested loops, similar to the problem
|     "Printing a Triangle". The outer loop must run from 1
|     to N, and the inner – from the value of the outer loop
|     to the value of the outer loop + N - 1.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter positive integer number (N < 20):");
            Console.Write("\nN = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int outerLoop = 1; outerLoop <= N; outerLoop++)
            {
                for (int innerLoop = outerLoop; innerLoop <= outerLoop + N - 1; innerLoop++)
                    Console.Write("{0} ", innerLoop);
                Console.WriteLine();
            }
        }
    }
}