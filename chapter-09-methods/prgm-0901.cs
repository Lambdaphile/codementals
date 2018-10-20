/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write a method that by given name prints on the console
|     "Hello, <name>!" (for example: "Hello, Peter!").
|
| Solutions and Guidelines:
|
|     Use a method that takes the name as parameter of type string.
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
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main(string[] args)
        {
            Console.Write("Please, enter a name: ");
            string name = Console.ReadLine();

            PrintName(name);
        }
    }
}