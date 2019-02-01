/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     We are given the following sequence:
|
|       S(1) = N;
|       S(2) = S(1) + 1;
|       S(3) = 2 * S(1) + 1;
|       S(4) = S(1) + 2;
|       S(5) = S(2) + 1;
|       S(6) = 2 * S(2) + 1;
|       S(7) = S(2) + 2;
|
|     Using the Queue<T> class, write a program which by
|     given N prints on the console the first 50 elements
|     of the sequence.
|
|       * e.g. N = 2 -> 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
|
| Solutions and Guidelines:
|
|     Use queue. In the beginning add N to the queue. After that
|     take the current element M and add to the queue M + 1,
|     then 2 * M + 1 and then M + 2. Repeat the same for the next
|     element in a loop. At each step in the loop print M
|     and if at certain point the queue size reaches 50, break
|     the loop and finish the calculation.
|
*/

using System;
using System.Collections.Generic;

namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> sequence = new Queue<int>(new[] { 2 });
            for (int i = 1; i < 51; i++)
            {
                int m = sequence.Dequeue();
                Console.Write(i % 10 != 0 ? $" {m, 2} " : "\n");
                sequence.Enqueue(m + 1);
                sequence.Enqueue(2 * m + 1);
                sequence.Enqueue(m + 2);
            }
        }
    }
}