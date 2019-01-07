/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Write a program that detects how many times a substring
|     is contained in the text. For example, let’s look
|     for the substring "in" in the text:
|
|       * We are living in a yellow submarine. We don't have
|         anything else. Inside the submarine is very tight.
|         So we are drinking all the day.
|         We will move out of it in 5 days.
|
| Solutions and Guidelines:
|
|     Reverse the casing of letters in text to small and search
|     the given substring in a loop. Remember to use IndexOf(...)
|     with a start index in order to avoid infinite loop.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string quote =
                "We are living in a yellow submarine. We don't have anything else." +
                "Inside the submarine is very tight. So we are drinking all the day. " +
                "We will move out of it in 5 days.";
            quote = quote.ToLower();
            string keyword = "in";

            int index = quote.IndexOf(keyword);
            int counter = 0;

            while(index != -1)
            {
                counter++;
                index = quote.IndexOf(keyword, index + keyword.Length);
            }

            Console.WriteLine($"\nIn the given text substring \"{keyword}\" has {counter} occurrences.");
        }
    }
}