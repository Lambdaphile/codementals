/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write an expression that looks for a given integer
|     if it's third digit (right to left) is 7.
|
| Solutions and Guidelines:
|
|     Divide the number by 100 and save it in a new variable,
|     which then divide by 10 and take the remainder.
|     The remainder of the division by 10 is the third digit of
|     the original number. Check if it is equal to 7.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3700, b = a / 100, x = b % 10;
            Console.WriteLine(x == 7 ? "Third digit is 7." : "Third digit is not 7.");
        }
    }
}