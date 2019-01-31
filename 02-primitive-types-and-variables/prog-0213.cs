/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 13:
|
|     Declare two variables of type int. Assign to them values
|     5 and 10 respectively. Exchange (swap) their values
|     and print them.
|
| Solutions and Guidelines:
|
|     Use third temporary variable for exchanging the variables:
|
|       * int a = 5;
|         int b = 10;
|
|         int oldA = a;
|         a = b;
|         b = oldA;
|
|     To swap integer variables other solutions exist which
|     do not use a third variable. For example,  if we have
|     two integer variables a and b:
|
|       * int a = 5;
|         int b = 10;
|
|         a = a + b;
|         b = a - b;
|         a = a - b;
|
|     You might also use the XOR swap algorithm for exchanging
|     integer values: http://en.wikipedia.org/wiki/XOR_swap_algorithm.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After exchanging values of the variables a(5) and b(10): a = {0}, b = {1}", a, b);
        }
    }
}