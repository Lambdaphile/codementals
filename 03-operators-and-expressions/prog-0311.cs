/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     We are given a number n and a position p. Write a sequence
|     of operations that prints the value of the bit on the position
|     p in the number (0 or 1). Example: n=35, p=5 -> 1.
|
|       * Another example: n=35, p=6 -> 0.
|
| Solutions and Guidelines:
|
|     Use bitwise operations:
|
|       * int n = 35; // 00100011
|         int p = 6;
|         int i = 1; // 00000001
|         int mask = i << p; // Move the 1-st bit left by p positions
|
|     If i & mask are positive then the p-th bit of n is 1:
|     Console.WriteLine((n & mask) != 0 ? 1 : 0);
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            Console.Write("\nNumber = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the position:");
            Console.Write("\nPosition = ");
            int p = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? "\n1" : "0");
        }
    }
}