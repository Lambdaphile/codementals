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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Student
    {
        private string fullName = null;
        private string email = null;
        private int phoneNumber;
        private int course = 0;
        public enum Subjects { Math, Physics, Philosophy }
        private Subjects subject;
        public enum Universities { Standford, IBM, Harvard }
        private Universities university;
        public static int instanceCounter = 0;

        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Course { get => course; set => course = value; }

        public Student()
            : this(null) { }

        public Student(string fullName)
            : this(fullName, null) { }

        public Student(string fullName, string email)
            : this(fullName, email, 0) { }

        public Student(string fullName, string email, int phoneNumber)
            : this(fullName, email, phoneNumber, 0, Subjects.Math, Universities.Harvard) { }

        public Student(string fullName, string email, int phoneNumber, int course, Subjects subject, Universities university)
        {
            this.FullName = fullName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Course = course;
            this.subject = subject;
            this.university = university;
            instanceCounter++;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("\nStudent Information:");
            Console.WriteLine("-------------------------------------\n");
            Console.WriteLine("  Name: " + this.FullName);
            Console.WriteLine("  E-Mail: " + this.Email);
            Console.WriteLine("  Phone Number: " + this.PhoneNumber);
            Console.WriteLine("  Course: " + this.Course);
            Console.WriteLine("  Study subject: " + this.subject);
            Console.WriteLine("  University: " + this.university);
        }

        public static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Chewbacca", "chewbacca@starmail.com", 1111111111);
            Student student3 = new Student("Han Solo", "hansolo@starmail.com", 222222222, 10, Subjects.Philosophy, Universities.Standford);

            Tester.TestClassFunctionality(student1);
            Tester.TestClassFunctionality(student2);
            Tester.TestClassFunctionality(student3);
        }
    }

    public class Tester
    {
        public static void TestClassFunctionality(Student student)
        {
            try
            {
                student.DisplayStudentInfo();
            }
            catch (Exception exc)
            {
                Console.WriteLine("\nThere's problem with displaying student info.");
                Console.Write("\n\nWould you like to see more details?(Y/N): ");
                char userChoice = Console.ReadKey().KeyChar;
                if (userChoice == 'Y' || userChoice == 'y')
                    Console.WriteLine("\n\n" + exc.StackTrace);
                else
                    Console.WriteLine("\nOkay, bye!");
            }
        }
    }
}