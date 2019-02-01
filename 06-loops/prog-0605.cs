/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write a program that reads from the console number N
|     and print the sum of the first N members of the
|     Fibonacci sequence:
|
|       * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377...
|
| Solutions and Guidelines:
|
|     Fibonacci numbers start from 0 and 1, each additional is
|     obtained as the sum of the previous two. You can find the
|     first n Fibonacci numbers with a for - loop from 1 to n,
|     and at each iteration calculate the next number by using
|     the previous two (which you will keep in two additional
|     variables).
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter desired N members of the Fibonacci sequence:");
            Console.Write("\nN = ");
            int n = int.Parse(Console.ReadLine());

            int fibA = 0, fibB = 1, member = 0, sum = 0;
            Console.Write("\nFirst {0} members of the Fibonacci sequence: ", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", member);
                sum += member;
                fibA = fibB;
                fibB = member;
                member = fibA + fibB;
            }
            Console.WriteLine("\n\nSum of the first {0} members of the Fibonacci sequence: {1}", n, sum);
        }
    }
}