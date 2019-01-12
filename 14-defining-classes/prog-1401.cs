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

namespace Program
{
    public class Student
    {
        private string fullName = null;
        private string email = null;
        private int course = 0;
        private long phoneNumber = 0;
        enum Subjects { None, Math, Physics, Philosophy }
        private Subjects subject;
        enum Universities { None, Standford, IBM, Harvard }
        private Universities university;
    }
}