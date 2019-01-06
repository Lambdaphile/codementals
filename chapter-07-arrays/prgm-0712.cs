/*
|--------------------------------------------------------------------------
| Chapter 7. Arrays
|--------------------------------------------------------------------------
|
| Exercise 12:
|
|     Write a program, which creates square matrices like those
|     in the figures below and prints them formatted to the console.
|     The size of the matrices will be read from the console.
|     See the examples for matrices with size of 4 x 4 and make
|     the other sizes in a similar fashion:
|
|       * a) 1  5 9  13              b) 1  8  9  16
|            2  6 10 14                 2  7  10 15
|            3  7 11 15                 3  6  11 14
|            4  8 12 16                 4  5  12 13
|
|         c) 7  11 14 16             d)* 1  12 11 10
|            4  8  12 15                 2  13 16 9
|            2  5  9  13                 3  14 15 8
|            1  3  6  10                 4  5  6  7
|
| Solutions and Guidelines:
|
|     a), b), c) Think about appropriate ways for iterating through
|     the matrices with two nested loops.
|
|     d) We can start from (0, 0) and go down N times.
|     Therefore, go to the right N-1 times, after that up N-1 times,
|     after that left N-2 times, after that down N-2 times and etc.
|     At each iteration we place the next number in a sequence
|     1, 2, 3, ..., N in the cell, which we are leaving.
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
            Console.WriteLine("Please, enter needed square matrix size (Example: enter 4 for 4 x 4 matrix):\n");
            int matrixSize;
            do
            {
                Console.Write("Needed size: ");
                if (int.TryParse(Console.ReadLine(), out int integer))
                {
                    matrixSize = integer;
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please try again.");
                }
            } while (true);

            int[,] matrixA = new int[matrixSize, matrixSize];
            // Generating matrix like in example a)
            int numerator = 1;
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrixA[j, i] = numerator;
                    numerator++;
                }
            }

            // Printing the matrix of example a)
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write("{0}, ", matrixA[i,j]);
                }
                Console.WriteLine();
            }

            // Generating matrix like in example b)
            int[,] matrixB = new int[matrixSize, matrixSize];
            int row = 1, col = 1;
            for (int i = 1; i <= matrixSize * matrixSize; i++)
            {
                if (i < 5)
                {
                    matrixB[row, col] = i;
                    row++;
                    continue;
                }
                col = 1;
                if (i > 4 && i < 9)
                {
                    matrixB[row, col] = i;
                    row--;
                    continue;
                }
                col = 2;
                if (i > 8 && i < 13)
                {
                    matrixB[row, col] = i;
                    row++;
                    continue;
                }
                col = 3;
                if (i > 12 )
                {
                    matrixB[row, col] = i;
                    row--;
                }
            }

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write("{0, ", matrixB[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}