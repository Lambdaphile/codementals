/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     Write a program that for a given integers n and x,
|     calculates the sum:
|
|       * S = 1 + 1!...x + 2!...x.pow(2) + 3!...x.pow(n) + n!...
|
| Solutions and Guidelines:
|
|     You can solve the problem with a for-loop for k=0...n,
|     by using three additional variables factorial, power
|     and sum in which you will keep for the k th iteration
|     of the loop respectively k!, x k and the sum of the
|     first k members of sequence.
|
|     If your implementation is good, you should have only one
|     loop and you should not use external functions to calculate
|     factorials and to raise power.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integer n and x:\n");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());

            int factorial = 1, power = 1, sum = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power *= x;
                sum += factorial + sum;
            }
            Console.WriteLine("\nSum of the S = 1 + 1!...x + 2!...x.pow(2) + 3!...x.pow(n) + n!: {0}", sum);
        }
    }
}