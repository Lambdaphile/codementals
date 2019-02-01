/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     Write a program that reads from the console a series
|     of integers and prints the smallest and largest of them.
|
| Solutions and Guidelines:
|
|     First read the count of numbers, for example in a
|     variable n. Then consequently enter n numbers with
|     one for loop. While entering each new number, save
|     in two variables the smallest and the largest number
|     until this moment. At the start initialize the smallest
|     and the largest number with Int32.MaxValue and
|     Int32.MinValue respectively.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter how many number you want to use:");
            Console.Write("\nN = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            int smallestNumber = Int32.MaxValue, largestNumber = Int32.MinValue;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} Number: ", i);
                int number = Int32.Parse(Console.ReadLine());
                if (number < smallestNumber)
                    smallestNumber = number;
                if (number > largestNumber)
                    largestNumber = number;
            }
            Console.WriteLine("\nLargest number: {0}", largestNumber);
            Console.WriteLine("Smallest number: {0}", smallestNumber);
        }
    }
}