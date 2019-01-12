/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 6:
|
|     Write a class StudentTest, which has to test
|     the functionality of the class Student.
|
| Solutions and Guidelines:
|
|     Create a few students and display the whole information
|     for each one of them.
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

    public class StudentTest
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Chewbacca");
            Student student3 = new Student("Han Solo", "hansolo@starmail.com");
            Student student4 = new Student("Anakin Skywalker", "anakinskywalker@starmail.com", 222222222);
            Student student5 = new Student("Luke Skywalker", "lukeskywalker@starmail.com", 1111111111, 10,
                Student.Subjects.Philosophy, Student.Universities.Standford);

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
            student4.DisplayInfo();
            student5.DisplayInfo();
        }
    }
}