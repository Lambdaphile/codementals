/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     The majorant of an array of size N is a value that occurs
|     in it at least N/2 + 1 times.
|     Write a program that finds the majorant of given array
|     and prints it. If it does not exist, print
|     "The majorant does not exist!".
|
|       * e.g. {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3
|
| Solutions and Guidelines:
|
|     Use list. Sort the list and you are going to get the equal
|     numbers next to one another. Scan the array by counting
|     the number of occurrences of each number.
|     If up to a certain moment a number has occurred N / 2 + 1
|     times, this is the majorant and there is no need
|     to check further. If after position N / 2 + 1 there is
|     a new number (a majorant is not found until this moment),
|     there is no need to search further – even in the case
|     when the list is filled with the current number
|     to the end, it will not occur N / 2 + 1 times.
|
*/

using System;
using System.Collections;

namespace Program
{
    public static class Program
    {
        public static int GetMajorant(ArrayList array)
        {
            array.Sort();
            int majorant = 0, occurrences = 1;
            for (int i = 0; i < array.Count - 1 && majorant == 0; i++)
            {
                if (array[i].Equals(array[i + 1]))
                {
                    occurrences++;
                    if (occurrences >= (array.Count / 2) + 1)
                        majorant = (int)array[i];
                }
                else occurrences = 1;
            }

            return majorant;
        }

        public static void Main(string[] args)
        {
            ArrayList array = new ArrayList { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int majorant = GetMajorant(array);
            Console.WriteLine(majorant != 0 ?
                $"Majorant: { majorant.ToString()}" : "Sorry, the majorant does not exist.");
        }
    }
}