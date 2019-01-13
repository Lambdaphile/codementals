/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Add an enumeration BatteryType, which contains the values
|     for type of the battery (Li-Ion, NiMH, NiCd, ...) and use it
|     as a new field for the class Battery.
|
| Solutions and Guidelines:
|
|     Use enum for the type of battery. Search in Internet for other
|     types of batteries for phones, except these in the requirements
|     and add them as value of the enumeration.
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
        private string features = null;
        private static string nokia95 = "Nokia95";

        public GSM()
            : this(null) { }

        public GSM(string model)
            : this(model, null) { }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0) { }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer, price, null) { }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public static void DisplayNokia95Info()
        {
            Console.WriteLine(nokia95);
        }
    }

    public class Battery
    {
        private string model = null;
        private double idleTime = 0;
        private double talkHours = 0;
        public enum BatteryTypes { None, LiIon, NiMH, NiCd, LiPol }
        private BatteryTypes batteryType;

        public Battery()
            : this(null) { }

        public Battery(string model)
            : this(model, 0) { }

        public Battery(string model, double idleTime)
            : this(model, idleTime, 0) { }

        public Battery(string model, double idleTime, double talkHours)
            : this(model, idleTime, talkHours, BatteryTypes.None) { }

        public Battery(string model, double idleTime, double talkHours, BatteryTypes battery)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.talkHours = talkHours;
            this.batteryType = battery;
        }
    }

    public class Display
    {
        private double size;
        private double colors;

        public Display()
            : this(0) { }

        public Display(double size)
            : this(size, 0) { }

        public Display(double size, double colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }
}