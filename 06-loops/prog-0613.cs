/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 13:
|
|     Write a program that converts a given number from binary
|     to decimal notation.
|
| Solutions and Guidelines:
|
|     See the previous problem.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a binary number: ");

            string binaryNumber = Console.ReadLine();

            char[] binaryNumberDigits = binaryNumber.ToCharArray();

            Array.Reverse(binaryNumberDigits);

            double decimalNumber = 0;
            for (int i = 0; i < binaryNumberDigits.Length; i++)
            {
                if (binaryNumberDigits[i] == '1')
                {
                    if (i == 0)
                    {
                        decimalNumber += 1;
                    }
                    else
                    {
                        decimalNumber += Math.Pow(2, i);
                    }
                }
            }

            Console.WriteLine("\nDecimal equivalent of the entered binary number {0} is: {1}",
                binaryNumber, decimalNumber);
        }
    }
}