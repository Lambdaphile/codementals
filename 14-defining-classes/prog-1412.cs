/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 12:
|
|     Add a method to the class GSM, which returns information
|     about the object as a string
|
| Solutions and Guidelines:
|
|     Override the method ToString() .
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
            : this(model, manufacturer, price, owner, null) { }

        public GSM(string model, string manufacturer, double price, string owner, string features)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.features = features;
        }

        public static void DisplayNokia95Info()
        {
            Console.WriteLine(nokia95);
        }

        public void GetObjectInfo()
        {
            Console.WriteLine(this.model.ToString());
            Console.WriteLine(this.manufacturer.ToString());
            Console.WriteLine(this.price.ToString());
            Console.WriteLine(this.owner.ToString());
        }

        public override string ToString()
        {
            return "Model: " + this.model + "\nManufacturer: " + this.manufacturer + "\nPrice: " +
                this.price + "$" + "\nOwner: " + this.owner + "\nFeatures: " + this.features + "\n";
        }
    }

    public class Battery
    {
        private string model = null;
        private double idleTime = 0;
        private double talkHours = 0;
        public enum BatteryType { None, LiIon, NiMH, NiCd, LiPol }
        private BatteryType battery;

        public Battery()
        : this(null) { }

        public Battery(string model)
            : this(model, 0) { }

        public Battery(string model, double idleTime)
            : this(model, idleTime, 0) { }

        public Battery(string model, double idleTime, double talkHours)
            : this(model, idleTime, talkHours, BatteryType.None) { }

        public Battery(string model, double idleTime, double talkHours, BatteryType battery)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.talkHours = talkHours;
            this.battery = battery;
        }
    }

    public class Display
    {
        private double size;
        private double colors;

        public Display()
            : this(0) {}

        public Display(double size)
            : this(size, 0) { }

        public Display(double size, double colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }
}