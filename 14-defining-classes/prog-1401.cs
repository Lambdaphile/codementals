/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 1:
|
|     Define a class Student, which contains the following information
|     about students: full name, course, subject, university, e-mail
|     and phone number.
|
| Solutions and Guidelines:
|
|     Use enum for subjects and universities.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Student
    {
        private string fullName;
        private string email;
        private int course;
        private long phoneNumber;
        enum Subjects { Math, Physics, Philosophy }
        private Subjects subject;
        enum Universities { Standford, IBM, Harvard }
        private Universities university;
    }
}