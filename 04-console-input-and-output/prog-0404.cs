/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Write a program that prints three numbers in three virtual
|     columns on the console. Each column should have a width
|     of 10 characters and the numbers should be left aligned.
|     The first number should be an integer in hexadecimal;
|     the second should be fractional positive; and the third
|     – a negative fraction. The last two numbers
|     have to be rounded to the second decimal place.
|
| Solutions and Guidelines:
|
|     Use the format strings explained in the “Composite Formatting”
|     section and the method Console.WriteLine().
|     Below is a piece of the code:
|
|       * int hexNum = 2013;
|         Console.WriteLine("|0x{0,-8:X}|", hexNum);
|         double fractNum = -1.856;
|         Console.WriteLine("|{0,-10:f2}|", fractNum);
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexNum = 2013;
            Console.WriteLine("|0x{0,-8:X}|", hexNum);

            double fractNum = 1.856;
            Console.WriteLine("|{0,-10:f2}|", fractNum);

            double fractNumNegative = -1.856;
            Console.WriteLine("|{0,-10:f2}|", fractNumNegative);
        }
    }
}