/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 13:
|
|     We are given the number n, the value v (v = 0 or 1)
|     and the position p. Write a sequence of operations that changes
|     the value of n, so the bit on the position p has the value of v.
|
|       * Example: n=35, p=5, v=0 -> n=3.
|       * Another example: n=35, p=2, v=1 -> n=39.
|
| Solutions and Guidelines:
|
|     Use bitwise operations by analogy with the previous two problems.
|     You can reset the bit at position p in the number n as follows:
|
|       * n = n & (~(1 << p));
|
|     You can set bits in the unit at position p in the number n
|     as follows:
|
|       * n = n | (1 << p);
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            Console.Write("Number = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the position: ");
            Console.Write("Position = ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter value for position (0 or 1):");
            Console.Write("Value = ");
            int v = Convert.ToInt32(Console.ReadLine());

            v = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);

            Console.WriteLine("Number after the digit change equals to: {0}", n);
        }
    }
}