/*
|--------------------------------------------------------------------------
| Chapter 12. Exception Handling
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write a program that takes a positive integer from the console
|     and prints the square root of this integer.
|     If the input is negative or invalid print "Invalid Number"
|     in the console. In all cases print "Good Bye".
|
| Solutions and Guidelines:
|
|     Create try-catch-finally statement.
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
            uint integer = 0;
            try
            {
                Console.Write("\nPlease, enter an  positive integer: ");
                integer = uint.Parse(Console.ReadLine());
                double sqrtOfInteger = Math.Sqrt(integer);
                Console.WriteLine("\nSquare root of the given number {0} is {1}", integer, sqrtOfInteger);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input! Please, try to enter an integer.");
            }
            catch (SystemException)
            {
                Console.WriteLine("\nInvalid input! Please, try to enter an positive integer.");
            }
            finally
            {
                Console.WriteLine("\nGood Bye!");
            }
        }
    }
}