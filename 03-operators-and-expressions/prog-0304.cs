/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Write an expression that checks whether the third bit
|     in a given integer is 1 or 0.
|
| Solutions and Guidelines:
|
|     Use bitwise "AND" on the current number and the number
|     that has 1 only in the third bit (i.e. number 8, if bits
|     start counting from 0). If the returned result is different
|     from 0 the third bit is 1:
|
|       * int num = 25;
|         bool bit3 = (num & 8) != 0;
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 25;

            Console.WriteLine((num & 8) != 0 ? "Third bit is 1" : "Third bit is not 1");
        }
    }
}