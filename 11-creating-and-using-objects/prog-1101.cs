/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write a program, which reads from the console a year
|     and checks if it is a leap year.
|
| Solutions and Guidelines:
|
|     Use DateTime.IsLeapYear(year)
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
            Console.Write("Please, write which year you want to check: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("\nThe given year ({0}) is a leap year.", year);
            }
            else
            {
                Console.WriteLine("\nThe given year ({0}) is not a leap year.", year);
            }
        }
    }
}