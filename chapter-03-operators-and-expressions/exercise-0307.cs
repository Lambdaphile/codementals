/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     The gravitational field of the Moon is approximately 17%
|     of that on the Earth. Write a program that calculates
|     the weight of a man on the moon by a given weight on the Earth.
|
| Solutions and Guidelines:
|
|     Use the following code to read the number from the console:
|
|       * Console.Write("Enter number: ");
|         int number = Convert.ToInt32(Console.ReadLine());
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
            Console.Write("Enter your body weight in kg's: ");
            int earthWeight = Convert.ToInt32(Console.ReadLine());

            double moonWeight = earthWeight * 0.17;

            Console.WriteLine("Your weight on moon is {0} kg's.", moonWeight);
        }
    }
}