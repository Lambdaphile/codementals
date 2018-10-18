/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 12:
|
|     Write a program that converts a given number from decimal
|     to binary notation (numeral system).
|
| Solutions and Guidelines:
|
|     Read in Wikipedia what numeral systems are:
|     http://en.wikipedia.org/wiki/Numeral_system.
|     After that consider how you can convert numbers from decimal
|     numeral system to another. Think about the opposite – moving
|     from another numeral system to decimal. If you have difficulty,
|     see the chapter "Numeral Systems".
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter an integer in decimal notation:\n");
            Console.Write("Integer: ");
            int n = int.Parse(Console.ReadLine());

            int remainder;
            string result = null;
            while (n > 0)
            {
                remainder = n % 2;
                n /= 2;
                result = remainder.ToString() + result;
            }

            Console.WriteLine("\nBinary representation: {0}", result);
        }
    }
}