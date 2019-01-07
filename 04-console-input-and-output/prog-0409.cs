/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     Write a program that reads an integer number n from the console.
|     After that reads n numbers from the console and prints their sum.
|
| Solutions and Guidelines:
|
|     You should use a for-loop (see the chapter "Loops").
|     Read the numbers one after another and accumulate their sum
|     in a variable, which then display on the console at the end.
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
            Console.Write("How many numbers would you like to enter: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long sum = 0;
            Console.WriteLine("\nEnter {0} numbers:\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("\nSum of the entered numbers is: {0}.", sum);
        }
    }
}