/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Write a program that checks whether the parentheses
|     are placed correctly in an arithmetic expression.
|
|       * Example of expression with correctly placed
|         brackets: ((a+b)/5-d).
|
|       * Example of an incorrect expression: )(a+b)).
|
| Solutions and Guidelines:
|
|     Use counting of the brackets: For an opening bracket increase
|     the counter by 1 and for closing bracket decrease it by 1.
|     Watch the counter not to become a negative number and always
|     ends with 0.
|
*/

using System;

namespace Program
{
    public class Program
    {
        public static bool ValidateExpression(string expression)
        {
            int bracketCounter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].Equals('('))
                    bracketCounter++;

                if (expression[i].Equals(')'))
                    bracketCounter--;
            }

            if (bracketCounter == 0)
                return true; // Expressions is correct
            else
                return false; // Expression is inocorrect
        }

        public static void Main(string[] args)
        {
            Console.Write("Please, enter an arithmetic expression: ");
            string expression = Console.ReadLine();

            if (ValidateExpression(expression))
                Console.WriteLine("Expression is correct.");
            else
                Console.WriteLine("Expression is incorrect.");
        }
    }
}