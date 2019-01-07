/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     In combinatorics, the Catalan numbers are calculated by
|     the following formula:
|
|       * C(n) = (2 * n)! / ((n + 1)! * n!), for n >= 0.
|
|     Write a program that calculates the nth Catalan number by given n.
|
| Solutions and Guidelines:
|
|     Use the same concept of canceling the faction of simple factors,
|     like you probably did in the previous problem.
|     You may also read more about the Catalan numbers in Wikipedia
|     (http://en.wikipedia.org/wiki/Catalan_number) and use the
|     recurrent formula for calculating them.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter wanted n'th Catalan number (n >= 0): ");
            int n = int.Parse(Console.ReadLine());

            int aFactorial = n * 2, nFactorial = 1;

            for (int i = aFactorial - 1; i > 0; i--)
            {
                // Getting the (2 * n)! part of the formula...
                aFactorial *= i;
                // Getting the n! factorial...
                if (i <= n)
                    nFactorial *= i;
            }
            // There instead of calculating (n + 1)! * n!
            // We only calculate n! and then do (n + 1) * n! * n!)
            // Which saves us from calculating (n + 1)! factorial...
            int nthCatalanNum = aFactorial / ((n + 1) * nFactorial * nFactorial);

            Console.WriteLine("\nCatalan({0}) has {1} combinations.", n, nthCatalanNum);
        }
    }
}