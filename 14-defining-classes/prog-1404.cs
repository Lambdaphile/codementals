/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Add a method in the class Student, which displays
|     complete information about the student.
|
| Solutions and Guidelines:
|
|     Display on the console in all fields of the class Student,
|     followed by a blank line.
|
*/

using System;

namespace Program
{
    public class Student
    {
        private string fullName = null;
        private string email = null;
        private long phoneNumber = 0;
        private int course = 0;
        public enum Subjects { None, Math, Physics, Philosophy }
        private Subjects subject;
        public enum Universities { None, Standford, IBM, Harvard }
        private Universities university;
        public static int instances = 0;

        public Student()
            : this(null) { }

        public Student(string fullName)
            : this(fullName, null) { }

        public Student(string fullName, string email)
            : this(fullName, email, 0) { }

        public Student(string fullName, string email, long phoneNumber)
            : this(fullName, email, phoneNumber, 0) { }

        public Student(string fullName, string email, long phoneNumber, int course)
            : this(fullName, email, phoneNumber, course, Subjects.None) { }

        public Student(string fullName, string email, long phoneNumber, int course, Subjects subject)
            : this(fullName, email, phoneNumber, course, subject, Universities.None) { }

        public Student(string fullName, string email, long phoneNumber, int course, Subjects subject, Universities university)
        {
            this.fullName = fullName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.course = course;
            this.subject = subject;
            this.university = university;
            instances++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nName: {this.fullName}, E-Mail: {this.email},\nPhone Number: {this.phoneNumber}, Course: {this.course}, Study subject: {this.subject}, University: {this.university}\n");
        }
    }
}