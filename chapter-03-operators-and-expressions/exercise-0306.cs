/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program that prints on the console the perimeter
|     and the area of a rectangle by given side and height
|     entered by the user.
|
| Solutions and Guidelines:
|
|     Search the Internet for how to read integers from the console
|     and use the formula for rectangle area calculation.
|     If you have difficulties see instructions on the next problem.
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
            Console.WriteLine("Enter the length and width of your rectangle.\n");
            Console.Write("Length = ");
            int rectangleLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width = ");
            int rectangleWidth = Convert.ToInt32(Console.ReadLine());

            int A = rectangleWidth * rectangleLength;
            int P = 2 * (rectangleLength + rectangleWidth);

            Console.WriteLine("\nArea = {0}", A);
            Console.WriteLine("Perimeter = {0}", P);
        }
    }
}