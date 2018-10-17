/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Write a program that reads five integer numbers and prints
|     their sum. If an invalid number is entered the program
|     should prompt the user to enter another number.
|
| Solutions and Guidelines:
|
|     You can read the numbers in five different variables
|     and finally sum them and print the obtained sum.
|     Note that the sum of 5 int values may not fit
|     in the int type so you should use long.
|
|     Another approach is using loops. When parsing the consecutive
|     numbers use conditional parsing with TryParse(…).
|     When an invalid number is entered, repeat reading
|     of the number. You can do this through while loop with
|     an appropriate exit condition. To avoid repetitive code
|     you can explore the for-loops from the chapter "Loops".
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
            int number, counter = 0;
            long sum = 0;
            Console.WriteLine("Enter five numbers:\n");
            do
            {
                Console.Write("Number {0} = ", counter + 1);
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    sum += number;
                    counter++;
                }
                else
                {
                    Console.WriteLine("\nInvalid input, please try again.");
                }

            } while (counter < 5);
        }
    }
}