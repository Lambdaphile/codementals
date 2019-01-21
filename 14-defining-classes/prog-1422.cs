/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 22:
|
|     We have a school. In school we have classes and students.
|     Each class has a number of teachers. Each teacher has 
|     a variety of disciplines taught. Students have a name
|     and a unique number in the class. Classes have a unique 
|     text identifier. Disciplines have a name, number of lessons
|     and number of exercises. The task is to shape a school 
|     with C# classes. You have to define classes with their
|     fields, properties, methods and constructors. 
|     Also define a test class, which demonstrates, that the
|     other classes work correctly.
|
| Solutions and Guidelines:
|
|     Create classes School, SchoolClass, Student, Teacher,
|     Discipline and define into them their respective fields,
|     as described in the instructions of the task. 
|     Do not use the word "Class" as a class name, because 
|     in C# it has special meaning. Add methods for printing 
|     all the fields from each of the classes.
|
*/

using System;

namespace Program
{
    public class School
    {
        public Student Students { get; set; }
        public SchoolClass Classes { get; set; }

    }

    public class SchoolClass
    {
        public Teacher teachers { get; set; }
    }

    public class Student
    {
        private string name = null;
        private string studentNumber = null;
    }

    public class Teacher
    {
        public Discipline Disciplines { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Discipline
    {
        public string name;
        public int lessions;
        public int exercises;
    }

    public class SchoolTest
    {

    }
}