/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Write a method that calculates the sum of two very long positive
|     integer numbers. The numbers are represented as array digits
|     and the last digit (the ones) is stored in the array at index 0.
|     Make the method work for all numbers with length
|     up to 10,000 digits.
|
| Solutions and Guidelines:
|
|     The reader must implement own method that calculates the sum
|     of very big numbers. The digits on position zero will keep
|     the ones; the digit on the first position will keep the tenths
|     and so on. When two very big numbers are about to be calculated,
|     the ones of their sum will be equal to (firstNumber[0] +
|     secondNumber[0]) % 10, the tenths on other side will be equal
|     to (firstNumber[1] + secondNumber[1]) % 10 + (firstNumber[0] +
|     secondNumber[0])/10 and so on.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static int[] SumBigIntegers(int[] bigInteger1, int[] bigInteger2)
        {
            int[] sumOfBigIntegers = new int[Math.Max(bigInteger1.Length, bigInteger2.Length)];

            sumOfBigIntegers[0] = (bigInteger1[0] + bigInteger2[0]) % 10;
            for (int i = 1; i < sumOfBigIntegers.Length; i++)
            {
                if (i <= Math.Min(bigInteger1.Length, bigInteger2.Length) - 1)
                {
                    if ((bigInteger1[i] + bigInteger2[i]) % 10 + (bigInteger1[i - 1] + bigInteger2[i - 1]) / 10 == 10)
                    {
                        sumOfBigIntegers[i] = 0;
                        if (bigInteger1.Length > bigInteger2.Length)
                            bigInteger1[i + 1]++;
                        else
                            bigInteger2[i + 1]++;
                    }
                    else
                        sumOfBigIntegers[i] = (bigInteger1[i] + bigInteger2[i]) % 10 +
                            (bigInteger1[i - 1] + bigInteger2[i - 1]) / 10;
                }
                else
                {
                    if (i == Math.Min(bigInteger1.Length, bigInteger2.Length))
                    {
                        if (bigInteger1.Length > bigInteger2.Length)
                        {
                            sumOfBigIntegers[i] = bigInteger1[i] + (bigInteger1[i - 1] + bigInteger2[i - 1]) / 10;
                        }
                        else
                            sumOfBigIntegers[i] = bigInteger2[i] + (bigInteger1[i - 1] + bigInteger2[i - 1]) / 10;
                    }
                    else
                    {
                        if (bigInteger1.Length > bigInteger2.Length)
                            sumOfBigIntegers[i] = bigInteger1[i];
                        else
                            sumOfBigIntegers[i] = bigInteger2[i];
                    }
                }
            }
            return sumOfBigIntegers;
        }

        public static int[] GetBigInteger(int digitsLength)
        {
            int[] bigInteger = new int[digitsLength];

            Console.WriteLine();
            for (int i = digitsLength - 1; i >= 0; i--)
                bigInteger[i] = GetInteger("Digit({0}):", digitsLength - i);

            return bigInteger;
        }

        public static int GetInteger(string displayText, int? i)
        {
            bool isParsingSuccessful;
            int integerInput;

            do
            {
                Console.Write(displayText, i);
                string temp = Console.ReadLine();

                isParsingSuccessful = int.TryParse(temp, out integerInput);

                if (!isParsingSuccessful)
                    Console.WriteLine("\nInvalid input! Please, try again.");
            } while (!isParsingSuccessful);

            return integerInput;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nThis, program sums two exceptionally long positive integers (up to 10,000 digits)");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // Getting first big integer
            int digitsLength = GetInteger("\n\nHow many digits long the first integer gonna be: ", null);
            int[] bigInteger1 = GetBigInteger(digitsLength);

            // Getting second big integer
            digitsLength = GetInteger("\n\nHow many digits long the second integer gonna be: ", null);
            int[] bigInteger2 = GetBigInteger(digitsLength);

            // Getting the sum of given two big integers
            int[] sumOfBigIntegers = SumBigIntegers(bigInteger1, bigInteger2);

            // Printing the sum
            for (int i = sumOfBigIntegers.Length - 1; i >= 0; i--)
            {
                Console.Write(sumOfBigIntegers[i]);
            }
        }
    }
}