/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Write a program that prints on the console isosceles triangle
|     which sides consist of the copyright character "©".
|
| Solutions and Guidelines:
|
|     Use Console.WriteLine(...), the character © and spaces.
|
|     Use Windows Character Map in order to find the Unicode
|     code of the sign "©".
|
|     Note that the console may display "c" instead of "©" if it does
|     not support Unicode. If this happens, you might be unable
|     to do anything to fix it. Some versions of Windows just do not
|     support Unicode in the console even when you explicitly
|     set the character encoding to UTF-8:
|
|       * Console.OutputEncoding = System.Text.Encoding.UTF8;
|
|     You may need to change the font of your console to some font
|     that supports the "©" symbol, e.g. "Consolas" or "Lucida Console".
|
*/

using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("   \u00A9             ");
            Console.WriteLine("  \u00A9 \u00A9       ");
            Console.WriteLine(" \u00A9 \u00A9 \u00A9 ");
        }
    }
}