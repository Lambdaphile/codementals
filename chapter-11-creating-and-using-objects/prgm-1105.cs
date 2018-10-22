/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write a program which by given two sides finds the hypotenuse
|     of a right triangle. Implement entering of the lengths of the sides
|     from the standard input, and for the calculation of the hypotenuse
|     use methods of the class Math.
|
| Solutions and Guidelines:
|
|     The hypotenuse of a rectangular triangle could be found with
|     the Pythagorean Theorem a2 + b2 = c2, where a and b are the
|     two sides, and c is the hypotenuse.
|
|     Take square root of the two sides of the equation in order
|     to get the length of the hypotenuse. Use the Sqrt(...)
|     methods of the Math class.
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
        static int GetInteger(string displayText)
        {
            bool isInteger;
            int integerInput;
            string temp;

            do
            {
                Console.Write(displayText);
                temp = Console.ReadLine();

                isInteger = int.TryParse(temp, out integerInput);

                if (!isInteger)
                    Console.WriteLine("\nInvalid input! Please, try again.");
            } while (!isInteger);

            return integerInput;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("\nPlease enter two sides (a, b) of a right triangle:\n");
            int a = GetInteger("a = ");
            int b = GetInteger("b = ");

            double c = Math.Pow(a, 2) + Math.Pow(b, 2);

            Console.WriteLine("\nHypotenuse of the given right triangle: {0}", c);
        }
    }
}