/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     Write a program that calculates and prints the n!
|     for any n in the range [1...100].
|
| Solutions and Guidelines:
|
|     The reader must implement own method that calculates
|     the product of very big numbers, because the value of 100!
|     does not fit in variable of type ulong or decimal.
|     The numbers can be represented in an array of reversed digits
|     (one digit in each element).
|
|       * For example, the number 512 can be represented as {2, 1, 5}.
|         Then the multiplication can be implemented in the way done
|         in the elementary school (multiply digit by digit
|         and then calculate the sum).
|
|     Another easier way to work with extremely large numbers such
|     as 100! is by using the library System.Numerics.dll (you have
|     to add a reference to it in your project).
|     Look for Information in Internet about how to use the class
|     System.Numerics.BigInteger.
|
|     Finally calculate in a loop k! for k = 1, 2, ..., n
|
*/

using System;

namespace Program
{
    class Program
    {
        public static int GetInteger(string displayText)
        {
            bool isParsingSuccessful;
            int integerInput;

            do
            {
                Console.Write(displayText);
                string temp = Console.ReadLine();

                isParsingSuccessful = int.TryParse(temp, out integerInput);

                if (!isParsingSuccessful)
                    Console.WriteLine("\nInvalid input! Please, try again.");
            } while (!isParsingSuccessful);

            return integerInput;
        }

        static void Main(string[] args)
        {
            int factorial = GetInteger("\nPlease, enter a factorial in range [1...100]: ");

            BigInteger result = 1;

            for (int i = factorial; i > 1; i--)
            {
                result *= i;
            }

            Console.WriteLine("\nFactorial {0}! = {1}.", factorial, result);
        }
    }
}