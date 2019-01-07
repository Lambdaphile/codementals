/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Write a program, which prints on the standard output
|     the count of days, hours, and minutes, which have passes
|     since the computer is started until the moment
|     of the program execution.
|     For the implementation use the class Environment.
|
| Solutions and Guidelines:
|
|     Use the property Environment.TickCount, in order to get
|     the count of passed milliseconds. Use the fact that one
|     second has 1,000 milliseconds; one minute has 60 seconds;
|     one hour has 60 minutes and one day has 24 hours.
|
*/

using System;

namespace Program
{
    class Program
    {
        static int ConvertTimeUnit(dynamic givenTimeUnit, int divisor)
        {
            int convertedTimeUnit = 0;

            while (givenTimeUnit > 0)
            {
                convertedTimeUnit += givenTimeUnit / divisor;
                givenTimeUnit /= divisor;
            }

            return convertedTimeUnit;
        }

        static void PrintUpTime(int days, int hours, int minutes)
        {
            if (hours < 10)
                Console.Write("\nUptime: 0{0}:", hours);
            else
                Console.Write("{0}:", hours);
            if (minutes < 10)
                Console.Write("0{0}", minutes);
            else
                Console.Write("{0}", minutes);
            Console.Write(" ({0} Days)", days);
        }

        static void Main(string[] args)
        {
            long milliseconds = Environment.TickCount;

            // Converting one time unit to another, until
            // we have every time unit we want i.e. days:HH:mm...
            int seconds = ConvertTimeUnit(milliseconds, 1000);
            int minutes = ConvertTimeUnit(seconds, 60);
            int hours = ConvertTimeUnit(minutes, 60);
            int days = ConvertTimeUnit(hours, 24);

            // To be able display days, hours, minutes in human
            // readable way, we subtract days from hours
            // and hours from minutes.
            seconds -= ((minutes * 59) + 30);
            if (days != 0)
                hours -= (days * 24);
            minutes -= (hours * 60);

            PrintUpTime(days, hours, minutes);
            Console.WriteLine();
        }
    }
}