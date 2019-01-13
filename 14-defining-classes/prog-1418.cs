/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 18:
|
|     In GSM class, add a method that calculates the total
|     amount of calls (Call) from the archive of phone
|     calls (CallHistory), as the price of a phone call
|     is passed as a parameter to the method.
|
| Solutions and Guidelines:
|
|    Because the tariff is fixed, you can easily calculate
|    the total price of all calls.
|
*/

using System;
using System.Collections.Generic;

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
        private List<Call> conversations = new List<Call>();

        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public double Price { get => price; set => price = value; }
        public string Owner { get => owner; set => owner = value; }
        public List<Call> CallHistory { get => conversations; }

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
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public void AddCall(string callDate, string callBeggining, int callDuration)
        {
            conversations.Add(new Call() { CallDate = callDate, CallBeginning = callBeggining, CallDuration = callDuration });
        }

        public void DeleteCall(string callDate, string callBeggining, int callDuration)
        {
            conversations.Remove(new Call() { CallDate = callDate, CallBeginning = callBeggining, CallDuration = callDuration });
        }

        public void DeleteCallHistory()
        {
            conversations.Clear();
        }

        public void CalculateTotalPrice()
        {
            int totalTime = 0;
            foreach (Call call in CallHistory)
                totalTime += call.CallDuration;

            Console.WriteLine("{0:C2}", totalTime * Call.Tariff);
        }

        public static void DisplayNokia95Info()
        {
            Console.WriteLine(nokia95);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Model: " + this.model + "\nManufacturer: " + this.manufacturer + "\nPrice: " +
                this.price + "$" + "\nOwner: " + this.owner + "\n");
        }

        public override string ToString()
        {
            return "Model: " + this.model + "\nManufacturer: " + this.manufacturer + "\nPrice: " +
                this.price + "$" + "\nOwner: " + this.owner + "\n";
        }
    }

    public class Battery
    {
        private string model = null;
        private double idleTime = 0;
        private double talkHours = 0;
        public enum BatteryTypes { None, LiIon, NiMH, NiCd, LiPol }
        private BatteryTypes batteryType;

        public string Model { get => model; set => model = value; }
        public double IdleTime { get => idleTime; set => idleTime = value; }
        public double TalkHours { get => talkHours; set => talkHours = value; }
        public BatteryTypes BatteryType { get => batteryType; set => batteryType = value; }

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
            this.Model = model;
            this.IdleTime = idleTime;
            this.TalkHours = talkHours;
            this.BatteryType = battery;
        }
    }

    public class Display
    {
        private double size;
        private double colors;

        public double Size { get => size; set => size = value; }
        public double Colors { get => colors; set => colors = value; }

        public Display()
            : this(0) { }

        public Display(double size)
            : this(size, 0) { }

        public Display(double size, double colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }

    public class Call
    {
        private string callDate = null;
        private string callBeginning = null;
        private int callDuration = 0;
        private const float tariff = 0.37f;

        public string CallDate { get => callDate; set => callDate = value; }
        public string CallBeginning { get => callBeginning; set => callBeginning = value; }
        public int CallDuration { get => callDuration; set => callDuration = value; }
        public static float Tariff { get => tariff; }

        public Call() { }

        public Call(string callDate, string callBeginning, int callDuration)
        {
            this.CallDate = callDate;
            this.CallBeginning = callBeginning;
            this.CallDuration = callDuration;
        }
    }
}