/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 15:
|
|     Create a class Call, which contains information about a call
|     made via mobile phone. It should contain information about date,
|     time of start and duration of the call.
|
| Solutions and Guidelines:
|
|     Read about the class List<T> in Internet. The class GSM
|     has to store it's conversations in a list of type List<Call>.
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

        public void PrintInfo()
        {
            Console.WriteLine("Model: " + this.Model + "\nManufacturer: " + this.Manufacturer + "\nPrice: " +
                this.Price + "$" + "\nOwner: " + this.Owner);
        }

        public override string ToString()
        {
            return "Model: " + this.Model + "\nManufacturer: " + this.Manufacturer + "\nPrice: " +
                this.Price + "$" + "\nOwner: " + this.Owner;
        }
    }

    public class Battery
    {
        private string model = null;
        private double idleTime = 0;
        private double talkHours = 0;
        public enum BatteryType { LiIon, NiMH, NiCd, LiPol }
        private BatteryType battery;

        public string Model { get => model; set => model = value; }
        public double IdleTime { get => idleTime; set => idleTime = value; }
        public double TalkHours { get => talkHours; set => talkHours = value; }

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
            : this(model, idleTime, talkHours, BatteryType.LiIon)
        {

        }

        public Battery(string model, double idleTime, double talkHours, BatteryType battery)
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

    public class Call
    {
        DateTime date;
        string time;
        TimeSpan duration;

        public static void Main(string[] args)
        {
            List<Call> conversation = new List<Call>();
            conversation.Add(new Call() { date = DateTime.Today, time = DateTime.Now.ToString("hh:mm"), duration = TimeSpan.MaxValue });
            Console.WriteLine(conversation[0]);
        }
    }
}