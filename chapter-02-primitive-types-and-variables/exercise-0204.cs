/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Initialize a variable of type int with a value of 256 in
|     hexadecimal format (256 is 100 in a numeral system with base 16).
|
| Solutions and Guidelines:
|
|     Look at the section about Integer Literals. To easily
|     convert numbers to a different numeral system use
|     the built-in Windows calculator. For a hexadecimal
|     representation of the literal use prefix 0x.
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
            int container = 0x100;
            Console.WriteLine(container);
        }
    }
}