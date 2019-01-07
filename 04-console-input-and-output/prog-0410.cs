/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     Write a program that reads an integer number n from the console
|     and prints all numbers in the range [1…n], each on a separate line.
|
| Solutions and Guidelines:
|
|     Use a combination of loops (see the chapter "Loops")
|     and the methods Console.ReadLine(), Console.WriteLine()
|     and Int32.Parse().
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:\n");
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nNumbers in range [1...n]:\n");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}