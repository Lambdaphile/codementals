/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 7:
|
|     Add a static method in class StudentTest, which creates several
|     objects of type Student and store them in static fields.
|     Create a static property of the class to access them.
|     Write a test program, which displays the information about
|     them in the console.
|
| Solutions and Guidelines:
|
|     You can use the static constructor to create instances
|     in the first access to the class.
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
        private Subjects subject = 0;
        public enum Universities { None, Standford, IBM, Harvard }
        private Universities university = 0;
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
        private static Student student1;
        private static Student student2;
        private static Student student3;

        public static Student Student1 { get => student1; }
        public static Student Student2 { get => student2; }
        public static Student Student3 { get => student3; }

        static StudentTest()
        {
            student1 = new Student("Luke Skywalker", "lukeskywalker@starmail.com", 1111111111, 10,
                Student.Subjects.Philosophy, Student.Universities.Standford);
            student2 = new Student("Anakin Skywalker", "anakinskywalker@starmail.com", 222222222);
            student3 = student3 = new Student("Han Solo", "hansolo@starmail.com");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"\nName: {Student1.FullName}, E-Mail: {Student1.Email},\nPhone Number: {Student1.PhoneNumber}, Course: {Student1.Course}, Study subject: {Student1.Subject}, University: {Student1.University}\n");
            Console.WriteLine($"\nName: {Student2.FullName}, E-Mail: {Student2.Email},\nPhone Number: {Student2.PhoneNumber}, Course: {Student2.Course}, Study subject: {Student2.Subject}, University: {Student2.University}\n");
            Console.WriteLine($"\nName: {Student3.FullName}, E-Mail: {Student3.Email},\nPhone Number: {Student3.PhoneNumber}, Course: {Student3.Course}, Study subject: {Student3.Subject}, University: {Student3.University}\n");
        }
    }
}