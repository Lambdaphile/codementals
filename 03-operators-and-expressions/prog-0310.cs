/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     Write a program that takes as input a four-digit number in format
|     abcd (e.g. 2011) and performs the following actions:
|
|       - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
|
|       - Prints on the console the number in reversed order: dcba
|         (in our example 1102).
|
|       - Puts the last digit in the first position:
|         dabc (in our example 1201).
|
|       - Exchanges the second and the third digits:
|         acbd (in our example 2101).
|
| Solutions and Guidelines:
|
|     To get the individual digits of the number you can divide
|     by 10 and take the remainder of the division by 10:
|
|       * int a = num % 10;
|         int b = (num / 10) % 10;
|         int c = (num / 100) % 10;
|         int d = (num / 1000) % 10;
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int fourDigitNumber;
            Console.WriteLine("Enter a four-digit number:");
            do
            {
                Console.Write("\nNumber: ");
                fourDigitNumber = Convert.ToInt32(Console.ReadLine());
            } while (fourDigitNumber <= 999);


            // Getting the digits of number
            int a = fourDigitNumber % 10; // fourth digit
            int b = (fourDigitNumber / 10) % 10;
            int c = (fourDigitNumber / 100) % 10;
            int d = (fourDigitNumber / 1000) % 10; // first digit

            int sumOfDigits = a + b + c + d;
            Console.WriteLine("\nSum of the digits: {0}", sumOfDigits);

            // Reversing the number
            int reversedNumber = a;
            reversedNumber *= 10;
            reversedNumber += b;
            reversedNumber *= 10;
            reversedNumber += c;
            reversedNumber *= 10;
            reversedNumber += d;
            Console.WriteLine("\nReversed number: {0}", reversedNumber);

            // Moving the last digit in first position
            int lastDigitFirst = a;
            lastDigitFirst *= 10;
            lastDigitFirst += d;
            lastDigitFirst *= 10;
            lastDigitFirst += c;
            lastDigitFirst *= 10;
            lastDigitFirst += b;
            Console.WriteLine("\nLast digit moved on first position: {0}",
            lastDigitFirst);

            // Exchanging the second and third digit
            int exchangedMiddle = d;
            exchangedMiddle *= 10;
            exchangedMiddle += b;
            exchangedMiddle *= 10;
            exchangedMiddle += c;
            exchangedMiddle *= 10;
            exchangedMiddle += a;
            Console.WriteLine("\nExchanged second and third digit: {0}",
            exchangedMiddle);
        }
    }
}