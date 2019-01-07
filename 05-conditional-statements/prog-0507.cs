/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Write a program that finds the greatest of given 5 numbers.
|
| Solutions and Guidelines:
|
|     Use nested if statements. You could use the loop structure
|     for, which you could read about in the “Loops”
|     chapter of the book or in Internet.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fiveNumberArray = new int[5];
            int greatestNumber = 0;

            Console.WriteLine("Please, enter 5 numbers:\n");
            for (int i = 0; i < fiveNumberArray.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                fiveNumberArray[i] = Int32.Parse(Console.ReadLine());
                if (fiveNumberArray[i] > greatestNumber)
                    greatestNumber = fiveNumberArray[i];
            }
            Console.WriteLine("\nGreatest number from 5 given numbers is: {0}", greatestNumber);
        }
    }
}