/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Which of the following values can be assigned to variables of
|     type float, double and decimal: 5, -5.01, 34.567839023; 12.345;
|     8923.1234857; 3456.091124875956542151256683467?
|
| Solutions and Guidelines:
|
|     Consider the number of digits after the decimal point.
|     Refer to the table that describes the sizes of the types
|     float, double and decimal.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 5;
            float num2 = -5.01f;
            double num3 = 34.567839023;
            float num4 = 12.345f;
            double num5 = 8923.1234857;
            decimal num6 = 3456.091124875956542151256683467m;
        }
    }
}