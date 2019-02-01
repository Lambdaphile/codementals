/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write a program that prints on the console the numbers
|     from 1 to N. The number N should be read from the
|     standard input.
|
| Solutions and Guidelines:
|
|     Use a for-loop.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter how many numbers you want to print (from 1 to N):");
            Console.Write("\nN = ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("\nPrinting from 1 to {0}: ", n);
            for (int i = 1; i <= n; i++) Console.Write("{0} ",i);
            Console.WriteLine();
        }
    }
}