/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write an expression that calculates the area of a
|     trapezoid by given sides a, b and height h.
|
| Solutions and Guidelines:
|
|     The formula for trapezoid surface is: S = (a + b) * h / 2.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5, h = 8;
            int S = (a + b) * h / 2;
            Console.WriteLine("Area of the trapezoid: {0}", S);
        }
    }
}