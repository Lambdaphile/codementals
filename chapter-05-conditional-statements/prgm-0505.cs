/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write a program that asks for a digit (0-9), and depending
|     on the input, shows the digit as a word (in English).
|     Use a switch statement.
|
| Solutions and Guidelines:
|
|     Just use a switch statement to check for all possible digits.
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
            Console.Write("Please, enter a digit from 0-9: ");
            int digit = Int32.Parse(Console.ReadLine());

            Console.Write("\nNumber you entered in words: ");
            switch (digit)
            {
                case 0:
                    Console.Write("Zero.");
                    break;
                case 1:
                    Console.Write("One.");
                    break;
                case 2:
                    Console.Write("Two.");
                    break;
                case 3:
                    Console.Write("Three.");
                    break;
                case 4:
                    Console.Write("Four.");
                    break;
                case 5:
                    Console.Write("Five.");
                    break;
                case 6:
                    Console.Write("Six.");
                    break;
                case 7:
                    Console.Write("Seven.");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine.");
                    break;

                default:
                    if (digit < 0 && digit > 9)
                    {
                        Console.WriteLine("Please, enter a number within range of 0 - 9.");
                    }
                    break;
            }
            Console.WriteLine();
        }
    }
}