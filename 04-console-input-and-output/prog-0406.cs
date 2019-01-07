/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program that reads two numbers from the console
|     and prints the greater of them. Solve the problem
|     without using conditional statements.
|
| Solutions and Guidelines:
|
|     Since the problem requires a solution, which does not use
|     conditional statements, you should use a different approach.
|     Two possible solutions of the problem include the use
|     of functions of class Math. The greater of the two numbers
|     you can find with the function Math.Max(a, b) and the smaller
|     with Math.Min(a, b).
|
|     Another solution to the problem includes usage of the function
|     for taking the absolute value of a number Math.Abs(a):
|
|       * int a = 2011;
|         int b = 1990;
|         Console.WriteLine("Greater: {0}",
|             (a + b + Math.Abs(a-b)) / 2);
|         Console.WriteLine("Smaller: {0}",
|             (a + b - Math.Abs(a-b)) / 2);
|
|     The third solution uses bitwise operations:
|
|       * int a = 1990;
|         int b = 2011;
|         int max = a - ((a - b) & ((a - b) >> 31));
|         Console.WriteLine(max);
|
|     There is another solution which is partially correct because it
|     uses a hidden conditional statement (the ternary ?: operator):
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nb = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNumber {0} is greater than number {1}.", Math.Max(a, b), Math.Min(a, b));
        }
    }
}