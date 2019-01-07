/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Write a method that finds how many times certain number
|     can be found in a given array. Write a program to test
|     that the method works correctly.
|
| Solutions and Guidelines:
|
|     The method must take as parameter an array of integer numbers
|     (int[]) and the number that has to be counted (int).
|     Test it with few examples like this:
|
|       * CountOccurrences(new int[]{3,2,2,5,1,-8,7,2}, 2) -> 3.
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
        public static int[] InitializeArray()
        {
            int arrayLength;
            bool isParsingSuccessful;

            do
            {
                Console.Write("Please, enter the length of the array: ");
                string container = Console.ReadLine();

                isParsingSuccessful = int.TryParse(container, out arrayLength);

                if (!isParsingSuccessful)
                {
                    Console.WriteLine("\nInvalid input. Please, try again.");
                }
            } while (!isParsingSuccessful);

            int[] array = new int[arrayLength];

            Console.WriteLine("\nPlease, fill the indexes with integers.");
            for (int i = 0; i < arrayLength; i++)
            {
                do
                {
                    Console.Write("index[{0}] = ", i);
                    string container = Console.ReadLine();

                    isParsingSuccessful = int.TryParse(container, out array[i]);

                    if (!isParsingSuccessful)
                    {
                        Console.WriteLine("\nInvalid input. Please, try again.\n");
                    }
                } while (!isParsingSuccessful);
            }

            return array;
        }

        public static int CountOccurrences(int[] array, int searchedNumber)
        {
            int occurrenceCounter = 0;
            foreach (var number in array)
            {
                if (number == searchedNumber)
                {
                    occurrenceCounter++;
                }
            }

            return occurrenceCounter;
        }

        static void Main(string[] args)
        {
            int[] array = InitializeArray();

            Console.Write("\nPlease, enter the number to be searched: ");
            int searchedNumber = int.Parse(Console.ReadLine());

            int occurrenceCounter = CountOccurrences(array, searchedNumber);

            Console.Write("\nNumber ({0}) occurs ({1}) times - inside the given array.\n", searchedNumber, occurrenceCounter);

            // Unit test...
            if (CountOccurrences(new int[] { 3, 2, 2, 5, 1, -8, 7, 2 }, 2) != 3)
                throw new Exception("Number 2 in array{ 3, 2, 2, 5, 1, -8, 7, 2 } occurs != 3.");
        }
    }
}