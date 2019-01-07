/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 9:
|
|     Declare several constructors for each of the classes created
|     by the previous task, which have different lists of parameters
|     (for complete information about the mobile phone or part of it).
|     Data fields that are unknown have to be initialized respectively
|     with null or 0.
|
| Solutions and Guidelines:
|
|     Define the described constructors and create a test program
|     to check if classes are working properly.
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

        public GSM()
        {

        }

        public GSM(string model)
            : this(model, null)
        {

        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0)
        {

        }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer, price, null)
        {

        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer, price, owner, null)
        {

        }

        public GSM(string model, string manufacturer, double price, string owner, string features)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.features = features;
        }
    }

    public class Battery
    {
        private string model = null;
        private double idleTime = 0;
        private double talkHours = 0;

        public Battery()
        {

        }

        public Battery(string model)
            : this(model, 0)
        {

        }

        public Battery(string model, double idleTime)
            : this(model, idleTime, 0)
        {

        }

        public Battery(string model, double idleTime, double talkHours)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.talkHours = talkHours;
        }
    }

    public class Display
    {
        private double size;
        private double colors;

        public Display()
        {

        }

        public Display(double size)
            : this(size, 0)
        {

        }

        public Display(double size, double colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            GSM gsm1 = new GSM();
            GSM gsm2 = new GSM("Mi Max 3", "Xiaomi");
            GSM gsm3 = new GSM("Poccophone", "Xiaomi", 300);
            GSM gsm4 = new GSM("6t", "OnePlus", 500, "Chewbacca", "Coolness B)");

            Battery battery1 = new Battery();
            Battery battery2 = new Battery("SBPL0086903", 210.00, 7.05);

            Display display1 = new Display(6.44);
            Display display2 = new Display(6.44, 160.000);
        }
    }
}