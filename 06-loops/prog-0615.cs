/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 15:
|
|     Write a program that converts a given number from
|     hexadecimal to decimal notation.
|
| Solutions and Guidelines:
|
|     See the previous problem.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a number in hexadecimal notation: ");
            string hexNum = Console.ReadLine();
            char[] hexNumArr = hexNum.ToCharArray();
            Array.Reverse(hexNumArr);

            double decimalNum = 0;
            double pow = 0;
            foreach (var num in hexNumArr)
            {
                switch (num)
                {
                    case 'A':
                        decimalNum += 10 * Math.Pow(16, pow);
                        break;
                    case 'B':
                        decimalNum += 11 * Math.Pow(16, pow);
                        break;
                    case 'C':
                        decimalNum += 12 * Math.Pow(16, pow);
                        break;
                    case 'D':
                        decimalNum += 13 * Math.Pow(16, pow);
                        break;
                    case 'E':
                        decimalNum += 14 * Math.Pow(16, pow);
                        break;
                    case 'F':
                        decimalNum += 15 * Math.Pow(16, pow);
                        break;
                    default:
                        decimalNum += Char.GetNumericValue(num) * Math.Pow(16, pow);
                        break;
                }

                pow++;
            }
            Console.WriteLine("\nDecimal representation of entered hex number {0}: {1}",
                hexNum, decimalNum);
        }
    }
}