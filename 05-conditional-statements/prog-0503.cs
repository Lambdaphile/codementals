/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write a program that finds the biggest of three integers,
|     using nested if statements.
|
| Solutions and Guidelines:
|
|     Use nested if-statements, first checking the first two numbers
|     then checking the bigger of them with the third.
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
            Console.WriteLine("Enter three numbers:");
            Console.Write("First number = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number = ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("First number is biggest.");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Second number is the biggest.");
                }
                else
                {
                    Console.WriteLine("Third number is the biggest");
                }
            }
        }
    }
}