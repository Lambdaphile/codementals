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

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years: {0}", age + 10);
        }
    }
}