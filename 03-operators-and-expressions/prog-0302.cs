/*
|--------------------------------------------------------------------------
| Chapter 3. Operators and Expressions
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Write a Boolean expression that checks whether a given integer
|     is divisible by both 5 and 7, without a remainder.
|
| Solutions and Guidelines:
|
|     Use a logical "AND" (&& operator) and the remainder operation %
|     in division. You can also solve the problem by only one test:
|     the division of 35 (think why).
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
            int x = 34;

            Console.WriteLine(x % 5 == 0 && x % 7 == 0 ?
                "Number is divisible by both 5 and 7." : "Number is not divisible by both 5 and 7.");
        }
    }
}