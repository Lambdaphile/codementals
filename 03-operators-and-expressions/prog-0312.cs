/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 12:
|
|     Write a Boolean expression that checks if the bit on position
|     p in the integer v has the value 1. Example v=5, p=1 -> false.
|
| Solutions and Guidelines:
|
|     The task is similar to the previous one.
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
            Console.Write("\nNumber = ");
            int v = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter bit position:");
            Console.Write("\nPosition = ");
            int p = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int mask = i << p;

            bool isNotZero = (v & mask) != 0;

            Console.WriteLine(isNotZero ? "Value of the bit on position {0} is 1." :
                "Value of the bit on position {0} is 0.", p);
        }
    }
}