/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program which calculates the area of a triangle
|     with the following given:
|
|       - three sides;
|       - side and the altitude to it;
|       - two sides and the angle between them in degrees.
|
| Solutions and Guidelines:
|
|     For the first sub-problem of the task use the Heron’s Formula:
|
|       * S = Math.Sqrt(p * (p - a) * (p - b) * (p - c),
|         where p = a + b + c / 2.
|
|     For the second sub-problem use the formula:
|
|       * S = (a * h) / 2.
|
|     For the third sub-problem use the formula:
|
|       * S = ((a * b) * Math.Sin(y)) / 2).
|
|     For the sine use the System.Math class.
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

        static void RunMenu()
        {
            Console.WriteLine("\nPlease, choice how the area of triangle should be calculated:");
            Console.WriteLine("---------------------------------------------------------------\n");
            Console.WriteLine(" - 1 for calculating with given three sides");
            Console.WriteLine(" - 2 for calculating with given side and altitude to it");
            Console.WriteLine(" - 3 for calculating with given two sides and angle between them");

            userChoice = GetInteger("\n\nPlease, enter your choice there: ");
        }

        static void CalculateTriangleArea()
        {
            Console.WriteLine("\nPlease, enter sides of the triangle:");
            Console.WriteLine("--------------------------------------\n");
            int a = GetInteger("a = ");
            int b = GetInteger("b = ");
            int c = GetInteger("c = ");

            double p = (a + b + c) / 2;

            Console.WriteLine("\nArea of the triangle is: {0}",
                Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        static void CalculateTriangleArea2()
        {
            Console.WriteLine("\nPlease, enter a side and altitude to it:");
            Console.WriteLine("----------------------------------------\n");
            int a = GetInteger("Side = ");
            int h = GetInteger("h = ");

            Console.WriteLine("\nArea of the triangle is: {0}", (a * h) / 2);

        }

        static void CalculateTriangleArea3()
        {
            Console.WriteLine("\nPlease, enter two sides and the angle between them in degrees:");
            Console.WriteLine("--------------------------------------------------------------\n");
            int a = GetInteger("First side: ");
            int b = GetInteger("Second side: ");
            double angle = GetInteger("Angle: ");

            Console.WriteLine("\nArea of the triangle is: {0}", a * b * Math.Sin(angle * (Math.PI / 180)) / 2);
        }

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

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                RunMenu();

                switch (userChoice)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            CalculateTriangleArea();
                        } while (!RepeatOperation());
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            CalculateTriangleArea2();
                        } while (!RepeatOperation());
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            CalculateTriangleArea3();
                        } while (!RepeatOperation());
                        break;
                    default:
                        Console.WriteLine("\nInvalid input! Please, try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}