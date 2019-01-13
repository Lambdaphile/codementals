/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 19:
|
|     Create a class GSMCallHistoryTest, with which to test
|     the functionality of the class GSM, from task 12,
|     as an object of type GSM. Then add to it a few phone
|     calls (Call). Display information about each phone call.
|
|     Assuming that the price per minute is 0.37, calculate
|     and display the total cost of all calls.
|
|     Remove the longest conversation from archive with
|     phone calls and calculate the total price for all
|     calls again. Finally, clear the archive.
|
| Solutions and Guidelines:
|
|     Follow the instructions directly from the requirements
|     of the task.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    public class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private double price = 0;
        private string owner = null;
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

            Console.WriteLine("\nTotal talk time {0}min, Total cost: {1:C2}\n\n", totalTime / 60, (totalTime / 60) * Call.Tariff);
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

        public override string ToString()
        {
            return $"Call Date: {CallDate}|  Call Beginning: {CallBeginning}|  Call Duration: {CallDuration}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Call objAsCall = obj as Call;
            if (objAsCall == null) return false;
            else return Equals(objAsCall);
        }

        public bool Equals(Call other)
        {
            if (other == null) return false;
            return (this.callDuration.Equals(other.callDuration));
        }
    }

    public class GSMCallHistoryTest
    {
        public static void DisplayCallHistory(List<Call> callHistory)
        {
            foreach (Call conversation in callHistory)
                Console.WriteLine(conversation);
        }

        public static void Main(string[] args)
        {
            GSM xiaomiMiMax = new GSM("Mi Max", "Xiaomi", 250, "Chewbacca");
            xiaomiMiMax.AddCall("13/Jan/2019", "00:00", 1200);
            xiaomiMiMax.AddCall("14/Jan/2019", "13:00", 180);
            xiaomiMiMax.AddCall("15/Jan/2019", "13:00", 480);
            DisplayCallHistory(xiaomiMiMax.CallHistory);
            xiaomiMiMax.CalculateTotalPrice();

            // Removing longest conversation...
            int x = xiaomiMiMax.CallHistory.Max(max => max.CallDuration);
            xiaomiMiMax.DeleteCall("13/Jan/2019", "00:00", 1200);
            DisplayCallHistory(xiaomiMiMax.CallHistory);
            xiaomiMiMax.CalculateTotalPrice();

            xiaomiMiMax.DeleteCallHistory();
            DisplayCallHistory(xiaomiMiMax.CallHistory);
        }
    }
}