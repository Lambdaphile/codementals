/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     You are given a sequence of positive integer numbers
|     given as string of numbers separated by a space.
|     Write a program, which calculates their sum.
|
|       * Example: "43 68 9 23 318" -> 461.
|
| Solutions and Guidelines:
|
|     Use String.Split(' ') to split the string by spaces.
|     Then use Int32.Parse(...) to extract the separate numbers
|     from the obtained string array as int values and sum them.
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
        public static void Main(string[] args)
        {
            Console.WriteLine("\nPlease, enter sequence of numbers seperated by space (i.g 21 32 43 45...)");
            Console.WriteLine("-------------------------------------------------------------------------\n");
            Console.Write("Enter there: ");
            string sequence = Console.ReadLine();

            string[] splitSequence = sequence.Split(' ');
            int sequenceSum = 0;
            foreach (var integer in splitSequence)
            {
                sequenceSum += int.Parse(integer);
            }

            Console.WriteLine("\nSum of the given sequence: " + sequenceSum);
        }
    }
}
