/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 8:
|
|     Define a class, which contains information about a mobile phone:
|     model, manufacturer, price, owner, features of the battery
|     (model, idle time and hours talk) and features of the screen
|     (size and colors).
|
| Solutions and Guidelines:
|
|     Declare three separate classes: GSM, Battery and Display.
|
*/

using System;

namespace Program
{
    public class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private double price = 0;
        private string owner = null;
    }

    public class Battery
    {
        private string model = null;
        private double idleTime = 0;
        private double talkHours = 0;
    }

    public class Display
    {
        private double size = 0;
        private double colors = 0;
    }
}