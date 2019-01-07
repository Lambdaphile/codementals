/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 6:
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
        private int phoneNumber;
        private int course = 0;
        public enum Subjects { Math, Physics, Philosophy }
        private Subjects subject;
        public enum Universities { Standford, IBM, Harvard }
        private Universities university;
        public static int instances = 0;

        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Course { get => course; set => course = value; }
        public Subjects Subject { get => subject; set => subject = value; }
        public Universities University { get => university; set => university = value; }

        public Student()
            :this (null) {}

        public Student(string fullName)
            : this(fullName, null) { }

        public Student(string fullName, string email)
            : this(fullName, email, 0) { }

        public Student(string fullName, string email, int phoneNumber)
            : this(fullName, email, phoneNumber, 0, Subjects.Math, Universities.Harvard) { }

        public Student(string fullName, string email, int phoneNumber, int course, Subjects subject, Universities university)
        {
            this.phoneNumber = phoneNumber;
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
            Console.WriteLine("\nName: {0}, E-Mail: {1},\nPhone Number: {2}, Course: {3}, Study subject: {4}, University: {5}\n",
                this.fullName, this.Email, this.PhoneNumber, this.Course, this.Subject, this.University);
        }
    }

    public class Tester
    {
        public static object testStudent1;
        static Tester()
        {
            Tester.testStudent1 = new Student("chewbacca", "chewbacca@starmail.com", 11111111);
        }

        public static object TestStudent1
        {
            get { return TestStudent1; }
            set { TestStudent1 = value; }
        }

        public static void DisplayInfo()
        {
            Console.WriteLine();
        }

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
            testStudent1.
        }
    }
}