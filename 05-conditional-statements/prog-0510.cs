/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     Write a program that applies bonus points to given scores
|     in the range [1…9] by the following rules:
|
|       - If the score is between 1 and 3, the program
|         multiplies it by 10.
|       - If the score is between 4 and 6, the program
|         multiplies it by 100.
|       - If the score is between 7 and 9, the program
|         multiplies it by 1000.
|       - If the score is 0 or more than 9, the program
|         prints an error message.
|
| Solutions and Guidelines:
|
|     Use switch statement or a sequence of if-else constructs
|     and at the end print at the console the calculated points.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the score in the range [0-9]:\n");
            Console.Write("Score: ");
            int score = Int32.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3)
            {
                score *= 10;
                Console.WriteLine("\nScore: {0}", score);
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
                Console.WriteLine("\nScore: {0}", score);
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
                Console.WriteLine("\nScore: {0}", score);
            }
            else if (score == 0 || score > 9)
            {
                Console.WriteLine("\nNot a valid score. Please try again.");
            }
        }
    }
}