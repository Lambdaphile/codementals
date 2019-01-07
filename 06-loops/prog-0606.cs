/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a program that calculates N!/K! for given N and K (1<K<N)
|
| Solutions and Guidelines:
|
|     Multiply the numbers from K+1 to N (think why this is correct).
|     You may check the properties of the factorial function
|     in Wikipedia: http://en.wikipedia.org/wiki/Factorial.
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
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integers N and K (1<K<N):");
            Console.Write("\nN = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            int xFactorial = 1;
            for (int i = k + 1; i <= n; i++)
            {
                xFactorial *= i;
            }
            Console.WriteLine("\nN! / K! = {0}", xFactorial);
        }
    }
}