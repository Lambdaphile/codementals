/*
|--------------------------------------------------------------------------
| Chapter 1. Introduction to Programming
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Write a program that reads your age from the console
|     and prints your age after 10 years.
|
| Solutions and Guidelines:
|
|     Use the methods System.Console.ReadLine(), int.Parse()
|     and System.DateTime.AddYears().
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
            Console.Write("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            age += 10;

            Console.WriteLine("Your age after 10 years: {0}", age);
        }
    }
}