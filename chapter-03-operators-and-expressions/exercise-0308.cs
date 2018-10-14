/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Write an expression that checks for a given point {x, y}
|     if it is within the circle K({0, 0}, R=5).
|     Explanation: the point {0, 0} is the center of the circle
|     and 5 is the radius.
|
| Solutions and Guidelines:
|
|     Use the Pythagorean Theorem a^2 + b^2 = c^2.
|     The point is inside the circle when (x*x) + (y*y) ≤ 5*5.
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
            int R = 5;

            Console.WriteLine("Please enter x and y coordinates of the point: ");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((x * x) + (y * y) <= R * R ?
                "The point is inside the circle" : "The point isn't inside the circle");
        }
    }
}