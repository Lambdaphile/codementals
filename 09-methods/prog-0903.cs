/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write a method that returns the English name of the last digit
|     of a given number.
|
|       * Example: for 512 prints "two"; for 1024 -> "four".
|
| Solutions and Guidelines:
|
|     Use the reminder of division by 10 and then a switch statement.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static int GetInteger()
        {
            bool isParsingSuccessful;
            int inputNumber;

            do
            {
                Console.Write("Please, enter a number: ");
                string container = Console.ReadLine();

                isParsingSuccessful = int.TryParse(container, out inputNumber);

                if (!isParsingSuccessful)
                {
                    Console.WriteLine("\nInvalid input. Please, try again.\n");
                }
            } while (!isParsingSuccessful);

            return inputNumber;
        }

        public static int GetLastDigit(int inputNumber)
        {
            int lastDigit = inputNumber % 10;

            return lastDigit;
        }

        public static void ConvertToEnglish(int lastDigit, int inputNumber)
        {
            // Printing continues inside switch statement.
            Console.Write("English name of the last digit from the given number ({0}) is ", inputNumber);

            switch (lastDigit)
            {
                case 0:
                    Console.Write("Zero.\n");
                    break;
                case 1:
                    Console.Write("One.\n");
                    break;
                case 2:
                    Console.Write("Two.\n");
                    break;
                case 3:
                    Console.Write("Three.\n");
                    break;
                case 4:
                    Console.Write("Four.\n");
                    break;
                case 5:
                    Console.Write("Five.\n");
                    break;
                case 6:
                    Console.Write("Six.\n");
                    break;
                case 7:
                    Console.Write("Seven.\n");
                    break;
                case 8:
                    Console.Write("Eight.\n");
                    break;
                case 9:
                    Console.Write("Nine.\n");
                    break;
            }
        }

        static void Main(string[] args)
        {
            int inputNumber = GetInteger();
            int lastDigit = GetLastDigit(inputNumber);
            ConvertToEnglish(lastDigit, inputNumber);
        }
    }
}