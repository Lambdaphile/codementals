/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Write a program that calculates N!*K!/(N-K)!
|     for given N and K (1<K<N).
|
| Solutions and Guidelines:
|
|     One solution is to calculate separately each factorial
|     and at the end to perform the respective operations
|     with the results.
|
|     Think how you can optimize the calculations, in order
|     to not calculate too many factorials! In fractions of factorials
|     there are many possibilities to reduce the same factors
|     in the numerator and denominator. These optimizations will
|     not only reduce the calculations and increase the performance
|     but will save you from overflows in some situations.
|
|     You might need to use arrays num[0..N] and denum[0..n] to hold
|     the factors in the numerator and in the denominator
|     and to cancel the fraction.
|
|     You may read about arrays in the chapter “Arrays”.
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N! and K! (K < N):\n");
            Console.Write("N! = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K! = ");
            int K = int.Parse(Console.ReadLine());

            int nFactorial = 1, kFactorial = 1, mFactorial = 1;

            for (int i = N; i >= 1; i--)
            {
                nFactorial *= i;
                if (i <= K)
                    kFactorial *= i;
                if (i <= (N - K))
                    mFactorial *= i;
            }
            int result = (nFactorial * kFactorial) / mFactorial;

            Console.WriteLine("\nN! * K!/(N - K)! = {0}", result);
        }
    }
}