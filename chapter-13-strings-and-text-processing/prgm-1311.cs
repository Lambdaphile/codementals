/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Write a program that reads a number from console
|     and prints it in 15-character field, aligned right
|     in several ways: as a decimal number, hexadecimal number,
|     percentage, currency and exponential (scientific) notation.
|
| Solutions and Guidelines:
|
|     Use appropriate formatting strings.
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
            Console.Write("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0, 15}", n);
            Console.WriteLine("{0, 15:X}", n);
            Console.WriteLine("{0, 15:P2}", n);
            Console.WriteLine("{0, 15:C}", n);
            Console.WriteLine("{0, 15:0.###E+00}", n);
        }
    }
}