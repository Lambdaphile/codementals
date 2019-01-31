/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program that gets the coefficients a, b and c
|     of a quadratic equation: pow(a*x, 2) + b*x + c,
|     calculates and prints its real roots (if they exist).
|     Quadratic equations may have 0, 1 or 2 real roots.
|
| Solutions and Guidelines:
|
|     From math it is known, that a quadratic equation may
|     have one or two real roots or no real roots at all.
|     In order to calculate the real roots of a given quadratic
|     equation, we first calculate the discriminant (D) by
|     the formula:
|
|        * D = pow(b, 2) - 4 * a * c.
|
|     If the discriminant is zero, then the quadratic
|     equation has one double real root and it is calculated
|     by the formula:
|
|       * x1, 2 = - b / 2 * a.
|
|     If the value of the discriminant is positive, then
|     the equation has two distinct real roots, which are
|     calculated by the formula:
|
|       * x1,2 = - b (+,-) sqrt(pow(b, 2) - 4 * a * c / 2 * a.
|
|     If the discriminant is negative, the quadratic equation
|     has no real roots.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the coefficients a, b and c of a quadratic equation:");
            Console.Write("\na = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) + 4 * a * c;
            if (D == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("x1,2 = {0}", x);
            }
            else if (D > 0)
            {
                double x1 = -b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c / -2 * a);
                double x2 = -b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c / -2 * a);
                Console.WriteLine("\nx1 = {0}\nx2 = {1}", x1, x2);
            } else if (D < 0)
            {
                Console.WriteLine("Quadratic equation has no real roots.");
            }
        }
    }
}