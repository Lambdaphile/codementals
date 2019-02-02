/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Write a program, which finds the maximal sequence of
|     consecutively placed increasing integers.
|
|       * Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
|
| Solutions and Guidelines:
|
|     This exercise is very similar to the previous one,
|     but we have a continuation of the current sequence
|     when the next element is bigger.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayX = { 3, 2, 3, 4, 2, 2, 4 };
            int len = 1, bestLen = 1, lenElement = 0, bestLenElement = 0;
            for (int i = 0; i < arrayX.Length - 1; i++)
            {
                // We make our program to track the sequences that are
                // increased only by +1, otherwise we can't print
                // the exact numbers or we have to use linear structure.
                if (arrayX[i] == (arrayX[i + 1] - 1))
                {
                    lenElement = arrayX[i];
                    len++;
                }

                if (arrayX[i] != (arrayX[i + 1] - 1) || i == arrayX.Length - 2)
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
            // Since our sequence is increased only by +1, we can
            // find which number was the first number of the
            // biggest sequence and then just simulate it.
            int bestLenSimulation = bestLenElement - (bestLen - 2);
            for (int i = 0; i < bestLen; i++)
            {
                if (i < bestLen - 1)
                    Console.Write("{0}, ", bestLenSimulation);
                else
                    Console.Write("{0}", bestLenSimulation);
                bestLenSimulation++;
            }
            Console.Write("}\n");
        }
    }
}