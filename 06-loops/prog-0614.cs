/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 14:
|
|     Write a program that converts a given number from decimal
|     to hexadecimal notation.
|
| Solutions and Guidelines:
|
|     See the previous problem.
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
            Console.Write("Please, enter a number in decimal notation: ");
            int decimalNum = int.Parse(Console.ReadLine());

            int remainder;
            string hexNum = "";
            while (decimalNum > 0)
            {
                remainder = decimalNum % 16;
                switch (remainder)
                {
                    case int depends when (remainder >= 0 && remainder <= 9):
                        hexNum += remainder;
                        break;
                    case 10:
                        hexNum += 'A';
                        break;
                    case 11:
                        hexNum += 'B';
                        break;
                    case 12:
                        hexNum += 'C';
                        break;
                    case 13:
                        hexNum += 'D';
                        break;
                    case 14:
                        hexNum += 'E';
                        break;
                    case 15:
                        hexNum += 'F';
                        break;
                }
                decimalNum /= 16;
            }

            char[] hexNumArr = hexNum.ToCharArray();
            Array.Reverse(hexNumArr);
            hexNum = new string(hexNumArr);
            Console.WriteLine("\nThe number in hexadecimal notation: {0}", hexNum);
        }
    }
}