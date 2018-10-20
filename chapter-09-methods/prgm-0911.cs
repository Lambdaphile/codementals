/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Write a program that solves the following tasks:
|
|       - Put the digits from an integer number into a reversed order.
|       - Calculate the average of given sequence of numbers.
|       - Solve the linear equation a * x + b = 0.
|
|     Create appropriate methods for each of the above tasks.
|     Make the program show a text menu to the user. By choosing
|     an option of that menu, the user will be able to choose
|     which task to be invoked.
|
|     Perform validation of the input data:
|
|       - The integer number must be a positive in the range
|            [1...50,000,000].
|       - The sequence of numbers cannot be empty.
|       - The coefficient a must be non-zero.
|
| Solutions and Guidelines:
|
|     Firstly, create the necessary methods. To create the menu
|     display a list in which the actions are represented
|     as numbers (1 – reverse, 2 – average, 3 – equation).
|     Ask the user to choose from 1 to 3.
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
        static int userChoice;
        static int integerInput;

        static void RunMenu()
        {
            Console.WriteLine("\nPlease, select an option from the menu below:");
            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine(" - 1 for reversing a given integer.");
            Console.WriteLine(" - 2 for calculating average of given integers.");
            Console.WriteLine(" - 3 for solution of (a * x + b = 0) equation.");

            do
            {
                userChoice = GetInteger("\n\nPlease, enter your choice there: ", null);

                if (userChoice < 1 || userChoice > 3)
                    Console.WriteLine("\nInvalid input! Please, try again.");
            } while (userChoice < 1 || userChoice > 3);
        }

        static void ReverseInteger()
        {
            do
            {
                integerInput = GetInteger("\nPlease, enter an integer in the range[1...50000000]: ", null);
                if (integerInput < 1 || integerInput > 50000000)
                    Console.WriteLine("\nInvalid input! Please, try again.\n");
            } while (integerInput < 1 || integerInput > 50000000);

            // We make a copy of the given integer, because we want
            // show it's content before being reversed.
            int integerInputCopy = integerInput;
            int reversedInteger = 0;

            do
            {
                int temp = integerInputCopy % 10;
                reversedInteger *= 10;
                reversedInteger += temp;
                integerInputCopy /= 10;

            } while (integerInputCopy != 0);

            Console.WriteLine("\nAfter reversing the integer ({0}) it becomes ({1}).",
                integerInput, reversedInteger);
        }

        static void CalculateAverage()
        {
            int sequenceLength = GetInteger("\nPlease, enter how many integers are gonna be used: ", null);

            int[] sequence = new int[sequenceLength];

            Console.WriteLine();
            for (int i = 0; i < sequenceLength; i++)
            {
                sequence[i] = GetInteger("integer({0}): ", i + 1);
            }

            int sequenceSum = 0;
            foreach (var integer in sequence)
                sequenceSum += integer;

            int average = sequenceSum / sequenceLength;

            Console.WriteLine("\nAverage of the given sequence is: {0}", average);
        }

        static void SolveLinearEquation()
        {
            Console.WriteLine("\nPlease, enter the coefficients of the equation (a * x + b = 0), 'a' should be non-zero.");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            double a;
            do
            {
                a = GetInteger("\na = ", null);
                if (a == 0)
                    Console.WriteLine("\nInvalid input! Please, try again.");
            } while (a == 0);
            double b = GetInteger("b = ", null);

            double x = (0 - b) / a;

            Console.WriteLine("\nFrom the given equation {0} * x + {1} = 0, x = {2}.", a, b, x);
        }

        // This method exists solely to reduce code repetition.
        // It takes displayText argument to display the needed text
        // from where it's called. And i argument if it's going to be used
        // for initialising array's or multiple elements.
        static int GetInteger(string displayText, int? i)
        {
            bool isInteger;
            string temp;

            do
            {
                Console.Write(displayText, i);
                temp = Console.ReadLine();

                isInteger = int.TryParse(temp, out integerInput);

                if (!isInteger)
                    Console.WriteLine("\nInvalid input! Please, try again.");
            } while (!isInteger);

            return integerInput;
        }

        // Check whether if the methods it's being called from
        // is wanted to be repeated and returns boolean answer.
        static bool RepeatOperation()
        {
            string choice;
            do
            {
                Console.Write("\n\nDo you want to repeat current operation? (Y/N): ");
                choice = Console.ReadLine();

                if (choice != "Y" && choice != "y" && choice != "N" && choice != "n")
                    Console.WriteLine("\nInvalid input! Please, try again!");
            } while (choice != "Y" && choice != "N" && choice != "y" && choice != "n");

            if (choice != "Y" && choice != "y")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            // Infinite loop for creating back and forth
            // possibility, starting from the menu to it's operations
            // and back.
            do
            {
                Console.Clear();
                RunMenu();

                switch (userChoice)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            ReverseInteger();
                        } while (!RepeatOperation());
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            CalculateAverage();
                        } while (!RepeatOperation());
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            SolveLinearEquation();
                        } while (!RepeatOperation());
                        break;
                }
            } while (true);
        }
    }
}