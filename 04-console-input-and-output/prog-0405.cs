/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write a program that reads from the console two integer
|     numbers (int) and prints how many numbers between them exist,
|     such that the remainder of their division by 5 is 0.
|
|       * Example: in the range (14, 25) there are 3 such numbers:
|         15, 20 and 25.
|
| Solutions and Guidelines:
|
|     There are two approaches for solving the problem:
|
|     First approach: Use mathematical tricks for optimized
|     calculation based on the fact that every fifth number
|     is divisible by 5. Think how to implement this correctly
|     and about the borderline cases.
|
|     The second approach is easier but it works slower.
|     With a for-loop each number within the given range
|     can be checked. You should read in Internet
|     or in the chapter "Loops" how to use for-loops.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers (a < b):");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nb = ");
            int b = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = a; i < b; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("There are {0} number between {1} and {2} that n % 5 != 1.", counter, a, b);
        }
    }
}