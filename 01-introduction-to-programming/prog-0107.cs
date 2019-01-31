/*
|--------------------------------------------------------------------------
| Chapter 1. Introduction to Programming
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Write a program that prints the first 100 members
|     of the sequence 2, -3, 4, -5, 6, -7, 8.
|
| Solutions and Guidelines:
|
|     Try to learn on your own how to use loops in C#.
|     You may read about for - loops in the chapter “Loops”.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 100 members of the sequence (2, -3, 4, -5, 6, -7, 8): ");
            for (int i = 2; i <= 100; i++)
                Console.WriteLine(i % 2 == 0 ? i : -i);
        }
    }
}