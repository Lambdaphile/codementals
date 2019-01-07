/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Write a program, which generates and prints on the console
|     10 random numbers in the range [100, 200].
|
| Solutions and Guidelines:
|
|     Use the class Random. You may generate random numbers
|     in the range [100, 200] by calling Random.Next(100, 201).
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndInteger = new Random();

            Console.Write("10 random numbers in the range of 100 and 201:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" {0} ", rndInteger.Next(100, 201));
            }
        }
    }
}