/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Create a method GetMax() with two integer (int) parameters,
|     that returns maximal of the two numbers.
|     Write a program that reads three numbers from the console
|     and prints the biggest of them. Use the GetMax() method
|     you just created. Write a test program that validates
|     that the methods works correctly.
|
| Solutions and Guidelines:
|
|     Use the expression Max(a, b, c) = Max(Max(a, b), c).
|     To test the code check whether the results from the invoked
|     methods is correct for a set of examples that cover the most
|     interesting cases, e.g.
|
|       * Max(1,2)=2; Max(3,-1)=3; Max(-1,-1)=-1;
|         Max(1,2,444444)=444444; Max(5,2,1)=5;
|         Max(-1,6,5)=6; Max(0,0,0)=0; Max(-10,-10,-10)=-10;
|         Max(2000000000,-2000000001,2000000002)=2000000002; etc.
|
|     You may write a generic method that works not just for int
|     but for any other type T using the following declaration:
|
|       * static T Max<T>(T a, T b) where T : IComparable<T> { ... }
|
|     Read more about the concept of generic methods in the section
|     "Generic Methods" of chapter "Defining Classes".
|
|     Instead of creating a program that checks whether the method
|     works correctly, you can search in Internet for information
|     about "unit testing" and write unit tests for your methods.
|     You may also read about unit testing in the section
|     "Unit Testing” of chapter "High-Quality Code".
|
*/

using System;

namespace Program
{
    class Program
    {
        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static int GetInteger(int i)
        {
            bool isParsingSuccessful;
            int inputNumber;

            do
            {
                Console.Write("Number ({0}) = ", i + 1);
                string container = Console.ReadLine();

                isParsingSuccessful = int.TryParse(container, out inputNumber);

                if (!isParsingSuccessful)
                {
                    Console.WriteLine("\nInvalid input. Please, try again.\n");
                }

            } while (!isParsingSuccessful);

            return inputNumber;
        }

        public static void PrintMax(int max)
        {
            Console.WriteLine("\nBiggest of the three numbers is: {0}", max);
        }

        static void Main(string[] args)
        {
            int[] maxArray = new int[3];
            Console.WriteLine("Please, enter three numbers:\n");
            for (int i = 0; i < 3; i++)
            {
                maxArray[i] = GetInteger(i);
            }

            int max = GetMax(GetMax(maxArray[0], maxArray[1]), maxArray[2]);

            PrintMax(max);

            // Unit tests...
            if (GetMax(1, 2) != 2)
                throw new Exception("!2 > 1.");
            if (GetMax(3, -1) != 3)
                throw new Exception("!3 > -1.");
            if (GetMax(-1, -1) != -1)
                throw new Exception("!-1 == -1.");
            if (GetMax(GetMax(1, 2), 444444) != 444444)
                throw new Exception("!444444 > 1 && 2.");
            if (GetMax(GetMax(5, 2), 1) != 5)
                throw new Exception("!5 > 2 && 1.");
            if (GetMax(GetMax(-1, 6), 5) != 6)
                throw new Exception("!6 > 5 && -1.");
            if (GetMax(GetMax(0, 0), 0) != 0)
                throw new Exception("0 != 0");
            if (GetMax(GetMax(-10, -10), -10) != -10)
                throw new Exception("-10 != -10");
            if (GetMax(GetMax(2000000000, -2000000001), 2000000002) != 2000000002)
                throw new Exception("!2000000002 > 2000000000 && -2000000001");
        }
    }
}