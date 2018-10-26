/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 2:
|
|     Declare several constructors for the class Student,
|     which have different lists of parameters (for complete
|     information about a student or part of it).
|     Data, which has no initial value to be initialized with null.
|     Use nullable types for all non-mandatory data.
|
| Solutions and Guidelines:
|
|     To avoid repetition of source code call constructors
|     from each other with keyword this(<parameters>).
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
        private string fullName = null;
        private string email = null;
        private int phoneNumber = 0;
        private int course = 0;
        public enum Subjects { Math, Physics, Philosophy }
        private Subjects subject;
        public enum Universities { Standford, IBM, Harvard }
        private Universities university;

        public Student()
            : this(null)
        {

        }

        public Student(string fullName)
            : this(fullName, null) { }

        public Student(string fullName, string email)
            : this(fullName, email, 0) { }

        public Student(string fullName, string email, int phoneNumber)
            : this(fullName, email, phoneNumber, 0, Subjects.Math, Universities.Harvard) { }

        public Student(string fullName, string email, int phoneNumber, int course, Subjects subject, Universities university)
        {
            this.fullName = fullName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.course = course;
            this.subject = subject;
            this.university = university;
        }

        public static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Chewbacca");
            Student student3 = new Student("Han Solo", "hansolo@starmail.com");
            Student student4 = new Student("Anakin Skywalker", "anakinskywalker@starmail.com", 222222222);
            Student student5 = new Student("Luke Skywalker", "lukeskywalker@starmail.com", 10, 1111111111,
                Subjects.Philosophy, Universities.Standford);
        }
    }
}