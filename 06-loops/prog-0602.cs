/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Write a program that prints on the console the numbers from
|     1 to N, which are not divisible by 3 and 7 simultaneously.
|     The number N should be read from the standard input.
|
| Solutions and Guidelines:
|
|     Use a for-loop and the operator % for finding the remainder
|     in integer division. A number num is not divisible by 3 and 7
|     simultaneously exactly when (num % (3*7) == 0).
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, the length of the wanted sequence (from 1 to N):");
            Console.Write("\nN = ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPrinting from 1 to {0} which are (% (3 * 5) != 0):", n);
            for (int i = 1; i <= n; i++)
            {
                if (i % (3 * 7) != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}