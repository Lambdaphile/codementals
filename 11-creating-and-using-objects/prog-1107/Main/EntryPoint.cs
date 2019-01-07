/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Define your own namespace CreatingAndUsingObjects and place in it
|     two classes Cat and Sequence, which we used in the examples
|     of the current chapter.
|     Define one more namespace and make a class, which calls
|     the classes Cat and Sequence, in it.
|
| Solutions and Guidelines:
|
|     Make a new project in Visual Studio, right click on the folder
|     and choose the menu Add -> New Folder. Then enter the name
|     of the folder and press [Enter], right click on the newly made
|     folder and choose Add -> New Item... from the list choose Class,
|     for the name of the new class enter Cat and press [Add].
|     Change the definition of the newly created class with
|     the definition, which we gave to this chapter, to put
|     the classes in a namespace.
|     Make the same to the class Sequence.
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
        static void Main(string[] args)
        {
            Cat testCat = new Cat();
            Sequence testSequence = new Sequence();
        }
    }
}
