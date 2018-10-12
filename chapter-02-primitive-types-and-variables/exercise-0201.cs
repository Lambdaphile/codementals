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
            sbyte a = 52;
            byte b = 130;
            sbyte c = -115;
            int d = 4825932;
            sbyte e = 97;
            short f = -10000;
            short g = 20000;
            byte h = 224;
            int i = 970700000;
            sbyte j = 112;
            sbyte k = -44;
            int l = -1000000;
            short m = 1990;
            long n = 123456789123456789;
        }
    }
}