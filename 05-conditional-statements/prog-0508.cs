/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Write a program that, depending on the user’s choice, inputs int,
|     double or string variable. If the variable is int or double,
|     the program increases it by 1. If the variable is a string,
|     the program appends "*" at the end. Print the result at the console.
|     Use switch statement.
|
| Solutions and Guidelines:
|
|     First input a variable, which indicates what type will
|     be the input, i.e. by entering 0 the type is int,
|     by 1 is double and by 2 is string.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, choose what type of data you want to enter:");
            Console.Write("\nEnter 0 for int, 1 for double and 2 for string: ");
            int choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 0:
                    Console.Write("int var = ");
                    int intVar = Int32.Parse(Console.ReadLine());
                    intVar++; Console.WriteLine("int variable: {0}", intVar);
                    break;
                case 1:
                    Console.Write("double var = ");
                    double doubleVar = double.Parse(Console.ReadLine());
                    doubleVar++; Console.WriteLine("double variable: {0}", doubleVar);
                    break;
                case 2:
                    Console.Write("string var = ");
                    string stringVar = Console.ReadLine();
                    stringVar += "*"; Console.WriteLine("String variable: {0}", stringVar);
                    break;
                default:
                    Console.WriteLine("Invalid input! Please, try again.");
                    break;
            }
        }
    }
}