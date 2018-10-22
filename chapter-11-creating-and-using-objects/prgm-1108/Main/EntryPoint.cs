/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Write a program which creates 10 objects of type Cat,
|     gives them names CatN, where N is a unique serial number
|     of the object, and in the end call the method SayMiau()
|     for each of them. For the implementation use the
|     namespace CreatingAndUsingObjects.
|
| Solutions and Guidelines:
|
|     Create an array with 10 elements of type Cat. Create 10 objects
|     of type Cat in a loop (use a constructor with parameters)
|     and assign them to the corresponding element of the array.
|     For the serial number of the objects use the method NextValue()
|     of the Sequence class. In the end again in an array use the method
|     SayMiau() for each of the array elements.
|
*/

using Program.CreatingAndUsingObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Main
{
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            Cat[] catArray = new Cat[10];
            for (int i = 0; i < 10; i++)
            {
                catArray[i] = new Cat("(" + Sequence.NextValue() + ")");
            }

            for (int i = 0; i < 10; i++)
            {
                catArray[i].SayMiau();
            }
        }
    }
}
