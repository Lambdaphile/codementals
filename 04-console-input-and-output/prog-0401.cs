/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write a program that reads from the console three numbers
|     of type int and prints their sum.
|
| Solutions and Guidelines:
|
|     Use the methods Console.ReadLine() and Int32.Parse().
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter three numbers: ");
            Console.Write("Number 1 = ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Number 2 = ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Number 3 = ");
            int num3 = Int32.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;

            Console.WriteLine("Sum of the numbers {0}, {1}, {2}: {3}", num1, num2, num3, sum);
        }
    }
}