/*
|--------------------------------------------------------------------------
| Chapter 9. Methods
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Write a method that prints the digits of a given decimal number
|     in a reversed order. For example 256, must be printed as 652.
|
| Solutions and Guidelines:
|
|     There are two solutions:
|
|     First solution: Let the number is num. So while num != 0
|     we print its last digit (num % 10) and then divide num by 10.
|
|     Second solution: Convert the number into a string
|     and print it in a reverse order with a for-loop.
|     This is a bit cheater’s approach.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static int ReverseInteger(int num)
        {
            int reversedNum = 0;

            while (num != 0)
            {
                int container = num % 10;
                reversedNum *= 10;
                reversedNum += container;
                num /= 10;
            }

            return reversedNum;
        }

        static void Main(string[] args)
        {
            Console.Write("Please, enter a integer: ");
            int num = int.Parse(Console.ReadLine());

            int reversedNum = ReverseInteger(num);
            Console.WriteLine("After reversing the number ({0}) it becomes ({1}).", num, reversedNum);
        }
    }
}