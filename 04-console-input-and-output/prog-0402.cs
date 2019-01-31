/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Write a program that reads from the console the radius "r"
|     of a circle and prints its perimeter and area.
|
| Solutions and Guidelines:
|
|     Use Math.PI constant and the well-known geometric formulas.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle:");
            Console.Write("\nr = ");
            int r = Int32.Parse(Console.ReadLine());

            double P = 2 * Math.PI * r;
            Console.WriteLine("\nPerimeter of the circle: {0}", P);
            double A = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Area of the circle: {0}", A);
        }
    }
}