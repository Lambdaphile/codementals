/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 17:
|
|     Write a program that given two numbers finds their greatest
|     common divisor (GCD) and their least common multiple (LCM).
|     You may use the formula LCM(a, b) = |a*b| / GCD(a, b).
|
| Solutions and Guidelines:
|
|     Search the Internet for the Euclidean algorithm for calculation
|     the greatest common divisor (CGD) or read about it in Wikipedia:
|     http://en.wikipedia.org/wiki/Euclidean_algorithm.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integers:");
            Console.Write("\na = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int num2 = int.Parse(Console.ReadLine());

            int a = num1, b = num2;

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            int GCD = a;

            int LCM = (num1 * num2) / GCD;

            Console.WriteLine("\nGCD({0}, {1}) = {2}", num1, num2, GCD);
            Console.WriteLine("LCM({0}, {1}) = {2}", num1, num2, LCM);
        }
    }
}