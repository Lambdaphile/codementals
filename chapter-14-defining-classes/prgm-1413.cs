/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 13:
|
|     Define properties to encapsulate the data in classes GSM,
|     Battery and Display.
|
| Solutions and Guidelines:
|
|     In classes GSM, Battery and Display define suitable private fields
|     and generate get / set . You can use automatic generation
|     in Visual Studio.
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
        private string model = null;
        private string manufacturer = null;
        private double price = 0;
        private string owner = null;
        private string features = null;
        private static string nokia95 = "Nokia 95";

        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public double Price { get => price; set => price = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Features { get => features; set => features = value; }

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
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Features = features;
        }

        public static void DisplayNokia95Info()
        {
            Console.WriteLine(nokia95);
        }

        public void GetObjectInfo()
        {
            Console.WriteLine(this.Model.ToString());
            Console.WriteLine(this.Manufacturer.ToString());
            Console.WriteLine(this.Price.ToString());
            Console.WriteLine(this.Owner.ToString());
        }

        public override string ToString()
        {
            return "Model: " + this.Model + "\nManifacturer: " + this.Manufacturer + "\nPrice: " +
                this.Price + "$" + "\nOwner: " + this.Owner;
        }
    }

    public class Battery
    {
        private string model = null;
        private int idleTime = 0;
        private double talkHours = 0;
        public enum BatteryType { Li_Ion, NiMH, NiCd, Li_Pol }
        private BatteryType battery;

        public string Model { get => model; set => model = value; }
        public int IdleTime { get => idleTime; set => idleTime = value; }
        public double TalkHours { get => talkHours; set => talkHours = value; }

        public Battery()
        {

        }

        public Battery(string model)
            : this(model, 0)
        {

        }

        public Battery(string model, int idleTime)
            : this(model, idleTime, 0)
        {

        }

        public Battery(string model, int idleTime, double talkHours)
            : this(model, idleTime, talkHours, BatteryType.Li_Ion)
        {

        }

        public Battery(string model, int idleTime, double talkHours, BatteryType battery)
        {
            this.Model = model;
            this.IdleTime = idleTime;
            this.TalkHours = talkHours;
            this.battery = battery;
        }
    }

    public class Display
    {
        private double size;
        private double colors;

        public double Size { get => size; set => size = value; }
        public double Colors { get => colors; set => colors = value; }

        public Display()
        {

        }

        public Display(double size)
            : this(size, 0)
        {

        }

        public Display(double size, double colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }

    public class ClassTester
    {
        public static void DisplayExceptionDetails(Exception e)
        {
            Console.Write("\n\nDo you want to see error details? (Y/N): ");
            string userChoice = Console.ReadLine();
            if (userChoice == "Y" || userChoice == "y")
                Console.WriteLine("\n" + e.StackTrace);
        }

        public static void Main(string[] args)
        {
            try
            {
                GSM gsm1 = new GSM();
                GSM gsm2 = new GSM("Mi Max 3", "Xiaomi");
                Console.WriteLine(gsm2);
                gsm2.Model = "Suck my Cocker, Sucker";
                Console.WriteLine(gsm2);
                GSM gsm3 = new GSM("Poccophone", "Xiaomi", 300);
                GSM gsm4 = new GSM("6t", "OnePlus", 500, "Chewbacca");
                Console.WriteLine(gsm4);
            }
            catch (Exception gmsException)
            {
                Console.WriteLine("GSM class has problem.");
                DisplayExceptionDetails(gmsException);
            }

            try
            {
                Battery batter1 = new Battery("Li-Ion", 30);
                Battery battery2 = new Battery("Li-Ion", 40, 6);
                Battery battery3 = new Battery("f", 0, 0, Battery.BatteryType.Li_Ion);
            }
            catch (Exception batteryException)
            {
                Console.WriteLine("Battery class problem.");
                DisplayExceptionDetails(batteryException);
            }

            try
            {
                Display display1 = new Display(6.44);
                Display display2 = new Display(6.44, 160.000);
            }
            catch (Exception displayException)
            {
                Console.WriteLine("Display class problem.");
                DisplayExceptionDetails(displayException);
            }
        }
    }
}