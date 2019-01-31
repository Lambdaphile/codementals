/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Sort 3 real numbers in descending order. Use nested
|     if statements.
|
| Solutions and Guidelines:
|
|     First find the smallest of the three numbers, and then
|     swap it with the first one. Then check if the second is
|     greater than the third number and if yes, swap them too.
|
|     Another approach is to check all possible orders
|     of the numbers with a series of if-else checks:
|
|       * a <= b <= c, a <= c <= b, b <= a <= c, b <= c <= a,
|         c <= a <= b and c <= b <= a.
|
|     A more complicated and more general solution of this problem
|     is to put the numbers in an array and use the Array.Sort(...)
|     method. You may read about arrays in the chapter "Arrays".
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter three numbers:");
            Console.Write("\nFirst number: ");
            Double firstNumber = Double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            Double secondNumber = Double.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            Double thirdNumber = Double.Parse(Console.ReadLine());

            Double[] unsortedArray = { firstNumber, secondNumber, thirdNumber };
            Array.Sort<Double>(unsortedArray);
            Array.Reverse(unsortedArray);

            Console.Write("\nNumbers sorted in descending order: ");
            for (int i = 0; i < unsortedArray.Length; i++)
                Console.Write("{0} ", unsortedArray[i]);
            Console.WriteLine();
        }
    }
}