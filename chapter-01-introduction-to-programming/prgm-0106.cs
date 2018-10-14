/*
|--------------------------------------------------------------------------
| Chapter 1. Introduction to Programming
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program that prints the square root of 12345.
|
| Solutions and Guidelines:
|
|     Find out what features are offered by the System.Math class.
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
            Console.WriteLine("Square root of 12345: {0}", Math.Sqrt(12345));
        }
    }
}