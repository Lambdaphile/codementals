/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write a program, which compares correctly two real numbers with
|     accuracy at least 0.000001.
|
| Solutions and Guidelines:
|
|     Two floating-point variables are considered equal if their
|     difference is less than some predefined precision (e.g. 0.000001):
|
|       * bool equal = Math.Abs(a - b) < 0.000001;
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 23.456789;
            double b = 23.456789345;
            bool equal = Math.Abs(a - b) < 0.000001;

            Console.WriteLine(equal);
        }
    }
}