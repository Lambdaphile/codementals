/*
|--------------------------------------------------------------------------
| Chapter 2. Primitive Types and Variables
|--------------------------------------------------------------------------
|
| Exercise 12:
|
|     A company dealing with marketing wants to keep a data record
|     of it's employees. Each record should have the following
|     characteristics:
|
|       * first name, last name, age, gender (‘m’ or ‘f’)
|         and unique employee number (27560000 to 27569999).
|
|     Declare appropriate variables needed to maintain the information
|     for an employee by using the appropriate data types
|     and attribute names.
|
| Solutions and Guidelines:
|
|     For the names use type string, for the gender use type char
|     (only on char m/f), and for the unique number and age
|     use some integer type.
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
            Console.OutputEncoding = Encoding.UTF8;

            string firstName;
            string lastName;
            byte age;
            char gender;
            int employeeNumber;
        }
    }
}