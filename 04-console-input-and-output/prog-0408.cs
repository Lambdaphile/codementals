/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Write a program that reads five numbers from the console
|     and prints the greatest of them.
|
| Solutions and Guidelines:
|
|     You can use the comparison statement "if" (you can read about
|     it on the Internet or from the chapter "Conditional Statements").
|     To avoid repeating code you can use the looping construct "for"
|     (you could read about it online or in the chapter "Loops").
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int greatest = 0;
            Console.WriteLine("Please, enter five numbers:\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                greatest = (number > greatest) ? number : greatest;
            }

            Console.WriteLine("Greatest of the entered numbers: {0}", greatest);
        }
    }
}