/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     Write a program, which calculates the count of workdays between
|     the current date and another given date after the current
|     (inclusive). Consider that workdays are all days from Monday
|     to Friday, which are not public holidays, except when Saturday
|     is a working day. The program should keep a list of predefined
|     public holidays, as well as a list of predefined working Saturdays.
|
| Solutions and Guidelines:
|
|     Use the class System.DateTime and the methods in it.
|     You can execute a loop from the current date (DateTime.Now.Date)
|     to the end date, consecutively incrementing the day by the method
|     AddDays(1) and count the working days according to your country
|     (e.g. all days except Saturday and Sunday and a few fixed
|     non-working official holidays).
|
|     Another approach that might work is to subtract the dates to find
|     the TimeSpan between them (DateTime values can be subtracted,
|     just like a numbers). This will give you the count of days between
|     the dates. You will need to perform some additional calculations
|     to find how much weekends are included in this count
|     and discard them.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static bool CheckForHoliday(DateTime currentDate)
        {
            // DateTime array containing Bulgarian holidays...
            DateTime[] holydays = new DateTime[]
            {
                new DateTime(DateTime.Now.Year, 01, 01),
                new DateTime(DateTime.Now.Year, 03, 03),
                new DateTime(DateTime.Now.Year, 03, 05),
                new DateTime(DateTime.Now.Year, 04, 06),
                new DateTime(DateTime.Now.Year, 04, 07),
                new DateTime(DateTime.Now.Year, 04, 30),
                new DateTime(DateTime.Now.Year, 05, 01),
                new DateTime(DateTime.Now.Year, 05, 06),
                new DateTime(DateTime.Now.Year, 05, 07),
                new DateTime(DateTime.Now.Year, 05, 24),
                new DateTime(DateTime.Now.Year, 09, 06),
                new DateTime(DateTime.Now.Year, 09, 22),
                new DateTime(DateTime.Now.Year, 09, 24),
                new DateTime(DateTime.Now.Year, 12, 24),
                new DateTime(DateTime.Now.Year, 12, 25),
                new DateTime(DateTime.Now.Year, 12, 26),
                new DateTime(DateTime.Now.Year, 12, 31)
            };

            bool isHoliday = false;
            for (int i = 0; i < holydays.Length; i++)
            {
                if (currentDate == holydays[i])
                {
                    isHoliday = true;
                    break;
                }
            }

            return isHoliday;
        }

        public static bool CheckForWorkingSaturday(DateTime currentDate)
        {
            // Yeah... some random predefined working saturdays :)
            DateTime[] workingSaturdays = new DateTime[]
            {
                new DateTime(2018, 01, 06),
                new DateTime(2018, 03, 10),
                new DateTime(2018, 04, 21),
                new DateTime(2018, 06, 23),
                new DateTime(2018, 08, 18),
                new DateTime(2018, 09, 29),
                new DateTime(2018, 11, 24),
                new DateTime(2018, 12, 22)
            };

            bool isWorkingSaturday = false;
            for (int i = 0; i < workingSaturdays.Length; i++)
            {
                if (currentDate == workingSaturdays[i])
                {
                    isWorkingSaturday = true;
                    break;
                }
            }

            return isWorkingSaturday;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease, enter a date to count workdays between the current and given date:");
            Console.WriteLine("--------------------------------------------------------------------------\n");
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime givenDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now.Date;

            int workdays = 0;
            DateTime startDate = currentDate;
            while (currentDate != givenDate)
            {
                if (currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (currentDate.DayOfWeek == DayOfWeek.Saturday && !CheckForWorkingSaturday(currentDate))
                        continue;
                    if (CheckForHoliday(currentDate))
                        continue;

                    workdays++;
                }
                currentDate = currentDate.AddDays(1);
            }

            Console.WriteLine("\nWorkdays between {0:dddd, dd MMMM yyyy} and {1:dddd, dd MMMM yyyy} is {2} days.",
                startDate, givenDate, workdays);
        }
    }
}