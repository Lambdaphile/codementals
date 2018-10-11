/*
|--------------------------------------------------------------------------
| Chapter 1. Introduction to Programming
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write a program that prints on the console the current
|     date and time.
|
| Solutions and Guidelines:
|
|     Find out what features are offered by the System.DateTime class.
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
            Console.WriteLine("Current date and time: {0}", DateTime.Now);
        }
    }
}