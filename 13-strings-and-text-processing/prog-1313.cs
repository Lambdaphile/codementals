/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 13:
|
|     Write a program that reverses the words in a given
|     sentence without changing punctuation and spaces.
|
|       * For example: "C# is not C++ and PHP is not Delphi" ->
|         "Delphi not is PHP and C++ not is C#".
|
| Solutions and Guidelines:
|
|     You can solve the problem in two steps: reverse
|     the input string; reverse each word in the result string.
|
|     Another interesting approach is to split the input text
|     by punctuation marks between words, in order to get
|     just the words of the text and then split by the letters
|     to get the punctuation marks of the text.
|     Thus, given a list of words and a list of punctuation marks
|     between them, you can easily reverse the words, preserving
|     the punctuation marks.
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
        public static string ReverseStringWords(string str)
        {
            string temp;
            StringBuilder word = new StringBuilder();
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' && str[i] != '.' && str[i] != ',' && str[i] != '!' & str[i] != '?' &&
                    str[i] != ';' && str[i] != ':' && str[i] != '-' && str[i] != '(' &&  str[i] != ')')
                {
                    word.Append(str[i]);
                }
                else
                {
                    temp = word.ToString();
                    temp = ReverseString(temp);
                    newStr.Append(temp + str[i]);
                    word.Clear();
                }
            }
            // Reversing & appending the last word from the string
            temp = word.ToString();
            temp = ReverseString(temp);
            newStr.Append(temp);

            return newStr.ToString();
        }

        public static string ReverseString(string str)
        {
            StringBuilder sbStr = new StringBuilder();
            for (int i = str.Length -1; i >= 0; i--)
            {
                sbStr.Append(str[i]);
            }
            return sbStr.ToString() ;
        }

        static void Main(string[] args)
        {
            string str = "C# is not C++ and PHP is not Delphi";
            str = ReverseString(str);
            str = ReverseStringWords(str);
            Console.WriteLine(str);
        }
    }
}