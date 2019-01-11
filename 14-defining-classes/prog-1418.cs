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
        private static string nokia95 = "Nokia 95";
        private List<Call> conversations = new List<Call>();

        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public double Price { get => price; set => price = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Features { get => features; set => features = value; }
        public List<Call> CallHistory { get => conversations; }

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

        public void AddCall(string callDate, string callBeggining, int callDuration)
        {
            conversations.Add(new Call() { CallDate = callDate, CallBeginning = callBeggining, CallDuration = callDuration });
        }

        public void DeleteCall(string callDate, string callBeggining, int callDuration)
        {
            conversations.Remove(new Call() { CallDate = callDate, CallBeginning = callBeggining, CallDuration = callDuration });
        }

        public void DeleteCallHistyory()
        {
            conversations.Clear();
        }

        public void CalculateTotalPrice(double tariff)
        {
            int totalTime = 0;
            foreach (Call call in CallHistory)
            {
                totalTime += call.CallDuration;
            }
            Console.WriteLine("{0:C2}", totalTime * tariff);
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
        private string callDate = null;
        private string callBeginning = null;
        private int callDuration = 0;
        public const float tariff = 0.37f;

        public string CallDate { get => callDate; set => callDate = value; }
        public string CallBeginning { get => callBeginning; set => callBeginning = value; }
        public int CallDuration { get => callDuration; set => callDuration = value; }

        public Call()
        {

        }

        public Call(string callDate, string callBeginning, int callDuration)
        {
            this.callDate = callDate;
            this.callBeginning = callBeginning;
            this.callDuration = callDuration;
        }

        public override string ToString()
        {
            return $"callDate: {CallDate, -10} callBeginning: {callBeginning, -10} callDuration: {callBeginning, -10}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Call objAsPart = obj as Call;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(Call other)
        {
            if (other == null) return false;
            return (this.CallDate.Equals(other.callDate));
        }
    }

    public class Trigger
    {
        public static void Main(string[] args)
        {
            GSM myGSM = new GSM();
            Call firstCall = new Call("date", "start", 5);
            Call secondCall = new Call("date2", "start2", 4);
            myGSM.AddCall(firstCall.CallDate, firstCall.CallBeginning, firstCall.CallDuration);
            myGSM.AddCall(secondCall.CallDate, secondCall.CallBeginning, secondCall.CallDuration);
            foreach (Call call in myGSM.CallHistory)
            {
                Console.WriteLine(call);
            }

            myGSM.DeleteCall(firstCall.CallDate, firstCall.CallBeginning, firstCall.CallDuration);
            myGSM.CalculateTotalPrice(Call.tariff);
        }
    }
}