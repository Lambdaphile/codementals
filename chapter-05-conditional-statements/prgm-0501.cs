/*
|--------------------------------------------------------------------------
| Chapter 5. Conditional Statements
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Write an if-statement that takes two integer variables
|     and exchanges their values if the first one
|     is greater than the second one.
|
| Solutions and Guidelines:
|
|     Look at the section about if-statements.
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
            int a = 9, b = 7;
            if (a > b)
            {
                int container = a;
                a = b;
                b = container;
            }
            Console.WriteLine("After the swap a = {0}, b = {1}", a , b);
        }
    }
}