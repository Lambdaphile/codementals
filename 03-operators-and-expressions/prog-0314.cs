/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 14:
|
|     Write a program that checks if a given number n (1 < n < 100)
|     is a prime number (i.e. it is divisible without remainder only
|     to itself and 1).
|
| Solutions and Guidelines:
|
|     Read about loops in the Internet or in the chapter “Loops”.
|     Use a loop and check the number for divisibility by all integers
|     from 1 to the square root of the number.
|     Since n < 100, you can find in advance all prime numbers
|     from 1 to 100 and checks the input over them.
|
|     The prime numbers in the range [1...100] are:
|     2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47,
|     53, 59, 61, 67, 71, 73, 79, 83, 89 and 97.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that's 1 < n < 100:");
            Console.Write("\nNumber = ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 2)
            {
                Console.WriteLine("The given number {0} is prime.", n);
            }
            else
            {
                for (int i = 3; i < 100; i += 2)
                {
                    if (n == i)
                    {
                        Console.WriteLine("The given number is prime.");
                        break;
                    }
                    else if (i > 97) Console.WriteLine("The given number is not prime.");
                }
            }
        }
    }
}