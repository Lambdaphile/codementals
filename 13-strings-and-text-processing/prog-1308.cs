/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Write a program that encrypts a text by applying XOR
|     (excluding or) operation between the given source characters
|     and given cipher code. The encryption should be done by
|     applying XOR between the first letter of the text and the
|     first letter of the code, the second letter of the text
|     and the second letter of the code, etc. Until the last letter
|     of the code, then goes back to the first letter of the code
|     and the next letter of the text. Print the result as a series
|     of Unicode escape characters \xxxx.
|
|       * Sample source text: "Test". Sample cipher code: "ab".
|
|     The result should be the following: "\u0035\u0007\u0012\u0016".
|
| Solutions and Guidelines:
|
|     Let the cipher "cipher" consists of cipher.Length letters.
|     Iterate through all letters in the text and encrypt the letter
|     at position index in the text with cipher[index % cipher.Length].
|     If you have a letter from the text and letter from the cipher,
|     we can perform XOR operation between them by transforming in
|     advance the two letters into numbers of type ushort.
|     We can print the result with "\u{0:x4}" format string.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = "Test";
            string cipher = "ab";

            for (int i = 0; i < text.Length;)
            {
                for (int j = 0; j < cipher.Length; j++)
                {
                    Console.Write($"\\u{text[i] ^ cipher[j]:x4}");
                    i++;
                }
            }
        }
    }
}