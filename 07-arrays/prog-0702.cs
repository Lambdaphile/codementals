/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Write a program, which reads two arrays from the console
|     and checks whether they are equal (two arrays are equal when
|     they are of equal length and all of their elements, which
|     have the same index, are equal).
|
| Solutions and Guidelines:
|
|     Use an int[] array and a for-loop. Two arrays are equal if
|     they have the same value for the length and the values for their
|     elements. You can check for the second condition using a for-loop.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength;
            bool isParsingSuccessful;

            do
            {
                Console.Write("Please, enter first array's length: ");
                string container = Console.ReadLine();

                isParsingSuccessful = int.TryParse(container, out arrayLength);

                if (!isParsingSuccessful)
                {
                    Console.WriteLine("\nInvalid input. Please, try again.\n");
                }
            } while (!isParsingSuccessful);

            Console.WriteLine("Please, enter it's content.");
            int[] arrayA = new int[arrayLength];

            for (int i = 0; i < arrayA.Length; i++)
            {
                do
                {
                    Console.Write("Index[{0}] = ", i);
                    string container = Console.ReadLine();

                    isParsingSuccessful = int.TryParse(container, out arrayA[i]);

                    if (!isParsingSuccessful)
                    {
                        Console.WriteLine("\nInvalid input. Please, try again\n");
                    }

                } while (!isParsingSuccessful);
            }

            do
            {
                Console.Write("\nPlease, enter second array's length: ");
                string container = Console.ReadLine();

                isParsingSuccessful = int.TryParse(container, out arrayLength);

                if (!isParsingSuccessful)
                {
                    Console.WriteLine("\nInvalid input. Please, try again.\n");
                }
            } while (!isParsingSuccessful);

            Console.WriteLine("Please, enter it's content.");
            int[] arrayB = new int[arrayLength];

            for (int i = 0; i < arrayB.Length; i++)
            {
                do
                {
                    Console.Write("Index[{0}] = ", i);
                    string container = Console.ReadLine();

                    isParsingSuccessful = int.TryParse(container, out arrayB[i]);

                    if (!isParsingSuccessful)
                    {
                        Console.WriteLine("\nInvalid input. Please, try again\n");
                    }

                } while (!isParsingSuccessful);
            }

            if (arrayA.Length != arrayB.Length)
            {
                Console.WriteLine("\nArrays are not equal.");
            }
            else // They are equal and we start searching for unequal elements.
            {
                for (int i = 0; i < arrayA.Length; i++)
                {
                    if (arrayA[i] != arrayB[i])
                    {
                        Console.WriteLine("\nArrays are not equal.");
                        break; // To eliminate unnecessary cycling.
                    }
                    else if (i == arrayA.Length - 1)
                    {
                        Console.WriteLine("\nArrays are equal.");
                    }
                }
            }
        }
    }
}