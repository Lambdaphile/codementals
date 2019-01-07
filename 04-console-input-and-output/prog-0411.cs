/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Write a program that prints on the console the first 100 numbers
|     in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,
|     55, 89, 144, 233, …
|
| Solutions and Guidelines:
|
|     More about the Fibonacci sequence can be found in Wikipedia at:
|     http://en.wikipedia.org/wiki/Fibonacci_sequence.
|     For the solution of the problem use 2 temporary variables
|     in which store the last 2 calculated values and with a loop
|     calculate the rest (each subsequent number in the sequence
|     is a sum of the last two). Use a for-loop to implement
|     the repeating logic (see the chapter "Loops").
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 0, fib2 = 1, sum = 0;

            for (int i = 0; sum < 100 ; i++)
            {
                Console.WriteLine(sum);
                fib1 = fib2;
                fib2 = sum;
                sum = fib1 + fib2;
            }
        }
    }
}