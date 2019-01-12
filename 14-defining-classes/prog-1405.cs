/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Modify the current source code of Student class so as to
|     encapsulate the data in the class using properties.
|
| Solutions and Guidelines:
|
|     Define as private all members of the class Student
|     and then using Visual Studio (Refactor -> Encapsulate Field)
|     define automatically the public get / set methods
|     to access these fields.
|
*/

using System;

namespace Program
{
    public class Student
    {
        private string fullName = null;
        private string email = null;
        private long phoneNumber;
        private int course = 0;
        public enum Subjects { None, Math, Physics, Philosophy }
        private Subjects subject;
        public enum Universities { None, Standford, IBM, Harvard }
        private Universities university;
        public static int instances = 0;

        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Course { get => course; set => course = value; }
        public Subjects Subject { get => subject; set => subject = value; }
        public Universities University { get => university; set => university = value; }

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
            this.FullName = fullName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Course = course;
            this.Subject = subject;
            this.University = university;
            instances++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nName: {this.fullName}, E-Mail: {this.email},\nPhone Number: {this.phoneNumber}, Course: {this.course}, Study subject: {this.subject}, University: {this.university}\n");
        }
    }
}