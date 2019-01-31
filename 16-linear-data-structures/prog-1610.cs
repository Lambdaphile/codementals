/*
|--------------------------------------------------------------------------
| Chapter 16. Linear Data Structures
|--------------------------------------------------------------------------
|
| Exercise 10:
|
|     We are given N and M and the following operations:
|
|       * N = N + 1
|         N = N + 2
|         N = N * 2
|
|     Write a program, which finds the shortest subsequence
|     from the operations, which starts with N and ends with M.
|     Use queue.
|
|       * Example: N = 5, M = 16
|         Subsequence: 5 -> 7 -> 8 -> 16
|
| Solutions and Guidelines:
|
|     Use the data structure queue. Firstly, add to the queue N.
|     Repeat the following in a loop until M is reached:
|     remove a number X from the queue and add 3 new elements:
|     X * 2, X + 2 and X + 1. Do not add numbers greater than M.
|     As optimization of the solution, try to avoid repeating
|     numbers in the queue.
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

        }
    }
}