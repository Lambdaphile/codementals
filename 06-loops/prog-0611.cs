/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Write a program that calculates with how many zeros
|     the factorial of a given number ends. Examples:
|
|       * N = 10 -> N! = 3628800 -> 2
|         N = 20 -> N! = 2432902008176640000 -> 4
|
| Solutions and Guidelines:
|
|     The number of zeros at the end of n! depends on how
|     many times the number 10 is a divisor of the factorial.
|     Because the product 1 * 2 * ... * n has a greater number
|     of divisors 2, than 5 and because 10 = 2 * 5, then the
|     number of zeros in n! is exactly as many as the
|     multipliers with value 5 in the product 1 * 2 * 3 *... * n.
|     Because every fifth number is divisible by 5, and every
|     25th number is divisible by 5 two times, etc., the number
|     of zeros in n! is the sum: n / 5 + n / 25 + n / 125 + ...
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter an integer:\n");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            double factorial = n;
            for (int i = n - 1; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("\nn! = {0}", factorial);

            int counter = 0;
            while (factorial % 10 == 0)
            {
                factorial /= 10;
                counter++;
            }
            Console.WriteLine("\nThe factorial ends with {0} zero/s at end.", counter);
        }
    }
}