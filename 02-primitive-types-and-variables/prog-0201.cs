/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Declare several variables by selecting for each one of them
|     the most appropriate of the types: sbyte, byte, short,
|     ushort, int, uint, long and ulong in order to assign them
|     the following values: 52,130; -115; 4825932; 97;
|     -10000; 20000; 224; 970,700,000; 112; -44;
|     -1,000,000; 1990; 123456789123456789.
|
| Solutions and Guidelines:
|
|     Look at the ranges of the numerical types in C#
|     described in this chapter.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = 52;
            byte num2 = 130;
            sbyte num3 = -115;
            int num4 = 4825932;
            sbyte num5 = 97;
            short num6 = -10000;
            short num7 = 20000;
            byte num8 = 224;
            int num9 = 970700000;
            sbyte num10 = 112;
            sbyte num11 = -44;
            int num12 = -1000000;
            short num13 = 1990;
            long num14 = 123456789123456789;
        }
    }
}