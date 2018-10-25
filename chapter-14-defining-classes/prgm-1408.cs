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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class GSM
    {
        string model;
        string manufacturer;
        double price;
        string owner;
        string features;
    }

    public class Battery
    {
        string model;
        int idleTime;
        int talkHours;
    }

    public class Display
    {
        double size;
        double colors;
    }
}