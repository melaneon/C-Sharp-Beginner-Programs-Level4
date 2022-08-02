using System;

namespace Problem4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            Robot huey = new Robot("123", "huey", "\" beep tweet\"");
            huey.BatteryCharge = 100;
            huey.DrainBattery(25);
            huey.ChargeBattery(45);
            Console.WriteLine(huey);
        }
    }
}
