using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4

{
    
    class Robot
    {
        private string robotName;
        private string robotID;
        private int batteryCharge;
        private string robotGreeting;

        public Robot()
        {
        }

        public Robot(string paramID, string paramName, string paramGreeting)
        {
            robotID = paramID;
            robotName = paramName;
            robotGreeting = paramGreeting;
        }

        public int GetBatteryCharged(int chargePoints)
        {
            return batteryCharge;
        }

        public void SetBatteryCharge(int chargePoints)
        {
            batteryCharge = chargePoints;
        }

        public void ChargeBattery(int chargePoints)
        {
            batteryCharge += chargePoints;
        }

        public void DrainBattery(int chargePoints)
        {
            batteryCharge -= chargePoints;
        }

        public int BatteryCharge 
        {
            get 
            { 
                return batteryCharge;
            }
            set 
            { 
                batteryCharge = value; 
            }
       
        }
        public override string ToString()
        {
            return "Robot ID: " + robotID +
            ", name: " + robotName +
            ", greeting: " + robotGreeting +
            ", battery: " + batteryCharge;
        }
    }
    
}
