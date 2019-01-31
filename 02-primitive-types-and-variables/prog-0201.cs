/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Declare several variables by selecting for each
|     one of them the most appropriate of the types:
|
|       * sbyte, byte, short, ushort, int, uint, long and ulong
|
|     in order to assign them the following values:
|
|       * 52,130; -115; 4825932; 97; -10000; 20000; 224;
|         970,700,000; 112; -44; -1,000,000; 1990;
|         123456789123456789.
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
            sbyte sbyteNum1 = -115, sbyteNum2 = -44;
            byte byteNum1 = 97, byteNum2 = 224, byteNum3 = 112;
            short shortNum1 = -10000, shortNum2 = 20000, shortNum = 1990;
            ushort ushortNum1 = 52130, ushortNum2 = 52;
            int intNum1 = 4825932, intNum2 = 970700000, intNum3 = -1000000;
            uint uintNum1;
            long longNum = 123456789123456789;
            ulong ulongNum1;
        }
    }
}