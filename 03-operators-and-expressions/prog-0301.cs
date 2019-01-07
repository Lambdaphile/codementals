/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write an expression that checks whether an integer is odd or even.
|
| Solutions and Guidelines:
|
|     Take the remainder of dividing the number by 2 and check
|     if it is 0 or 1 (respectively the number is odd or even).
|     Use % operator to calculate the remainder of integer division.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            Console.WriteLine(x % 2 == 0 ?
                "Number is even." : "Number is odd.");
        }
    }
}