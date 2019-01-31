/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 12:
|
|     Write a program that calculates the sum (with precision
|     of 0.001) of the following sequence:
|
|       * 1 + 1 / 2 - 1 / 3 + 1 / 4 - 1 / 5 + ...
|
| Solutions and Guidelines:
|
|     Accumulate the sum of the sequence in a variable inside
|     a while-loop (see the chapter "Loops"). At each step
|     compare the old sum with the new sum. If the difference
|     between the two sums Math.Abs(current_sum – old_sum) is
|     less than the required precision (0.001), the calculation
|     should finish because the difference is constantly
|     decreasing and the precision is constantly increasing at
|     each step of the loop. The expected result is 1.307.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentSum = 1, previousSum = currentSum, divisor = 2;
            do
            {
                previousSum = currentSum;
                currentSum = divisor % 2 == 0 ? currentSum += 1 / divisor : currentSum -= 1 / divisor;
                divisor++;
                Console.WriteLine("{0:f3}", currentSum);
            } while (Math.Abs(currentSum - previousSum) > 0.001);
        }
    }
}