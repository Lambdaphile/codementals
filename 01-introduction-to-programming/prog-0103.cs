/*
|--------------------------------------------------------------------------
| Chapter 1. Introduction to Programming
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write a console application that prints your first
|     and last name on the console.
|
| Solutions and Guidelines:
|
|     Find out how to use the System.Console.Write() method.
|
*/

using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Хан Соло");
        }
    }
}