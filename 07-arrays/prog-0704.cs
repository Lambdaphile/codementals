/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Write a program, which finds the maximal sequence of
|     consecutive equal elements in an array.
|
|       * E.g.: {1, 1, 2, 3, 2, 2, 2, 1} -> {2, 2, 2}.
|
| Solutions and Guidelines:
|
|     Scan the array from left to right. Every time when
|     the current number is different from the one before it,
|     a new sequence starts.
|
|     If the current element is equal to the one before it,
|     it is a continuation of the same sequence. So, if we keep
|     the index of the start position of the current sequence
|     (in the beginning it is 0) in start and the length of the
|     current sequence (in the beginning it is 1) in len, we can
|     find all sequences of equal elements and their lengths.
|
|     We can easily keep the shortest one in two additional
|     variables – bestStart and bestLen.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayX = { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3 };
            int len = 1, bestLen = 1, lenElement = 0, bestLenElement = 0;
            for (int i = 0; i < arrayX.Length - 1; i++)
            {
                if (arrayX[i] == arrayX[i + 1])
                {
                    lenElement = arrayX[i];
                    len++;
                }
                if (arrayX[i] != arrayX[i + 1] || i == arrayX.Length - 2)
                {
                    if (bestLen < len)
                    {
                        bestLen = len;
                        bestLenElement = lenElement;
                    }
                    len = 1;
                }
            }

            Console.Write("The maximal sequence of consecutive elements in the given sequence:\n\n{");
            for (int i = 0; i < arrayX.Length; i++)
            {
                if (i < arrayX.Length - 1)
                    Console.Write("{0}, ", arrayX[i]);
                else
                    Console.Write("{0}", arrayX[i]);
            }
            Console.Write("} -> {");
            for (int i = 0; i < bestLen; i++)
            {
                if (i < bestLen - 1)
                    Console.Write("{0}, ", bestLenElement);
                else
                    Console.Write("{0}", bestLenElement);
            }
            Console.Write("}\n");
        }
    }
}
