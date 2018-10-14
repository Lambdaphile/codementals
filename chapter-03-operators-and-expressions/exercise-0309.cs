/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     Write an expression that checks for given point {x, y}
|     if it is within the circle K({0, 0}, R=5)
|     and out of the rectangle [{-1, 1}, {5, 5}].
|     Clarification: for the rectangle the lower left
|     and the upper right corners are given.
|
| Solutions and Guidelines:
|
|     Use the code from the previous task and add a check
|     for the rectangle. A point is inside a rectangle with walls
|     parallel to the axes, when in the same time it is right
|     of the left wall, left of the right wall, down from the top
|     wall and above the bottom wall.
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
            int circleR = 5,
                rectangleLowerLeftX = -1, rectangleLowerLeftY = 1,
                rectangleUpperRightX = 5, rectangleUpperRightY = 5;

            Console.WriteLine("Please, enter the point's {x, y}:\n");
            Console.Write("x = ");
            int pointX = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int pointY = int.Parse(Console.ReadLine());

            Console.WriteLine((pointX * pointX) + (pointY * pointY) <= circleR * circleR ?
                "The point is inside the circle." : "The point is not inside the circle.");

            Console.WriteLine(pointX > rectangleLowerLeftX && pointX < rectangleUpperRightX &&
                pointY < rectangleUpperRightY && pointY > rectangleLowerLeftY ?
                "The point is inside the rectangle" : "The point is not inside the rectangle");
        }
    }
}