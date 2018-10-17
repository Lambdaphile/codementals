/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Write a program that shows the sign (+ or -) of the product
|     of three real numbers, without calculating it.
|     Use a sequence of if operators.
|
| Solutions and Guidelines:
|
|     A multiple of non-zero numbers has a positive product,
|     if the negative multiples are even number. If the count
|     of the negative numbers is odd, the product is negative.
|     If at least one of the numbers is zero, the product
|     is also zero.
|
|     Use a counter negativeNumbersCount to keep
|     the number of negative numbers. Check each number whether
|     it is negative and change the counter accordingly.
|     If some of the numbers is 0, print “0” as result
|     (the zero has no sign). Otherwise print “+” or “-”
|     depending on the condition (negativeNumbersCount % 2 == 0).
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
            int negativeNumbersCount = 0;

            Console.WriteLine("Please, enter three real numbers:");
            Console.Write("\nFirst number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            if (firstNumber < 0) negativeNumbersCount++;

            Console.Write("\nSecond number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            if (secondNumber < 0) negativeNumbersCount++;

            Console.Write("\nThird number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if (thirdNumber < 0) negativeNumbersCount++;

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("Product of the entered real number is 0.");
            }
            else if (negativeNumbersCount % 2 == 0)
            {
                Console.WriteLine("Product of the entered real numbers is \"+\".");
            }
            else
            {
                Console.WriteLine("Product of the entered real numbers is \"-\".");
            }
        }
    }
}